using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.BaseGenerators.TextTemplating;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorProject.Platforms.Backend.PHP
{
    public partial class ViewModelsTemplate: TemplateBase
    {
        private EntityInfo _dataModel { get; set; }
        private string _viewModelSuffix { get; set; }
        private string _modelSuffix { get; set; }
        private List<PropertyInfo> _constructorParametersObj { get; set; }

        public ViewModelsTemplate(EntityInfo dataModel, string viewModelSuffix, string modelSuffix) : base(dataModel)
        {
            _dataModel = dataModel;
            _viewModelSuffix = viewModelSuffix;
            _modelSuffix = modelSuffix;
            _constructorParametersObj = getReferences(dataModel);
        }

        public List<PropertyInfo> getReferences(EntityInfo entity)
        {
            List<PropertyInfo> result = new List<PropertyInfo>();
            if (entity != null)
            {
                if (entity.BaseEntity != null)
                    foreach (PropertyInfo property in getReferences(entity.BaseEntity).AsEnumerable())
                        result.Add(property);

                if (entity.Properties.AsEnumerable() != null)
                    foreach (PropertyInfo property in entity.Properties.AsEnumerable())
                        result.Add(property);

                if (entity.References.AsEnumerable() != null)
                    foreach (ReferenceInfo reference in entity.References.AsEnumerable())
                        result.Add(reference);
            }
            return result;
        }

        /// Check if the type given is a model or a primitive type. Return a string.
      
         public string IsModel(PropertyInfo property)
        {
            string result = "";
            switch (property.Type.ToLower())
            {
                case "date": break;
                case "string": break;
                case "number": break;
                case "boolean": break;
                default: result = "Model"; break;
            }
            if (property.Target != null && property.Target.IsEnum)
                result = "Enum";
            return result;
        }

        public override string OutputPath => @"app\\ViewModels\\";
    }
}
