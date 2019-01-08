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
                DatabaseConfigInfo databaseConfigInfo = GetDatabasConfigInfo();              
                RedisConfigInfo redisConfigInfo = GetRedisConfigInfo();
                MailConfigInfo mailConfigInfo = GetMailConfigInfo();
                SessionConfigInfo sessionConfigInfo = GetSessionConfigInfo();
                CockieConfigInfo cockieConfigInfo = GetCockieConfigInfo();

                EnvTemplate envTemplate = new EnvTemplate(smartApp.Id, databaseConfigInfo, redisConfigInfo, mailConfigInfo, sessionConfigInfo, cockieConfigInfo);

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

        private DatabaseConfigInfo GetDatabasConfigInfo()
        {
            DatabaseConfigInfo databaseConfigInfo = new DatabaseConfigInfo();

            var databaseType = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabaseType") ? _context.DynamicContext.DatabaseType as List<Answer> : new List<Answer>();
            databaseConfigInfo.Type = (databaseType != null && databaseType.Count > 0) ? databaseType.FirstOrDefault().Value : "mysql";

            var databaseName = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabaseName") ? _context.DynamicContext.DatabaseName as List<Answer> : new List<Answer>();
            databaseConfigInfo.Name = (databaseName != null && databaseName.Count > 0) ? databaseName.FirstOrDefault().Value : "phpDatabase";

            var databaseHost = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabaseHost") ? _context.DynamicContext.DatabaseHost as List<Answer> : new List<Answer>();
            databaseConfigInfo.Host = (databaseHost != null && databaseHost.Count > 0) ? databaseHost.FirstOrDefault().Value : "127.0.0.1";

            var databasePort = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabasePort") ? _context.DynamicContext.DatabasePort as List<Answer> : new List<Answer>();
            databaseConfigInfo.Port = (databasePort != null && databasePort.Count > 0) ? databasePort.FirstOrDefault().Value : "3306";

            var databaseUsername = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabaseUsername") ? _context.DynamicContext.DatabaseUsername as List<Answer> : new List<Answer>();
            databaseConfigInfo.Username = (databaseUsername != null && databaseUsername.Count > 0) ? databaseUsername.FirstOrDefault().Value : "root";

            var databasePassword = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("DatabasePassword") ? _context.DynamicContext.DatabasePassword as List<Answer> : new List<Answer>();
            databaseConfigInfo.Password = (databasePassword != null && databasePassword.Count > 0) ? databasePassword.FirstOrDefault().Value : "password";

            return databaseConfigInfo;
        }

        private RedisConfigInfo GetRedisConfigInfo()
        {
            RedisConfigInfo redisConfigInfo = new RedisConfigInfo();

            var redistHost = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("RedisHost") ? _context.DynamicContext.RedisHost as List<Answer> : new List<Answer>();
            redisConfigInfo.Host = (redistHost != null && redistHost.Count > 0) ? redistHost.FirstOrDefault().Value : "127.0.0.1";

            var redistPort = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("RedisPort") ? _context.DynamicContext.RedisPort as List<Answer> : new List<Answer>();
            redisConfigInfo.Port = (redistPort != null && redistPort.Count > 0) ? redistPort.FirstOrDefault().Value : "6379";


            var redisPassword = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("RedisPassword") ? _context.DynamicContext.RedisPassword as List<Answer> : new List<Answer>();
            redisConfigInfo.Password = (redisPassword != null && redisPassword.Count > 0) ? redisPassword.FirstOrDefault().Value : "null";

            return redisConfigInfo;
        }

        private MailConfigInfo GetMailConfigInfo()
        {
            MailConfigInfo mailConfigInfo = new MailConfigInfo();

            var emailDriver = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("EmailDriver") ? _context.DynamicContext.EmailDriver as List<Answer> : new List<Answer>();
            mailConfigInfo.Driver = (emailDriver != null && emailDriver.Count > 0) ? emailDriver.FirstOrDefault().Value : "log";

            var emailHost = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("EmailHost") ? _context.DynamicContext.EmailHost as List<Answer> : new List<Answer>();
            mailConfigInfo.Host = (emailHost != null && emailHost.Count > 0) ? emailHost.FirstOrDefault().Value : "smtp.mailtrap.io";

            var emailPort = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("EmailPort") ? _context.DynamicContext.EmailPort as List<Answer> : new List<Answer>();
            mailConfigInfo.Port = (emailPort != null && emailPort.Count > 0) ? emailPort.FirstOrDefault().Value : "2525";

            var emailUsername = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("EmailUsername") ? _context.DynamicContext.EmailUsername as List<Answer> : new List<Answer>();
            mailConfigInfo.Username = (emailUsername != null && emailUsername.Count > 0) ? emailUsername.FirstOrDefault().Value : "null";

            var emailPassword = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("EmailPassword") ? _context.DynamicContext.EmailPassword as List<Answer> : new List<Answer>();
            mailConfigInfo.Password = (emailPassword != null && emailPassword.Count > 0) ? emailPassword.FirstOrDefault().Value : "null";

            return mailConfigInfo;

        }

        private SessionConfigInfo GetSessionConfigInfo()
        {
            SessionConfigInfo sessionConfigInfo = new SessionConfigInfo();

            var sessionDriver = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("SessionDriver") ? _context.DynamicContext.SessionDriver as List<Answer> : new List<Answer>();
            sessionConfigInfo.Driver = (sessionDriver != null && sessionDriver.Count > 0) ? sessionDriver.FirstOrDefault().Value : "file";

            var sessionLifetime = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("SessionLifetime") ? _context.DynamicContext.SessionLifetime as List<Answer> : new List<Answer>();
            sessionConfigInfo.Lifttime = (sessionLifetime != null && sessionLifetime.Count > 0) ? sessionLifetime.FirstOrDefault().Value : "120";

            var sessionExpireOnClose  = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("SessionExpireOnClose") ? _context.DynamicContext.SessionExpireOnClose as List<Answer> : new List<Answer>();
            sessionConfigInfo.ExpireOnClose = (sessionExpireOnClose != null && sessionExpireOnClose.Count > 0) ? sessionExpireOnClose.FirstOrDefault().Value : "false";

            var sessionTable = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("SessionTable") ? _context.DynamicContext.SessionTable as List<Answer> : new List<Answer>();
            sessionConfigInfo.Table = (sessionTable != null && sessionTable.Count > 0) ? sessionTable.FirstOrDefault().Value : "session";
            
            if (sessionConfigInfo.ExpireOnClose.Equals("expireOnCloseYes"))
            {
                sessionConfigInfo.ExpireOnClose = "true";
            }
            else
            {
                sessionConfigInfo.ExpireOnClose = "false";
            }

            var sessionEncryption = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("SessionEncryption") ? _context.DynamicContext.SessionEncryption as List<Answer> : new List<Answer>();
            sessionConfigInfo.Encrypt = (sessionEncryption != null && sessionEncryption.Count > 0) ? sessionEncryption.FirstOrDefault().Value : "false";

            if (sessionConfigInfo.Encrypt.Equals("expireOnCloseYes"))
            {
                sessionConfigInfo.Encrypt = "true";
            }
            else
            {
                sessionConfigInfo.Encrypt = "false";
            }

            return sessionConfigInfo;
        }

        private CockieConfigInfo GetCockieConfigInfo()
        {
            CockieConfigInfo cockieConfigInfo = new CockieConfigInfo();

            var sessionCookieName = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("SessionCookieName") ? _context.DynamicContext.SessionCookieName as List<Answer> : new List<Answer>();
            cockieConfigInfo.Name= (sessionCookieName != null && sessionCookieName.Count > 0) ? sessionCookieName.FirstOrDefault().Value : "";

            var sessionCookiePath = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("SessionCookiePath") ? _context.DynamicContext.SessionCookiePath as List<Answer> : new List<Answer>();
            cockieConfigInfo.Path = (sessionCookiePath != null && sessionCookiePath.Count > 0) ? sessionCookiePath.FirstOrDefault().Value : "";

            var sessionCookieDomainName = ((IDictionary<string, object>)_context.DynamicContext).ContainsKey("SessionCookieDomainName") ? _context.DynamicContext.SessionCookieDomainName as List<Answer> : new List<Answer>();
            cockieConfigInfo.Domain = (sessionCookieDomainName != null && sessionCookieDomainName.Count > 0) ? sessionCookieDomainName.FirstOrDefault().Value : "";

            return cockieConfigInfo;
        }
    }
}
