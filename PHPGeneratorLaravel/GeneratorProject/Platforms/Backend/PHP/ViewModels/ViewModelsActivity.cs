using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Prompts.Interfaces;
using Mobioos.Scaffold.Core.Runtime.Activities;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Scaffold.Infrastructure.Runtime;
using Mobioos.Scaffold.Generators.Helpers;

namespace GeneratorProject.Platforms.Backend.PHP
{
    [Activity(Order = 6)]
    public class ViewModelsActivity: GeneratorActivity
    {
        public ViewModelsActivity(string name, string basePath)
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
            TransformViewModels(smartApp);
            await base.Writing();
        }

        private void TransformViewModels(SmartAppInfo smartApp)
        {
            if (smartApp != null)
            {
                string modelSuffix = string.IsNullOrEmpty(Context.DynamicContext.ModelSuffix) ? "Model" : Context.DynamicContext.ModelSuffix;
                string viewModelSuffix = string.IsNullOrEmpty(Context.DynamicContext.ViewModelSuffix) ? "ViewModel" : Context.DynamicContext.ViewModelSuffix;
                List<EntityInfo> alreadyCreated = new List<EntityInfo>();

                smartApp.Api.ToList()
                    .ForEach(api => api.Actions.ToList()
                    .ForEach(action =>
                    {
                        if (action.ReturnType != null && !alreadyCreated.Contains(action.ReturnType))
                        {
                            alreadyCreated.Add(action.ReturnType);
                            TransformViewModel(action.ReturnType, viewModelSuffix, modelSuffix);
                        }
                        //action.Parameters.ToList()
                        //.ForEach(parameter =>
                        //{
                        //    if (parameter.DataModel != null && !alreadyCreated.Contains(parameter.DataModel))
                        //    {
                        //        alreadyCreated.Add(parameter.DataModel);
                        //        TransformViewModel(parameter.DataModel, viewModelSuffix, modelSuffix);
                        //    }
                        //});
                    }));
            }
        }

        private void TransformViewModel(EntityInfo dataModel, string viewModelSuffix, string modelSuffix)
        {
            if (dataModel != null)
            {
                ViewModelsTemplate viewModelTemplate = new ViewModelsTemplate(dataModel, viewModelSuffix, modelSuffix);
                WriteFile(Path.Combine(BasePath, viewModelTemplate.OutputPath, TextConverter.PascalCase(dataModel.Id) + viewModelSuffix + ".php"), viewModelTemplate.TransformText());
            }
        }
    }
}
