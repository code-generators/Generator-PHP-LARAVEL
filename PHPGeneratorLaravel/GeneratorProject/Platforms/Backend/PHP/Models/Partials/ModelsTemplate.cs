using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;
using Mobioos.Scaffold.Generators.Helpers;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class ModelsTemplate : TemplateBase
    {
        private EntityInfo _entityInfo { get; set; }
        private string _modelSuffix { get; set; }
        private string _modelPath = "App\\Models\\";
       
        public ModelsTemplate(EntityInfo entityInfo, string modelSuffix) : base(entityInfo)
        {
            _entityInfo = entityInfo;
            _modelSuffix = TextConverter.PascalCase(modelSuffix);
        }

       public override string OutputPath => string.Format(@"app\Models\{0}{1}.php", TextConverter.PascalCase(_entityInfo.Id), _modelSuffix);
    }
}