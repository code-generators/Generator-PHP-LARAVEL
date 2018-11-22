using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;
using Mobioos.Scaffold.BaseInfrastructure.Notifiers;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using Mobioos.Scaffold.BaseGenerators.Helpers;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class ViewsWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ViewsWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

            _workflowNotifier.Notify(nameof(ViewsWritingSteps), NotificationType.GeneralInfo, "Generating PHP views");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformViews(smartApp);

            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformViews(SmartAppInfo manifest)
        {
            if (manifest != null)
            {
                var enabledEntities = manifest.DataModel.Entities.Where(e => !e.IsAbstract);
                var applicationId = manifest.Id;

                foreach (var entity in enabledEntities)
                {
                    IndexTemplate indexTemplate = new IndexTemplate(entity, applicationId);
                    ShowTemplate showTemplate = new ShowTemplate(entity, applicationId);
                    CreateTemplate createTemplate = new CreateTemplate(entity, applicationId);
                    EditTemplate editTemplate = new EditTemplate(entity, applicationId);
                    DeleteTemplate deleteTemplate = new DeleteTemplate(entity, applicationId);

                    var folderName = TextConverter.CamelCase(entity.Id);

                    _writingService.WriteFile(Path.Combine(_context.BasePath, indexTemplate.OutputPath, folderName, "index.blade.php"), indexTemplate.TransformText());
                    _writingService.WriteFile(Path.Combine(_context.BasePath, showTemplate.OutputPath, folderName, "show.blade.php"), showTemplate.TransformText());
                    _writingService.WriteFile(Path.Combine(_context.BasePath, createTemplate.OutputPath, folderName, "create.blade.php"), createTemplate.TransformText());
                    _writingService.WriteFile(Path.Combine(_context.BasePath, editTemplate.OutputPath, folderName, "edit.blade.php"), editTemplate.TransformText());
                    _writingService.WriteFile(Path.Combine(_context.BasePath, deleteTemplate.OutputPath, folderName, "delete.blade.php"), deleteTemplate.TransformText());
                }
            }
        }
    }
}
