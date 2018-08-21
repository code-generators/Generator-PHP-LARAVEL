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
    [Activity(Order = 5)]
    public class ViewActivity : GeneratorActivity
    {
        private string _templatesDirectoryPath { get; set; }

        public ViewActivity(string name, string basePath)
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
            TransformViews(smartApp);

            await base.Writing();
        }
        private void TransformViews(SmartAppInfo manifest)
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

                WriteFile(Path.Combine(BasePath, indexTemplate.OutputPath, folderName, "index.blade.php"), indexTemplate.TransformText());
                WriteFile(Path.Combine(BasePath, showTemplate.OutputPath, folderName, "show.blade.php"), showTemplate.TransformText());
                WriteFile(Path.Combine(BasePath, createTemplate.OutputPath, folderName, "create.blade.php"), createTemplate.TransformText());
                WriteFile(Path.Combine(BasePath, editTemplate.OutputPath, folderName, "edit.blade.php"), editTemplate.TransformText());
                WriteFile(Path.Combine(BasePath, deleteTemplate.OutputPath, folderName, "delete.blade.php"), deleteTemplate.TransformText());
            }
        }
    }
}
