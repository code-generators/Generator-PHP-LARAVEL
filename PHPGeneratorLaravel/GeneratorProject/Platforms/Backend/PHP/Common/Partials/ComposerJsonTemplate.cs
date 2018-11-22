using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

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
