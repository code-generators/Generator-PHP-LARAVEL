using Mobioos.Foundation.Jade.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.Helpers;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

using System.Linq;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class DeleteTemplate : TemplateBase
    {
        public DeleteTemplate(EntityInfo model, string applicationId) : base(model, applicationId)
        {
        }

        public string GetPrimaryKey()
        {
            var model = (EntityInfo)Model;
            if (model != null && model.AllProperties() != null)
            {
                var property = model.AllProperties().FirstOrDefault<PropertyInfo>(p => p.IsKey == true);
                if (property != null)
                {
                    return TextConverter.CamelCase(property.Id);
                }
            }
            return string.Empty;
        }

        public override string OutputPath => @"resources\views";
    }
}
