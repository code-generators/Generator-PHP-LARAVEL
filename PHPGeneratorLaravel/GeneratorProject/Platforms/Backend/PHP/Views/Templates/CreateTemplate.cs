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
    
    #line 1 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class CreateTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"

    var _entityInfo = (EntityInfo)Model;

            
            #line default
            #line hidden
            this.Write("@extends(\'layouts.master\')\r\n\r\n@section(\'content\')\r\n\r\n<div class=\"container-fluid " +
                    "form-horizontal\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"card\">\r\n    " +
                    "        <div class=\"card-title\">\r\n               <h4>");
            
            #line 13 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Helper.WordSeperator(TextConverter.PascalCase(_entityInfo.Id))));
            
            #line default
            #line hidden
            this.Write(" - Create Form</h4>\r\n           </div>\r\n           <div class=\"card-body\">\r\n     " +
                    "         {!! Form::open([\'route\' => \'");
            
            #line 16 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_entityInfo.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write(".store\', \'class\' => \'form\',\'method\' => \'POST\']) !!}\r\n\r\n");
            
            #line 18 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"

     foreach(var property in _entityInfo.AllProperties())
      {
         if(!property.IsKey)
          {

            
            #line default
            #line hidden
            this.Write("            <div class=\"form-group\">\r\n               {!! Form::label(\'");
            
            #line 25 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id)));
            
            #line default
            #line hidden
            this.Write("\', \'");
            
            #line 25 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Helper.WordSeperator(TextConverter.PascalCase(property.Id))));
            
            #line default
            #line hidden
            this.Write("\') !!}\r\n");
            
            #line 26 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
        
        if(property.IsCollection){

            
            #line default
            #line hidden
            this.Write("               {!! Form::");
            
            #line 29 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PHPType(property.Type)));
            
            #line default
            #line hidden
            this.Write("(\'");
            
            #line 29 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id)));
            
            #line default
            #line hidden
            this.Write("[]\', null, [\'class\' => \'form-control\']) !!}\r\n");
            
            #line 30 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
      
        }else{

            
            #line default
            #line hidden
            this.Write("               {!! Form::");
            
            #line 33 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PHPType(property.Type)));
            
            #line default
            #line hidden
            this.Write("(\'");
            
            #line 33 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id)));
            
            #line default
            #line hidden
            this.Write("\', null, [\'class\' => \'form-control\']) !!}\r\n");
            
            #line 34 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("           </div>\r\n");
            
            #line 38 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Views\Templates\CreateTemplate.tt"

          }
      }

            
            #line default
            #line hidden
            this.Write("\r\n            {!! Form::submit(\'Save\', [\'class\' => \'btn btn-info\']) !!}\r\n\r\n      " +
                    "      {!! Form::close() !!}\r\n           </div>\r\n        </div>\r\n    </div>\r\n</di" +
                    "v>\r\n\r\n@endsection \r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
