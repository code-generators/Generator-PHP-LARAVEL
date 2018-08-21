using Mobioos.Scaffold.TextTemplating;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class ConfigAppTemplate: TemplateBase
    {
        public ConfigAppTemplate(string applicationId) : base(null, applicationId)
        {

        }

        public override string OutputPath => @"config\app.php";
    }
}
