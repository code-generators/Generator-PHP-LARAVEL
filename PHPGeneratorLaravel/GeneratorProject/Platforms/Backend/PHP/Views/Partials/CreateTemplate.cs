using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class CreateTemplate : TemplateBase
    {
        private EntityInfo _model { get; set; }
        public CreateTemplate(EntityInfo model, string applicationId) : base(model, applicationId)
        {
            _model = model;

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

        public override string OutputPath => @"resources\views";
    }
}