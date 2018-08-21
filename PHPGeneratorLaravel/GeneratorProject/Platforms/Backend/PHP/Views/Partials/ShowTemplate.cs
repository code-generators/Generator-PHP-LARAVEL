using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.TextTemplating;
using Mobioos.Foundation.Jade.Extensions;
using Mobioos.Scaffold.Generators.Helpers;

using System.Linq;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class ShowTemplate : TemplateBase
    {
        public ShowTemplate(EntityInfo model, string applicationId) : base(model, applicationId)
        {
        }

        public string GetPrimaryKey()
        {
            var model = (EntityInfo)Model;
            var property = model.AllProperties().Where(p => p.IsKey).FirstOrDefault<PropertyInfo>();
            return TextConverter.CamelCase(property.Id);
        }

        public override string OutputPath => @"resources\views";
    }
}
