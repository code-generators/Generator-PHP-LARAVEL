# PHP-Laravel Backend Generator

## Technologies & Dependencies

### Dependencies

- php: 7.1.3
- fideloper/proxy: 4.0
- laracasts/flash: 3.0
- laravel/framework: 5.6.*
- laravel/tinker: 1.0
- laravelcollective/html: 5.6
		
### DevDependencies (composer.json)

- filp/whoops: 2.0
- fzaninotto/faker: 1.4
- mockery/mockery: 1.0
- nunomaduro/collision: 2.0
- phpunit/phpunit: 7.0

### DevDependencies (package.json)

- axios: 0.18
- bootstrap: 4.0.0
- popper.js: 1.12
- cross-env: 5.1
- jquery: 3.2
- laravel-mix: 2.0
- lodash: 4.17.4
- vue: 2.5.7

## Generated code's architecture

### Generated PHP-Laravel project's structure

- *General project's structure* :
<img src="https://github.com/Mobioos/Generator-PHP-LARAVEL/wiki/images/PHP_structure.jpg"  alt="General project's structure" style="width:351px;height:440px"/>

- *Configuration* :
<img src="https://github.com/Mobioos/Generator-PHP-LARAVEL/wiki/images/PHP_config.jpg"  alt="Configuration" style="width:343px;height:313px"/>

- *Controllers* :
<img src="https://github.com/Mobioos/Generator-PHP-LARAVEL/wiki/images/PHP_controllers.jpg"  alt="Controllers" style="width:356px;height:553px"/>

- *Providers* :
<img src="https://github.com/Mobioos/Generator-PHP-LARAVEL/wiki/images/PHP_providers.jpg"  alt="Providers" style="width:361px;height:136px"/>

- *Routes* :
<img src="https://github.com/Mobioos/Generator-PHP-LARAVEL/wiki/images/PHP_routes.jpg"  alt="Routes" style="width:351px;height:117px"/>

- *Database* :
<img src="https://github.com/Mobioos/Generator-PHP-LARAVEL/wiki/images/PHP_database.jpg"  alt="Database" style="width:365px;height:353px"/>

- *Models* :
<img src="https://github.com/Mobioos/Generator-PHP-LARAVEL/wiki/images/PHP_models.jpg"  alt="Models" style="width:360px;height:246px"/>

- *ViewModels* :
<img src="https://github.com/Mobioos/Generator-PHP-LARAVEL/wiki/images/PHP_viewModels.jpg"  alt="ViewModels" style="width:371px;height:243px"/>

- *Views* :
<img src="https://github.com/Mobioos/Generator-PHP-LARAVEL/wiki/images/PHP_views.jpg"  alt="Views" style="width:340px;height:468px"/>

### Generated PHP-Laravel project's specifications
- *Project architecture* : MVC
- *Web services* : REST

### Interview's Questions

**PHP framework: questions for database configuration**:

  Select database type: *sqlite* | *mysql* | *pgsql* | *sqlsrv* | *mongo*  
  Enter database host: *127.0.0.1*  
  Enter database port number: *3306*  
  Enter database name: *PHP-Database*  
  Enter database username: *admin*  
  Enter database password: ********  
  
**PHP framework: questions for mail configuration**:

  Select e-mail driver: *smtp* | *sendmail* | *mailgun* | *mandrill* | *ses* | *sparkpost* | *log* | *array*  
  Enter e-mail server url: *smtp.mailtrap.io*  
  Enter e-mail server port number: *2525*  
  Enter e-mail server username: *admin*
  Enter e-mail server password: ********  
  Enter from e-mail id: *no-reply@test.com*
  
**PHP framework: questions for session storage driver configuration**:

  Select session driver: *cookie* | *database* | *memcached* | *redis*  
  Enter session lifetime in minutes: *120*  
  Session expire on close: *expireOnCloseYes* | *expireOnCloseNo*  
  Encrypt session data: *sessionEncryptedYes* | *sessionEncryptedNo*
  
 **PHP framework: questions for session storage configuration**:
 
  (if session driver is *database*)  
    Select session database type: *sqlite* | *mysql* | *pgsql* | *sqlsrv*  
    Enter session table name: *session*
    
  (if session driver is *cookie*)  
    Enter session cookie name: *php-laravel-app*  
    Enter session cookie path: */*  
    Enter session cookie domain name: *app.domain.com*
    
  (if session driver is *memcached*)  
    Enter MemCached Persistent Id: **  
    Enter MemCached host: *127.0.0.1*  
    Enter MemCached port number: *11211*  
    Enter MemCached username: *demouser*  
    Enter MemCached password: ********
  
  (if session driver is *redis*)  
    Enter redis database host: *127.0.0.1*  
    Enter redis database port number: *6379*
    Enter redis database password: ********
    
**PHP framework: questions for model**

  Enter suffix for model: *Model*
  
**PHP framework: questions for Api, web routes and controller**

  Enter suffix for controller: *Controller*
