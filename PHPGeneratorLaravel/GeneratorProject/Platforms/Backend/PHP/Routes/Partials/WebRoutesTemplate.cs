using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class WebRoutesTemplate:TemplateBase
    {        
        private string _controllerSuffix { get; set; }
        
        public WebRoutesTemplate(SmartAppInfo smartApp, string controllerSuffix) : base(smartApp, controllerSuffix)
        {     
            _controllerSuffix = controllerSuffix;
           
        }
        public override string OutputPath => @"routes\web.php";
    }
}
