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
    
    #line 1 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ModelMigrationTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("<?php\r\n\r\nuse Illuminate\\Support\\Facades\\Schema;\r\nuse Illuminate\\Database\\Schema\\B" +
                    "lueprint;\r\nuse Illuminate\\Database\\Migrations\\Migration;\r\n\r\nclass ");
            
            #line 8 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(_entityInfo.Id)));
            
            #line default
            #line hidden
            this.Write("sTable extends Migration\r\n{\r\n    /**\r\n     * Run the migrations.\r\n     *\r\n     * " +
                    "@return void\r\n     */\r\n    public function up()\r\n    {\r\n        Schema::create(\'" +
                    "");
            
            #line 17 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_entityInfo.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write("s\', function (Blueprint $table) {\r\n\r\n");
            
            #line 19 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"

     foreach(var property in _entityInfo.AllProperties())
      {
        if(property.IsKey){

            
            #line default
            #line hidden
            this.Write("           $table->increments(\'");
            
            #line 24 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id)));
            
            #line default
            #line hidden
            this.Write("\')->index();\r\n");
            
            #line 25 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"

        }else{

            
            #line default
            #line hidden
            this.Write("           $table->");
            
            #line 28 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PHPType(property.Type)));
            
            #line default
            #line hidden
            this.Write("(\'");
            
            #line 28 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(property.Id)));
            
            #line default
            #line hidden
            this.Write("\')");
            
            #line 28 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
 if(!property.IsRequired){
            
            #line default
            #line hidden
            this.Write("->nullable()");
            
            #line 28 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 29 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"

        }
      }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 34 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"

   if(_entityInfo.References!=null && _entityInfo.References.Count>0)
   {

            
            #line default
            #line hidden
            this.Write("           //Relations\r\n");
            
            #line 39 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"

      foreach(var reference in _entityInfo.References)
      {
         if(reference.IsCollection)
         {

            
            #line default
            #line hidden
            this.Write("         //  $table->integer(\'");
            
            #line 45 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write("\')->unsinged();\r\n         //  $table->foreign(\'");
            
            #line 46 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write("\')->references(\'");
            
            #line 46 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.ForeignKey.ToLower()));
            
            #line default
            #line hidden
            this.Write("\')->on(\'");
            
            #line 46 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Type)));
            
            #line default
            #line hidden
            this.Write("s\');\r\n\r\n");
            
            #line 48 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"

         }else{

            
            #line default
            #line hidden
            this.Write("        //   $table->integer(\'");
            
            #line 51 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write("\')->unsinged();\r\n         //  $table->foreign(\'");
            
            #line 52 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write("\')->references(\'");
            
            #line 52 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference.ForeignKey.ToLower()));
            
            #line default
            #line hidden
            this.Write("\')->on(\'");
            
            #line 52 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(reference.Type)));
            
            #line default
            #line hidden
            this.Write("s\');\r\n\r\n");
            
            #line 54 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"

         }
      }
   }

            
            #line default
            #line hidden
            this.Write(@"           $table->timestamp('created_at')->nullable();
           $table->timestamp('updated_at')->nullable();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('");
            
            #line 71 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Models\Templates\ModelMigrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_entityInfo.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write("s\');\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}