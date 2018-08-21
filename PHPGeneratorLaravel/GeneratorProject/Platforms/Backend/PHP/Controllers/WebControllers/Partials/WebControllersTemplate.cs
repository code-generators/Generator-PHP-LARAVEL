using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;
using Mobioos.Foundation.Jade.Extensions;
using Mobioos.Scaffold.Generators.Helpers;

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
            var property = model.AllProperties().Where(p => p.IsKey).FirstOrDefault<PropertyInfo>();
            return TextConverter.CamelCase(property.Id);
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
                //case "boolean":
                //    returnType = "boolean";
                //    break;
                default:
                    returnType = type;
                    break;
            }
            return returnType;
        }

        public override string OutputPath => "app\\Http\\Controllers\\WebControllers\\";
    }
}
