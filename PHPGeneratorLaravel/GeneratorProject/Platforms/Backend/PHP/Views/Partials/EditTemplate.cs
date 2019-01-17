using Mobioos.Foundation.Jade.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.Helpers;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

using System.Linq;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class EditTemplate : TemplateBase
    {
        public EditTemplate(EntityInfo model, string applicationId) : base(model, applicationId)
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

        public string PHPType(string type)
        {
            string returnType;
            switch (type)
            {
                case "number":
                    returnType = "number";
                    break;
                case "date":
                    returnType = "date";
                    break;
                case "string":
                    returnType = "text";
                    break;
                default:
                    returnType = type;
                    break;
            }
            return returnType;
        }

        public override string OutputPath =>  @"resources\views";
    }
}
