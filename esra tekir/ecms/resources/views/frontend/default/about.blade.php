@extends('frontend.layout')
@section('title',"Anasayfa Başlığı")
@section('content')
    <!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

{{--    <title>Modern Business - Start Bootstrap Template</title>--}}

    <!-- Bootstrap core CSS -->
    <link href="/frontend/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="/frontend/css/modern-business.css" rel="stylesheet">

</head>

<body>

<!-- Navigation -->

<!-- Page Content -->
<div class="container">

    <!-- Page Heading/Breadcrumbs -->
    <h1 class="mt-4 mb-3">Üniversitemiz Hakkında
    </h1>


    <!-- Intro Content -->
    <div class="row">
        <div class="col-lg-6">
            <img class="img-fluid rounded mb-4" src="/images/logodu.png" alt="">
        </div>
        <div class="col-lg-6">
            <h2>Kuruluş</h2>
            <p>17 Mart 2006 tarih ve 26111 sayılı Resmi Gazete'de yayınlanan 5467 sayılı yasa ile Abant İzzet Baysal Üniversitesi’nden ayrılarak kuruluşu gerçekleştirilen Düzce Üniversitesi, değer üretme felsefesi ile eğitim-öğretim faaliyetlerine başlamıştır.</p>
            <p>İlk kurulduğu yıllarda 3 fakültesi ve 5700 öğrencisi olan Düzce Üniversitesi; bugün 30 bini aşkın öğrencisi, 12 Fakültesi, 4 Enstitüsü, 2 Yüksekokulu, 10 Meslek Yüksekokulu, 30’dan fazla araştırma merkezi, Teknopark’ı, Araştırma Hastanesi ile saygın ve tercih edilen bir yükseköğretim kurumu olarak dikkat çekmektedir.</p>
            <p>Kurulduğu 17 Mart 2006 tarihinden günümüze değer üretme felsefesi ışığında; bilimsel araştırmaları, katma değerli çalışmaları, bölgesel kalkınmaya katkıları ile bir fidandan bir çınara dönüşen Düzce Üniversitesi, girişimci, yenilikçi ve şeffaf yönetim kültürü ile faaliyetlerini başarıyla sürdürmektedir. </p>
        </div>
    </div>
    <!-- /.row -->

    <!-- Team Members -->
    <h2>Yönetim</h2>

    <div class="row">
        <div class="col-lg-4 mb-4">
            <div class="card h-100 text-center">
                <img class="card-img-top" src="/images/rektör.jpg" alt="">
                <div class="card-body">
                    <h4 class="card-title">Prof. Dr. Nigar DEMİRCAN ÇAKAR</h4>
                    <h6 class="card-subtitle mb-2 text-muted">Rektör</h6>
{{--                    <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus aut mollitia eum ipsum fugiat odio officiis odit.</p>--}}
                </div>
{{--                <div class="card-footer">--}}
{{--                    <a href="#">name@example.com</a>--}}
{{--                </div>--}}
            </div>
        </div>
        <div class="col-lg-4 mb-4">
            <div class="card h-100 text-center">
                <img class="card-img-top" src="/images/r_yardimcisi1.jpg" alt="">
                <div class="card-body">
                    <h4 class="card-title">Prof. Dr. İlhan GENÇ</h4>
                    <h6 class="card-subtitle mb-2 text-muted">Rektör Yardımcısı</h6>
{{--                    <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus aut mollitia eum ipsum fugiat odio officiis odit.</p>--}}
                </div>
{{--                <div class="card-footer">--}}
{{--                    <a href="#">name@example.com</a>--}}
{{--                </div>--}}
            </div>
        </div>
        <div class="col-lg-4 mb-4">
            <div class="card h-100 text-center">
                <img class="card-img-top" src="/images/r_yardimcisi2.jpg" alt="">
                <div class="card-body">
                    <h4 class="card-title">Prof. Dr. İdris ŞAHİN</h4>
                    <h6 class="card-subtitle mb-2 text-muted">Rektör Yardımcısı</h6>
{{--                    <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus aut mollitia eum ipsum fugiat odio officiis odit.</p>--}}
                </div>
{{--                <div class="card-footer">--}}
{{--                    <a href="#">name@example.com</a>--}}
{{--                </div>--}}
            </div>
        </div>
    </div>
    <!-- /.row -->

    <!-- Our Customers -->

    <!-- /.row -->

</div>
<!-- /.container -->

<!-- Footer -->

<!-- Bootstrap core JavaScript -->
<script src="/frontend/vendor/jquery/jquery.min.js"></script>
<script src="/frontend/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

</body>

</html>

@endsection
@section('css') @endsection
@section('js') @endsection
