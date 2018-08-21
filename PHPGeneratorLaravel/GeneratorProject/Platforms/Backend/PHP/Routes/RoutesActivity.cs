using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompts.Interfaces;
using Mobioos.Scaffold.Core.Runtime.Activities;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Infrastructure.Runtime;
using Mobioos.Scaffold.Generators.Helpers;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [Activity(Order = 4)]
    public class RoutesActivity: GeneratorActivity
    {
        private string _templatesDirectoryPath { get; set; }

        public RoutesActivity(string name, string basePath)
           : base(name, basePath)
        {
        }

        [Task(Order = 1)]
        public async override Task Initializing(IActivityContext activityContext)
        {
             await base.Initializing(activityContext);
        }

        [Task(Order = 2)]
        public override Task Prompting()
        {
            return base.Prompting();
        }

        protected override void ActivityPrompt_Completed(IEnumerable<IQuestion> questions)
        {
            base.ActivityPrompt_Completed(questions);
        }

        [Task(Order = 3)]
        public async override Task Writing()
        {
            if (null == Context.DynamicContext.Manifest)
                throw new ArgumentNullException(nameof(Context.DynamicContext.Manifest));

            SmartAppInfo smartApp = Context.DynamicContext.Manifest;
            TransformRoutes(smartApp);
            //TransformStaticFile(_templatesDirectoryPath);
            await base.Writing();
        }

        private void TransformRoutes(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Api != null)
            {
                string controllerSuffix = string.IsNullOrEmpty(Context.DynamicContext.ControllerSuffix) ? "Controller" : Context.DynamicContext.ControllerSuffix;
                    WebRoutesTemplate webTemplate = new WebRoutesTemplate(smartApp, controllerSuffix);
                ApiRoutesTemplate apiTemplate = new ApiRoutesTemplate(smartApp, controllerSuffix);

                WriteFile(Path.Combine(BasePath, webTemplate.OutputPath), webTemplate.TransformText());
                WriteFile(Path.Combine(BasePath, apiTemplate.OutputPath), apiTemplate.TransformText());
            }
        }

        private void TransformStaticFile(string templatesDirectoryPath)
        {
            CopyDirectory(templatesDirectoryPath, BasePath);
        }
    }
}
