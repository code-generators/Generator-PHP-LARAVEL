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
    [Activity(Order = 3)]
    public class ControllersActivity: GeneratorActivity
    {
        private string _templatesDirectoryPath { get; set; }

        public ControllersActivity(string name, string basePath)
           : base(name, basePath)
        {
        }

        [Task(Order = 1)]
        public async override Task Initializing(IActivityContext activityContext)
        {
            _templatesDirectoryPath = Path.Combine(
                activityContext.DynamicContext.GeneratorPath,
                "Platforms\\Frontend\\Example\\HelloWorld\\Templates"
            );
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
            TransformWebControllers(smartApp);
            TransformApiControllers(smartApp);
            await base.Writing();
        }

        private void TransformWebControllers(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Api != null)
            {
                string controllerSuffix = string.IsNullOrEmpty(Context.DynamicContext.ControllerSuffix) ? "Controller" : Context.DynamicContext.ControllerSuffix;
                string modelSuffix = string.IsNullOrEmpty(Context.DynamicContext.ModelSuffix) ? "Model" : Context.DynamicContext.ModelSuffix;

                foreach (var entity in smartApp.DataModel.Entities)
                {
                    if (!entity.IsAbstract)
                    {
                        WebControllersTemplate template = new WebControllersTemplate(entity, controllerSuffix, modelSuffix);
                        WriteFile(Path.Combine(BasePath, template.OutputPath, (TextConverter.PascalCase(entity.Id) + controllerSuffix + ".php")), template.TransformText());
                    }
                }
            }
        }

        private void TransformApiControllers(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.Api != null)
            {
                string controllerSuffix = string.IsNullOrEmpty(Context.DynamicContext.ControllerSuffix) ? "Controller" : Context.DynamicContext.ControllerSuffix;

                foreach (var apiList in smartApp.Api)
                {
                    ApiControllersTemplate template = new ApiControllersTemplate(apiList, controllerSuffix);
                    WriteFile(Path.Combine(BasePath, template.OutputPath, (TextConverter.PascalCase(apiList.Id) + controllerSuffix + ".php")), template.TransformText());
                }
            }
        }

    }
}
