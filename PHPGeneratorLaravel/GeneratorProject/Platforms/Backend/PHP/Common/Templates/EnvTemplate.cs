// ------------------------------------------------------------------------------
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
    
    #line 1 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class EnvTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("APP_NAME=");
            
            #line 2 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(ApplicationId)));
            
            #line default
            #line hidden
            this.Write("\r\nAPP_ENV=local\r\nAPP_KEY=base64:");
            
            #line 4 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_appKey));
            
            #line default
            #line hidden
            this.Write("\r\nAPP_DEBUG=true\r\nAPP_URL=http://localhost\r\n\r\nLOG_CHANNEL=stack\r\n\r\nDB_CONNECTION=" +
                    "");
            
            #line 10 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_databaseConfigInfo.Type));
            
            #line default
            #line hidden
            this.Write("\r\nDB_HOST=");
            
            #line 11 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_databaseConfigInfo.Host));
            
            #line default
            #line hidden
            this.Write("\r\nDB_PORT=");
            
            #line 12 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_databaseConfigInfo.Port));
            
            #line default
            #line hidden
            this.Write("\r\nDB_DATABASE=");
            
            #line 13 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_databaseConfigInfo.Name));
            
            #line default
            #line hidden
            this.Write("\r\nDB_USERNAME=");
            
            #line 14 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_databaseConfigInfo.Username));
            
            #line default
            #line hidden
            this.Write("\r\nDB_PASSWORD=");
            
            #line 15 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_databaseConfigInfo.Password));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nBROADCAST_DRIVER=log\r\nCACHE_DRIVER=file\r\nSESSION_DRIVER=");
            
            #line 19 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_sessionConfigInfo.Driver));
            
            #line default
            #line hidden
            this.Write("\r\nSESSION_LIFETIME=");
            
            #line 20 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_sessionConfigInfo.Lifttime));
            
            #line default
            #line hidden
            this.Write("\r\nSESSION_EXPIRE_ON_CLOSE=");
            
            #line 21 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_sessionConfigInfo.ExpireOnClose));
            
            #line default
            #line hidden
            this.Write("\r\nSESSION_ENCRYPT=");
            
            #line 22 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_sessionConfigInfo.Encrypt));
            
            #line default
            #line hidden
            this.Write("\r\nSESSION_TABLE = \'");
            
            #line 23 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
__sessionConfigInfo.Table
            
            #line default
            #line hidden
            this.Write("\'\r\nQUEUE_DRIVER=sync\r\n\r\nREDIS_HOST=");
            
            #line 26 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_redisConfigInfo.Host));
            
            #line default
            #line hidden
            this.Write("\r\nREDIS_PASSWORD=");
            
            #line 27 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_redisConfigInfo.Password));
            
            #line default
            #line hidden
            this.Write("\r\nREDIS_PORT=");
            
            #line 28 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_redisConfigInfo.Port));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nSESSION_COOKIE=");
            
            #line 30 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_cockieConfigInfo.Name));
            
            #line default
            #line hidden
            this.Write("\r\nSESSION_DOMAIN=");
            
            #line 31 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_cockieConfigInfo.Domain));
            
            #line default
            #line hidden
            this.Write("\r\nSESSION_COOKIE_PATH=");
            
            #line 32 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_cockieConfigInfo.Path));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nMAIL_DRIVER=");
            
            #line 34 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_mailConfigInfo.Driver));
            
            #line default
            #line hidden
            this.Write("\r\nMAIL_HOST=");
            
            #line 35 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_mailConfigInfo.Host));
            
            #line default
            #line hidden
            this.Write("\r\nMAIL_PORT=");
            
            #line 36 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_mailConfigInfo.Port));
            
            #line default
            #line hidden
            this.Write("\r\nMAIL_USERNAME=");
            
            #line 37 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_mailConfigInfo.Username));
            
            #line default
            #line hidden
            this.Write("\r\nMAIL_PASSWORD=");
            
            #line 38 "D:\01 Working\01 RedFabriq\01 working\generators\php\generator\PHP-LARAVEL\PHPGeneratorLaravel\GeneratorProject\Platforms\Backend\PHP\Common\Templates\EnvTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_mailConfigInfo.Password));
            
            #line default
            #line hidden
            this.Write("\r\nMAIL_ENCRYPTION=null\r\n\r\nPUSHER_APP_ID=\r\nPUSHER_APP_KEY=\r\nPUSHER_APP_SECRET=\r\nPU" +
                    "SHER_APP_CLUSTER=mt1\r\n\r\nMIX_PUSHER_APP_KEY=\"${PUSHER_APP_KEY}\"\r\nMIX_PUSHER_APP_C" +
                    "LUSTER=\"${PUSHER_APP_CLUSTER}\"\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
