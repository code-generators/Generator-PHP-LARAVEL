using Mobioos.Scaffold.TextTemplating;
using Mobioos.Foundation.Jade.Models;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class ComposerJsonTemplate: TemplateBase
    {
        public ComposerJsonTemplate(SmartAppInfo smartApp): base(smartApp, smartApp.Id)
        {

        }

        public override string OutputPath => "composer.json";
    }
}
