<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>@yield('title')</title>

    <!-- Bootstrap core CSS -->
    <link href="/frontend/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="/frontend/css/modern-business.css" rel="stylesheet">

</head>

<body>

<!-- Navigation -->
<nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top">
    <div class="container">

        <a class="navbar-brand" href="{{route('home.Index')}}"> <img class="img-fluid rounded" src="/images/logo.png" width="140"></a>
{{--        <a class="navbar-brand" href="{{route('home.Index')}}">Düzce Üniversitesi</a>--}}
        <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarResponsive">
            <ul class="navbar-nav ml-auto">
                <li class="nav-item">
                    <a class="nav-link" href="{{route('home.Index')}}">Anasayfa</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="{{route('about.Detail')}}">Hakkında</a>
                </li>


                <li class="nav-item">
                    <a class="nav-link" href="{{route('student.Detail')}}">Öğrenci</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="{{route('contact.Detail')}}">İletişim</a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownPortfolio" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Akademik
                    </a>
                    <div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdownPortfolio">
                        <a class="dropdown-item" href="{{route('faculty.Detail')}}">Fakülteler</a>
                        <a class="dropdown-item" href="#">Enstitüler</a>
                        <a class="dropdown-item" href="#">Yüksekokullar</a>
                        <a class="dropdown-item" href="#">Meslek Yüksekokulları</a>
                        <a class="dropdown-item" href="#">Kurullar</a>
                    </div>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="{{route('blog.Index')}}">Duyurular</a>
                </li>


            </ul>
        </div>
    </div>
</nav>

@yield('content')

<!-- Footer -->
<footer class="py-5 bg-dark">
    <div class="container">
        <p class="m-0 text-center text-white">Copyright &copy; ET Yazılım 2021</p>
    </div>
    <!-- /.container -->
</footer>

<!-- Bootstrap core JavaScript -->
<script src="/frontend/vendor/jquery/jquery.min.js"></script>
<script src="/frontend/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
<script src="/js/custom.js"></script>
</body>

</html>
