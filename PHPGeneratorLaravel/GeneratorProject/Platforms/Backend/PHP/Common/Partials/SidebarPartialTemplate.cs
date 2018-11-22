using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class SidebarPartialTemplate : TemplateBase
    {

        public SidebarPartialTemplate(DataModel datamodel, string applicationId) : base(datamodel, applicationId)
        {

        }

        public override string OutputPath => @"resources\views\layouts\partials\_sidebar.blade.php";
    }
}
