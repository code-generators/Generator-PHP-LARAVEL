using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;
using System;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class ModelMigrationTemplate : TemplateBase
    {
        private string dateString { get; set; }
        private EntityInfo _entityInfo { get; set; }
        public ModelMigrationTemplate(EntityInfo entityInfo) : base(entityInfo)
        {
            _entityInfo = entityInfo;
            dateString = string.Format("{0}_{1}_{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        public string PHPType(string type)
        {
            string returnType = string.Empty;
            switch (type)
            {
                case "number":
                    returnType = "integer";
                    break;
                case "date":
                    returnType = "dateTime";
                    break;
                case "boolean":
                    returnType = "boolean";
                    break;
                default:
                    returnType = "string";
                    break;
            }
            return returnType;
        }
 
        public override string OutputPath => string.Format(@"database\migrations\{0}_create_{1}s_table.php",dateString, _entityInfo.Id.ToLower());
    }
}
