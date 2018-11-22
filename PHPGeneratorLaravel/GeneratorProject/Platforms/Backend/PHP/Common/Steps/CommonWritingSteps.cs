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
using System.Collections.Generic;
using Mobioos.Foundation.Prompt;
using System.Linq;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public class CommonWritingSteps: StepBodyAsync
    {
        private readonly ISessionContext _context;
        private readonly IWriting _writingService;
        private readonly IWorkflowNotifier _workflowNotifier;

        public CommonWritingSteps(ISessionContext context, IWriting writingService, IWorkflowNotifier workflowNotifier)
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
               var commonTemplates = "Platforms\\Backend\\PHP\\Common\\Templates";
             _workflowNotifier.Notify(nameof(CommonWritingSteps), NotificationType.GeneralInfo, "Generating php common files");

            if (_context.BasePath != null && _context.GeneratorPath != null)
            {
                var commonTemplatesDirectoryPath = Path.Combine(_context.GeneratorPath, commonTemplates);

                TransformStaticFiles(smartApp, commonTemplatesDirectoryPath);
                TransformEnvTemplate(smartApp);
                TransformComposerJsonTemplate(smartApp);
                TransformConfigAppTemplate(smartApp);
                TransformSidebarTemplate(smartApp);

            }
            return Task.FromResult(ExecutionResult.Next());
        }
        private void TransformStaticFiles(SmartAppInfo smartApp, string commonTemplatesDirectoryPath)
        {
            if (smartApp != null && commonTemplatesDirectoryPath != null)
            {
                _writingService.CopyDirectory(commonTemplatesDirectoryPath, _context.BasePath);
            }
        }

        private void TransformEnvTemplate(SmartAppInfo smartApp)
        {

            if (smartApp != null)
            {
                string DatabaseType = GetDatabaseType();
                string DatabaseName = GetDatabaseName();
                string DatabaseHost = GetDatabaseHost();
                string DatabasePort = GetDatabasePort();
                string DatabaseUsername = GetDatabaseUsername();
                string DatabasePassword = GetDatabasePassword();

                EnvTemplate envTemplate = new EnvTemplate(smartApp.Id, DatabaseType, DatabaseName,
                    DatabaseHost, DatabasePort, DatabaseUsername, DatabasePassword );

                _writingService.WriteFile(Path.Combine(_context.BasePath, envTemplate.OutputPath), envTemplate.TransformText());
            }
        }

        private void TransformComposerJsonTemplate(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                ComposerJsonTemplate composerJsonTemplate = new ComposerJsonTemplate(smartApp);

                _writingService.WriteFile(Path.Combine(_context.BasePath, composerJsonTemplate.OutputPath), composerJsonTemplate.TransformText());
            }
        }

        private void TransformConfigAppTemplate(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                ConfigAppTemplate configAppTemplate = new ConfigAppTemplate(smartApp.Id);

                _writingService.WriteFile(Path.Combine(_context.BasePath, configAppTemplate.OutputPath), configAppTemplate.TransformText());
            }
        }

        private void TransformSidebarTemplate(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.DataModel != null)
            {
                SidebarPartialTemplate sidebarPartialTemplate = new SidebarPartialTemplate(smartApp.DataModel, smartApp.Id);

                _writingService.WriteFile(Path.Combine(_context.BasePath, sidebarPartialTemplate.OutputPath), sidebarPartialTemplate.TransformText());
            }
        }

        private string GetDatabaseType()
        {
            var DatabaseType = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabaseType") ? _context.DynamicContext.DatabaseType as List<Answer> : new List<Answer>();
            return (DatabaseType != null && DatabaseType.Count > 0) ? DatabaseType.FirstOrDefault().Value : "mysql";
        }

        private string GetDatabaseName()
        {
            var DatabaseName = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabaseName") ? _context.DynamicContext.DatabaseName as List<Answer> : new List<Answer>();
            return (DatabaseName != null && DatabaseName.Count > 0) ? DatabaseName.FirstOrDefault().Value : "phpDatabase";
        }

        private string GetDatabaseHost()
        {
            var DatabaseHost = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabaseHost") ? _context.DynamicContext.DatabaseHost as List<Answer> : new List<Answer>();
            return (DatabaseHost != null && DatabaseHost.Count > 0) ? DatabaseHost.FirstOrDefault().Value : "127.0.0.1";
        }

        private string GetDatabasePort()
        {
            var DatabasePort = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabasePort") ? _context.DynamicContext.DatabasePort as List<Answer> : new List<Answer>();
            return (DatabasePort != null && DatabasePort.Count > 0) ? DatabasePort.FirstOrDefault().Value : "3306";
        }

        private string GetDatabaseUsername()
        {
            var DatabaseUsername = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabaseUsername") ? _context.DynamicContext.DatabaseUsername as List<Answer> : new List<Answer>();
            return (DatabaseUsername != null && DatabaseUsername.Count > 0) ? DatabaseUsername.FirstOrDefault().Value : "root";
        }

        private string GetDatabasePassword()
        {
            var DatabasePassword = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabasePassword") ? _context.DynamicContext.DatabasePassword as List<Answer> : new List<Answer>();
            return (DatabasePassword != null && DatabasePassword.Count > 0) ? DatabasePassword.FirstOrDefault().Value : "password";
        }

    }
}
