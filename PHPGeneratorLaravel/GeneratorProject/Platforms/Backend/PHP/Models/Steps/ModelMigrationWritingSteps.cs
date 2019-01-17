using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Contexts;
using Mobioos.Scaffold.BaseInfrastructure.Notifiers;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using WorkflowCore.Interface;
using WorkflowCore.Models;

using System;
using System.IO;
using System.Threading.Tasks;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class ModelMigrationWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public ModelMigrationWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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

            _workflowNotifier.Notify(nameof(ModelMigrationWritingSteps), NotificationType.GeneralInfo, "Generating PHP models migration");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                TransformDatabaseMigrations(smartApp);
            }
            return Task.FromResult(ExecutionResult.Next());
        }

        private void TransformDatabaseMigrations(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.DataModel != null && smartApp.DataModel.Entities != null)
            {
                foreach (var entity in smartApp.DataModel.Entities)
                {
                    if (!entity.IsAbstract)
                    {
                        ModelMigrationTemplate migrationTemplate = new ModelMigrationTemplate(entity);
                        _writingService.WriteFile(Path.Combine(_context.BasePath, migrationTemplate.OutputPath), migrationTemplate.TransformText());
                    }
                }
            }
        }
    }
}
