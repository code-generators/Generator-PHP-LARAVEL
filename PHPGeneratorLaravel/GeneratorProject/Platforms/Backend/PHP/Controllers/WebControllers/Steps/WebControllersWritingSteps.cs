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
    public class WebControllersWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public WebControllersWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

            _workflowNotifier.Notify(nameof(WebControllersWritingSteps), NotificationType.GeneralInfo, "Generating PHP webcontrollers");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformWebControllers(smartApp);

            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformWebControllers(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Api != null)
            {
                string controllerSuffix = GetControllerSuffix();
                string modelSuffix = GetModelSuffix();

                foreach (var entity in smartApp.DataModel.Entities)
                {
                    if (!entity.IsAbstract)
                    {
                        WebControllersTemplate template = new WebControllersTemplate(entity, controllerSuffix, modelSuffix);
                        _writingService.WriteFile(Path.Combine(_context.BasePath, template.OutputPath, (TextConverter.PascalCase(entity.Id) + controllerSuffix + ".php")), template.TransformText());
                    }
                }
            }
        }

        private string GetControllerSuffix()
        {
            var controllerSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ControllerSuffix") ? _context.DynamicContext.ControllerSuffix as List<Answer> : new List<Answer>();
            return (controllerSuffix != null && controllerSuffix.Count > 0) ? controllerSuffix.FirstOrDefault().Value : "Controller";
        }

        private string GetModelSuffix()
        {
            var modelSuffix = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("ModelSuffix") ? _context.DynamicContext.ModelSuffix as List<Answer> : new List<Answer>();

            return (modelSuffix != null && modelSuffix.Count > 0) ? modelSuffix.FirstOrDefault().Value : "Model";
        }
    }
}
