using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;
using Mobioos.Scaffold.BaseInfrastructure.Notifiers;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using Mobioos.Scaffold.BaseGenerators.Helpers;
using Mobioos.Foundation.Prompt;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class ViewModelsWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ViewModelsWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
        {
            _context = context;
            _writingService = writingService;
            _workflowNotifier = workflowNotifier;
        }

        public override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            if (null == _context.Manifest)
                throw new ArgumentNullException(nameof(_context.Manifest));

            SmartAppInfo smartApp = _context.Manifest;

            _workflowNotifier.Notify(nameof(ViewModelsWritingSteps), NotificationType.GeneralInfo, "Generating PHP view models");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformViewModels(smartApp);

            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformViewModels(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                string modelSuffix = GetModelSuffix();
                string viewModelSuffix = GetViewModelSuffix();

                List<EntityInfo> alreadyCreated = new List<EntityInfo>();

                smartApp.Api.ToList()
                    .ForEach(api => api.Actions.ToList()
                    .ForEach(action =>
                    {
                        if (action.ReturnType != null && !alreadyCreated.Contains(action.ReturnType))
                        {
                            alreadyCreated.Add(action.ReturnType);
                            TransformViewModel(action.ReturnType, viewModelSuffix, modelSuffix);
                        }
                     }));
            }
        }

        private void TransformViewModel(EntityInfo dataModel, string viewModelSuffix, string modelSuffix)
        {
            if (dataModel != null)
            {
                ViewModelsTemplate viewModelTemplate = new ViewModelsTemplate(dataModel, viewModelSuffix, modelSuffix);
                _writingService.WriteFile(Path.Combine(_context.BasePath, viewModelTemplate.OutputPath, TextConverter.PascalCase(dataModel.Id) + viewModelSuffix + ".php"), viewModelTemplate.TransformText());
            }
        }

        private string GetModelSuffix()
        {
            var modelSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ModelSuffix") ? _context.DynamicContext.ModelSuffix as List<Answer> : new List<Answer>();
            return (modelSuffix != null && modelSuffix.Count > 0) ? modelSuffix.FirstOrDefault().Value : "Model";
        }

        private string GetViewModelSuffix()
        {
            var viewModelSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ViewModelSuffix") ? _context.DynamicContext.ViewModelSuffix as List<Answer> : new List<Answer>();
            return (viewModelSuffix != null && viewModelSuffix.Count > 0) ? viewModelSuffix.FirstOrDefault().Value : "ViewModel";
        }
    }
}
