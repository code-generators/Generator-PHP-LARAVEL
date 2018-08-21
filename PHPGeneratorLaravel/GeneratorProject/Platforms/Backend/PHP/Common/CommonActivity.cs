using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Core.Runtime.Activities;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Infrastructure.Runtime;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [Activity(Order = 1)]
    public class CommonActivity : GeneratorActivity
    {
        private string _currentDirectoryPath;
        private string _commonTemplates;
        private string _commonTemplatesDirectoryPath;

        public CommonActivity(string name, string basePath) : base(name, basePath)
        {
        }

        [Task(Order = 1)]
        public async override Task Initializing(IActivityContext activityContext)
        {
            _currentDirectoryPath = activityContext.DynamicContext.GeneratorPath;
            _commonTemplates = "Platforms\\Backend\\PHP\\Common\\Templates";
            _commonTemplatesDirectoryPath = Path.Combine(_currentDirectoryPath, _commonTemplates);

            await base.Initializing(activityContext);
        }

        [Task(Order = 2)]
        public async override Task Writing()
        {
            if (null == Context.DynamicContext.Manifest)
                throw new ArgumentNullException(nameof(Context.DynamicContext.Manifest));

            SmartAppInfo smartApp = Context.DynamicContext.Manifest;

            TransformStaticFiles(smartApp, _commonTemplatesDirectoryPath);

            TransformEnvTemplate(smartApp);

            TransformComposerJsonTemplate(smartApp);

            TransformConfigAppTemplate(smartApp);

            TransformSidebarTemplate(smartApp);

            await base.Writing();
        }

        private void TransformStaticFiles(SmartAppInfo smartApp, string commonTemplatesDirectoryPath)
        {
            if (smartApp != null && commonTemplatesDirectoryPath != null)
            {
                // ExecuteTemplates(Constants.PublicActivityName, BasePath, smartApp, Assembly.GetExecutingAssembly());
                CopyDirectory(commonTemplatesDirectoryPath, BasePath);
            }
        }

        private void TransformEnvTemplate(SmartAppInfo smartApp)
        {
            
            if (smartApp != null)
            {
                Context.DynamicContext.DatabaseType = "mysql";
                Context.DynamicContext.DatabaseName = smartApp.Id.ToLower();
                Context.DynamicContext.DatabaseHost = "127.0.0.1";
                Context.DynamicContext.DatabasePort = "3306";
                Context.DynamicContext.DatabaseUsername = "root";
                Context.DynamicContext.DatabasePassword = "password";

                EnvTemplate envTemplate = new EnvTemplate(smartApp.Id,
                    Context.DynamicContext.DatabaseType,
                    Context.DynamicContext.DatabaseName,
                    Context.DynamicContext.DatabaseHost,
                    Context.DynamicContext.DatabasePort,
                    Context.DynamicContext.DatabaseUsername,
                    Context.DynamicContext.DatabasePassword
                    );

                WriteFile(Path.Combine(BasePath, envTemplate.OutputPath), envTemplate.TransformText());
            }
        }
        
        private void TransformComposerJsonTemplate(SmartAppInfo smartApp)
        {
            if(smartApp != null)
            {
                ComposerJsonTemplate composerJsonTemplate = new ComposerJsonTemplate(smartApp);

                WriteFile(Path.Combine(BasePath, composerJsonTemplate.OutputPath), composerJsonTemplate.TransformText());
            }
        }

        private void TransformConfigAppTemplate(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                ConfigAppTemplate configAppTemplate = new ConfigAppTemplate(smartApp.Id);

                WriteFile(Path.Combine(BasePath, configAppTemplate.OutputPath), configAppTemplate.TransformText());
            }
        }

        private void TransformSidebarTemplate(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.DataModel != null)
            {
                SidebarPartialTemplate sidebarPartialTemplate = new SidebarPartialTemplate(smartApp.DataModel, smartApp.Id);

                WriteFile(Path.Combine(BasePath, sidebarPartialTemplate.OutputPath), sidebarPartialTemplate.TransformText());
            }
        }
    }
}
