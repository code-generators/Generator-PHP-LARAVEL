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
    
    #line 1 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Routes\Templates\WebRoutesTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class WebRoutesTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Routes\Templates\WebRoutesTemplate.tt"

    var smartApp = (SmartAppInfo)Model;

            
            #line default
            #line hidden
            this.Write(@"<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the ""web"" middleware group. Now create something great!
|
*/

    Route::get('/', function () {
        return view('/public/home');
    });

    Route::get('/about', function () {
        return view('/public/about');
    });

    Route::get('/contactus', function () {
        return view('/public/contactus');
    });

    Auth::routes();

    Route::group(['middleware'=>'auth'], function(){
         Route::get('/home', 'WebControllers\HomeController@index');
");
            
            #line 34 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Routes\Templates\WebRoutesTemplate.tt"

    if(smartApp != null && smartApp.DataModel != null && smartApp.DataModel.Entities != null && smartApp.DataModel.Entities.Count > 0)
    {
        foreach(var entity in smartApp.DataModel.Entities)
        {

            
            #line default
            #line hidden
            this.Write("        Route::resource(\'");
            
            #line 40 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Routes\Templates\WebRoutesTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Id.ToLower()));
            
            #line default
            #line hidden
            this.Write("\', \'WebControllers\\");
            
            #line 40 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Routes\Templates\WebRoutesTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(entity.Id)));
            
            #line default
            #line hidden
            
            #line 40 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Routes\Templates\WebRoutesTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_controllerSuffix));
            
            #line default
            #line hidden
            this.Write("\');\r\n");
            
            #line 41 "D:\Working\Mobioos\Generators new changes\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Routes\Templates\WebRoutesTemplate.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("    });\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
