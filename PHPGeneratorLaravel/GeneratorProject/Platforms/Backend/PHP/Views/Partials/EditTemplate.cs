using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Jade.Extensions;
using Mobioos.Scaffold.TextTemplating;
using Mobioos.Scaffold.Generators.Helpers;

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
            var property = model.AllProperties().Where(p => p.IsKey).FirstOrDefault<PropertyInfo>();
            return TextConverter.CamelCase(property.Id);
        }

        public string PHPType(string type)
        {
            string returnType = type;
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
