using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class ApiRoutesTemplate : TemplateBase
    {
        private string _controllerSuffix { get; set; }

        public ApiRoutesTemplate(SmartAppInfo smartApp, string controllerSuffix) : base(smartApp, controllerSuffix)
        {
            _controllerSuffix = controllerSuffix;

        }

        private string GetRestApiMethod(string type)
        {
            string method = "";
            switch (type.ToLower()) {
                case "datalist":
                case "dataget":
                    method = "get";
                    break;
                case "datacreate":
                    method = "post";
                    break;
                case "dataupdate":
                    method = "put";
                    break;
                case "datadelete":
                    method = "delete";
                    break;
            }
            return method;
        }

        public override string OutputPath => @"routes\api.php";
    }
}
