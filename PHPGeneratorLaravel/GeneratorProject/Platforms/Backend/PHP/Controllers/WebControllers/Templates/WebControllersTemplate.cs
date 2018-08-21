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
    using Mobioos.Scaffold.TextTemplating;
    using Mobioos.Scaffold.Generators.Helpers;
    using Mobioos.Foundation.Jade.Models;
    using Mobioos.Foundation.Jade.Extensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class WebControllersTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"

    var entity = (EntityInfo)Model;
    var controllerName = TextConverter.PascalCase(entity.Id) + _controllerSuffix;
    var entityName = TextConverter.PascalCase(entity.Id) + _modelSuffix;
    var keyName = GetPrimaryKey();

            
            #line default
            #line hidden
            this.Write("<?php\r\n\r\nnamespace App\\Http\\Controllers\\WebControllers;\r\n\r\nuse Illuminate\\Http\\Re" +
                    "quest;\r\nuse App\\Http\\Controllers\\Controller;\r\n\r\nuse App\\Models\\");
            
            #line 15 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nclass ");
            
            #line 17 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write(" extends Controller\r\n{\r\n\r\n     /**\r\n     * Display a listing of the resource.\r\n  " +
                    "   *\r\n     * @return \\Illuminate\\Http\\Response\r\n     */\r\n    public function ind" +
                    "ex()\r\n    {\r\n        $items = ");
            
            #line 27 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("::all();\r\n        return view(\"");
            
            #line 28 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(entity.Id)));
            
            #line default
            #line hidden
            this.Write(".index\")->withItems($items);\r\n    }\r\n\r\n    /**\r\n     * Show the form for creating" +
                    " a new resource.\r\n     *\r\n     * @return \\Illuminate\\Http\\Response\r\n     */\r\n   " +
                    " public function create()\r\n    {\r\n         return view(\"");
            
            #line 38 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(entity.Id)));
            
            #line default
            #line hidden
            this.Write(@".create"");
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $inputData = $request->input(); 

        $newItem = new ");
            
            #line 51 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 52 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"

    foreach(PropertyInfo property in entity.AllProperties())
    {
        if(!property.IsKey)
        {
            string propertyName = TextConverter.CamelCase(property.Id);

            
            #line default
            #line hidden
            this.Write("        $newItem->");
            
            #line 59 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyName));
            
            #line default
            #line hidden
            this.Write(" = $inputData[\"");
            
            #line 59 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyName));
            
            #line default
            #line hidden
            this.Write("\"];\r\n");
            
            #line 60 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("        $newItem->save();\r\n\r\n        flash(\'");
            
            #line 66 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Helper.WordSeperator(TextConverter.PascalCase(entity.Id))));
            
            #line default
            #line hidden
            this.Write(" is created!\')->success();\r\n\r\n        return redirect()->action(\'WebControllers\\");
            
            #line 68 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("@index\');\r\n    }\r\n\r\n    /**\r\n     * Display the specified resource.\r\n     *\r\n    " +
                    " * @param  int  $id\r\n     * @return \\Illuminate\\Http\\Response\r\n     */\r\n    publ" +
                    "ic function show($");
            
            #line 77 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write(")\r\n    {\r\n        $item = ");
            
            #line 79 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("::where(\'");
            
            #line 79 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write("\', $");
            
            #line 79 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write(")->firstOrFail();\r\n\r\n        if(!empty($_REQUEST[\'showdelete\']))\r\n        {\r\n    " +
                    "        return view(\"");
            
            #line 83 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(entity.Id)));
            
            #line default
            #line hidden
            this.Write(".delete\")->withItem($item);\r\n        }\r\n\r\n        return view(\"");
            
            #line 86 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(entity.Id)));
            
            #line default
            #line hidden
            this.Write(".show\")->withItem($item);\r\n    }\r\n\r\n    /**\r\n     * Show the form for editing the" +
                    " specified resource.\r\n     *\r\n     * @param  int  $id\r\n     * @return \\Illuminat" +
                    "e\\Http\\Response\r\n     */\r\n    public function edit($");
            
            #line 95 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write(")\r\n    {\r\n        $item = ");
            
            #line 97 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("::where(\'");
            
            #line 97 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write("\', $");
            
            #line 97 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write(")->firstOrFail();\r\n\r\n        return view(\"");
            
            #line 99 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(entity.Id)));
            
            #line default
            #line hidden
            this.Write(@".edit"")->withItem($item);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $");
            
            #line 109 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write(")\r\n    {\r\n        $dataToUpdate = $request->input();\r\n\r\n        $item = ");
            
            #line 113 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("::where(\'");
            
            #line 113 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write("\', $");
            
            #line 113 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write(")->firstOrFail();\r\n\r\n");
            
            #line 115 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"

    foreach(PropertyInfo property in entity.AllProperties())
    {
        if(!property.IsKey)
        {
            string propertyName = TextConverter.CamelCase(property.Id);

            
            #line default
            #line hidden
            this.Write("        $item->");
            
            #line 122 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyName));
            
            #line default
            #line hidden
            this.Write(" = $dataToUpdate[\"");
            
            #line 122 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyName));
            
            #line default
            #line hidden
            this.Write("\"];\r\n");
            
            #line 123 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("\r\n        $item->save();\r\n\r\n        flash(\'");
            
            #line 130 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Helper.WordSeperator(TextConverter.PascalCase(entity.Id))));
            
            #line default
            #line hidden
            this.Write(" is updated!\')->success();\r\n\r\n        return redirect()->action(\'WebControllers\\");
            
            #line 132 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("@index\');\r\n    }\r\n\r\n    /**\r\n     * Remove the specified resource from storage.\r\n" +
                    "     *\r\n     * @param  int  $id\r\n     * @return \\Illuminate\\Http\\Response\r\n     " +
                    "*/\r\n    public function destroy(Request $request, $");
            
            #line 141 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write(")\r\n    {\r\n        $item = ");
            
            #line 143 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("::where(\'");
            
            #line 143 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write("\', $");
            
            #line 143 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyName));
            
            #line default
            #line hidden
            this.Write(")->firstOrFail();\r\n        $item->delete();\r\n\r\n        flash(\'");
            
            #line 146 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Helper.WordSeperator(TextConverter.PascalCase(entity.Id))));
            
            #line default
            #line hidden
            this.Write(" is deleted!\')->success();\r\n\r\n        return redirect()->action(\'WebControllers\\");
            
            #line 148 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Controllers\WebControllers\Templates\WebControllersTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("@index\');\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
