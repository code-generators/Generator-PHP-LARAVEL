using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Generators.Helpers;
using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class ApiControllersTemplate : TemplateBase
    {
        private ApiInfo _apiInfo { get; set; }
        private string _controllerSuffix { get; set; }

        public ApiControllersTemplate(ApiInfo apiInfo, string controllerSuffix) : base(apiInfo, controllerSuffix)
        {
            _apiInfo = apiInfo;
            _controllerSuffix = controllerSuffix;

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

        public override string OutputPath => "app\\Http\\Controllers\\ApiControllers\\";
    }
}
