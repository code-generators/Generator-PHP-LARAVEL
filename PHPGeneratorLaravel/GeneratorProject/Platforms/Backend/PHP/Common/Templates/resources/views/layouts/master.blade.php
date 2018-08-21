<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- CSRF Token -->
    <meta name="csrf-token" content="{{ csrf_token() }}">

    <title>{{ config('app.name', 'Laravel') }}</title>

    <!-- Scripts -->
    <script src="{{ asset('js/app.js') }}" defer></script>

    <!-- Fonts -->
    <link rel="dns-prefetch" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css?family=Raleway:300,400,600" rel="stylesheet" type="text/css">

    <!-- Styles -->
    <link href="{{ asset('css/app.css') }}" rel="stylesheet">
        <link href="{{ asset('css/theme/global.css') }}" rel="stylesheet">
    <link href="{{ asset('css/theme/theme-light.css') }}" rel="stylesheet">
</head>
  <body class="fix-header fix-sidebar">
      <div class="main-wrapper">
      <div class="header">
        <nav class="header-navbar">
        <div class="header-brand float-left d-flex">
            <div class="header-navbar-logo align-self-center">
                <div class="logo-image"></div>
            </div>
            <div class="header-divider align-self-center"></div>
            <a class="navbar-brand align-self-center" href="/">{{ config('app.name', 'Laravel') }}</a>
        </div>
        
        <div class="navbar-wrapper float-right" id="navbarSupportedContent">
             @if( auth()->check() )
            <div class="dropdown login-user show">
                <a class="btn btn-secondary dropdown-toggle login-user-details transparent-background-dropdown" href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    <div class="user-profile">
                        <div class="no-image" title="{{auth()->user()->name}}">{{ substr(auth()->user()->name, 0, 1) }}</div>
                    </div>
                </a>
                <div class="dropdown-menu dropdown-menu-right" aria-labelledby="dropdownMenuLink">
                    <span class="dropdown-item-text">{{ auth()->user()->name }}<br/>({{ auth()->user()->email }})</span>
                    <a class="dropdown-item" href="{{ route('logout') }}" onclick="event.preventDefault(); document.getElementById('logout-form').submit();">Logout</a>
                    <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
                        @csrf
                    </form>
                </div>
            </div>
            @endif
        </div>
        </nav>
    </div>

       @section('sidebar')
            @include('layouts.partials._sidebar')
       @show
       <div class="page-wrapper">
            @include('flash::message')
            
            @if ($errors->any())
            <div class="alert alert-danger">
                <ul>
            @foreach ($errors->all() as $error)
                    <li>{{ $error }}</li>
            @endforeach
                </ul>
            </div>
            @endif

            @yield('content')
       </div>   
    </div>   
  </body>
</html>
