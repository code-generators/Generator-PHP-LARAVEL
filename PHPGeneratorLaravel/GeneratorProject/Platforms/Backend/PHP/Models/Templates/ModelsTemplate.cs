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
    
    #line 1 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ModelsTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("<?php\r\nnamespace App\\Models;\r\n\r\n");
            
            #line 5 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"

    if(_entityInfo.BaseEntity == null)
    {

            
            #line default
            #line hidden
            this.Write("use Illuminate\\Database\\Eloquent\\Model;\r\n\r\nclass ");
            
            #line 11 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_entityInfo.Id));
            
            #line default
            #line hidden
            
            #line 11 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelSuffix));
            
            #line default
            #line hidden
            this.Write(" extends Model\r\n");
            
            #line 12 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"

    }
    else
    {

            
            #line default
            #line hidden
            this.Write("class ");
            
            #line 17 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_entityInfo.Id));
            
            #line default
            #line hidden
            
            #line 17 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelSuffix));
            
            #line default
            #line hidden
            this.Write(" extends ");
            
            #line 17 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_entityInfo.Extends)));
            
            #line default
            #line hidden
            
            #line 17 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelSuffix));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 18 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("{\r\n    /**\r\n     * The table associated with the model.\r\n     */\r\n     protected " +
                    "$table = \'");
            
            #line 25 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_entityInfo.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write("s\';\r\n\r\n");
            
            #line 27 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"

   if(_entityInfo.References!=null && _entityInfo.References.Count>0)
   {
     foreach(var reference in _entityInfo.References)
      {
         if(reference.IsCollection)
         {

            
            #line default
            #line hidden
            this.Write("     public function ");
            
            #line 35 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Id)));
            
            #line default
            #line hidden
            this.Write("()\r\n     {\r\n         return $this->hasMany(\'");
            
            #line 37 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelPath));
            
            #line default
            #line hidden
            
            #line 37 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(reference.Type)));
            
            #line default
            #line hidden
            
            #line 37 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelSuffix));
            
            #line default
            #line hidden
            this.Write("\');\r\n     }\r\n\r\n");
            
            #line 40 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"

         }else{

            
            #line default
            #line hidden
            this.Write("     public function ");
            
            #line 43 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Id)));
            
            #line default
            #line hidden
            this.Write("()\r\n     {\r\n         return $this->belongsTo(\'");
            
            #line 45 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelPath));
            
            #line default
            #line hidden
            
            #line 45 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(reference.Id)));
            
            #line default
            #line hidden
            
            #line 45 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_modelSuffix));
            
            #line default
            #line hidden
            this.Write("\');\r\n     }\r\n\r\n");
            
            #line 48 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelsTemplate.tt"

         }
      }
   }

            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}