using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompts.Interfaces;
using Mobioos.Scaffold.Core.Runtime.Activities;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Infrastructure.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [Activity(Order = 2)]
    public class ModelsActivity : GeneratorActivity
    {
        public ModelsActivity(string name, string basePath)
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
            TransformModels(smartApp);
            TransformDatabaseMigrations(smartApp);

            await base.Writing();
        }

        private void TransformModels(SmartAppInfo smartApp)
        {
            if (smartApp != null && smartApp.DataModel != null && smartApp.DataModel.Entities != null)
            {
                string modelSuffix = string.IsNullOrEmpty(Context.DynamicContext.ModelSuffix) ? "Model" : Context.DynamicContext.ModelSuffix;

                foreach (var entity in smartApp.DataModel.Entities)
                {
                    ModelsTemplate template = new ModelsTemplate(entity, modelSuffix);
                    WriteFile(Path.Combine(BasePath, template.OutputPath), template.TransformText());
                }
            }
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
                        WriteFile(Path.Combine(BasePath, migrationTemplate.OutputPath), migrationTemplate.TransformText());
                    }
                }
            }
        }
    }
}
