using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;
using Mobioos.Scaffold.BaseGenerators.Helpers;
using Mobioos.Foundation.Jade.Extensions;
using System.Linq;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class WebControllersTemplate : TemplateBase
    {
        private string _controllerSuffix { get; set; }
        private string _modelSuffix { get; set; }

        public WebControllersTemplate(EntityInfo entity, string controllerSuffix, string modelSuffix) : base(entity)
        {     
            _controllerSuffix = controllerSuffix;
            _modelSuffix = modelSuffix;
        }

        public string GetPrimaryKey()
        {
            var model = (EntityInfo)Model;

            if (model != null && model.AllProperties() != null)
            {
                var property = model.AllProperties().FirstOrDefault<PropertyInfo>(p => p.IsKey.Equals(true));
                return property != null ? TextConverter.CamelCase(property.Id) : string.Empty;
            }
            return string.Empty;
        }

        public string PHPType(string type)
        {
            string returnType = string.Empty;
            switch (type)
            {
                case "number":
                    returnType = "integer";
                    break;
                case "date":
                    returnType = "dateTime";
                    break;
                default:
                    returnType = type;
                    break;
            }
            return returnType;
        }

        public override string OutputPath => "app\\Http\\Controllers\\WebControllers\\";
    }
}
