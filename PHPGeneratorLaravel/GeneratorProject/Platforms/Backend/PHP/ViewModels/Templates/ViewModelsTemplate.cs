﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace GeneratorProject.Platforms.Backend.PHP
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Mobioos.Scaffold.BaseGenerators.TextTemplating;
    using Mobioos.Scaffold.BaseGenerators.Helpers;
    using Mobioos.Foundation.Jade.Models;
    using Mobioos.Foundation.Jade.Extensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ViewModelsTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("<?php\r\n\r\nnamespace App\\ViewModels;\r\n\r\nuse Illuminate\\Database\\Eloquent\\Model;\r\n\r\n" +
                    "class ");
            
            #line 8 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_dataModel.Id)));
            
            #line default
            #line hidden
            
            #line 8 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_viewModelSuffix));
            
            #line default
            #line hidden
            this.Write(" extends Model{\r\n");
            
            #line 9 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

        if (_dataModel.Properties != null && _dataModel.Properties.Count > 0)
        {

            
            #line default
            #line hidden
            this.Write("\r\n     //Property.\r\n");
            
            #line 15 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

            foreach (PropertyInfo property in _dataModel.Properties.AsEnumerable())
            {
                if (property.Id != null && property.Type != null && property.IsCollection)
                {

            
            #line default
            #line hidden
            this.Write("      private $");
            
            #line 21 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 22 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                }
                else if(property.Id != null && property.Type != null ){

            
            #line default
            #line hidden
            this.Write("      private $");
            
            #line 26 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 27 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 33 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

        if (_dataModel.References != null && _dataModel.References.Count > 0)
        {

            
            #line default
            #line hidden
            this.Write("     //Reference\r\n");
            
            #line 38 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

            foreach (ReferenceInfo reference in _dataModel.References.AsEnumerable())
            {
                if (reference.Id != null && reference.Target != null && reference.IsCollection)
                {

            
            #line default
            #line hidden
            this.Write("      private $");
            
            #line 44 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Id)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 45 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                }
                 else if (reference.Id != null && reference.Type != null)
                {

            
            #line default
            #line hidden
            this.Write("      private $");
            
            #line 50 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Id)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 51 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("\r\n      public function __construct(\r\n");
            
            #line 58 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

     if (_constructorParametersObj.AsEnumerable() != null && _constructorParametersObj.AsEnumerable().Count() > 0)
            {
                int count = _constructorParametersObj.AsEnumerable().Count() - 1;
                int counter = 0;
                Dictionary<string, int> countConstructor = new Dictionary<string, int>();
                foreach (PropertyInfo property in _constructorParametersObj.AsEnumerable())
                {
                    if (property.Id != null && property.Type != null)
                    {
                        string propertyIsModel = IsModel(property);
                        if (!countConstructor.ContainsKey(property.Id))
                            countConstructor.Add(property.Id, 1);
                        else
                            countConstructor[property.Id] = countConstructor[property.Id] + 1;
                        string type =  property.Type;
                        if (!propertyIsModel.Equals(""))
                        {
                            type = TextConverter.PascalCase(type);
                        }
                        if (property.IsCollection && counter == count)
                        {

            
            #line default
            #line hidden
            this.Write("        $");
            
            #line 81 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id) + countConstructor[property.Id]));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 82 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                        }
                        else if (counter == count)
                        {

            
            #line default
            #line hidden
            this.Write("        $");
            
            #line 87 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id) + countConstructor[property.Id]));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 88 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                        }
                        else if (property.IsCollection)
                        {

            
            #line default
            #line hidden
            this.Write("        $");
            
            #line 93 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id) + countConstructor[property.Id]));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 94 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                        }
                        else
                        {

            
            #line default
            #line hidden
            this.Write("        $");
            
            #line 99 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id) + countConstructor[property.Id]));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 100 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                        }
                    }
                    counter++;
                }
            }

            
            #line default
            #line hidden
            this.Write("      ) {\r\n\r\n");
            
            #line 109 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

            Dictionary<string, int> countObj = new Dictionary<string, int>();
            if (_dataModel.Properties.AsEnumerable() != null)
            {
                foreach (PropertyInfo property in _dataModel.Properties.AsEnumerable())
                {
                    if (property.Id != null)
                    {
                        if (!countObj.ContainsKey(property.Id))
                            countObj.Add(property.Id, 1);
                        else
                            countObj[property.Id] = countObj[property.Id] + 1;

            
            #line default
            #line hidden
            this.Write("        $this->");
            
            #line 122 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id)));
            
            #line default
            #line hidden
            this.Write(" = $");
            
            #line 122 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id) + countObj[property.Id]));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 123 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                    }
                }
            }

            if (_dataModel.References.AsEnumerable() != null)
            {
                foreach (ReferenceInfo reference in _dataModel.References.AsEnumerable())
                {
                    if (reference.Id != null)
                    {
                        if (!countObj.ContainsKey(reference.Id))
                            countObj.Add(reference.Id, 1);
                        else
                            countObj[reference.Id] = countObj[reference.Id] + 1;

            
            #line default
            #line hidden
            this.Write("        $this->");
            
            #line 139 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Id)));
            
            #line default
            #line hidden
            this.Write(" = $");
            
            #line 139 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Id) + countObj[reference.Id]));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 140 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\ViewModels\Templates\ViewModelsTemplate.tt"

                    }
                }
            }

            
            #line default
            #line hidden
            this.Write("      }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}