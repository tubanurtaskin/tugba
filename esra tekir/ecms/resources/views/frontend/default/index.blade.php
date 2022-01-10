@extends('frontend.layout')
@section('title',"Anasayfa Başlığı")
@section('content')
<header>
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">

        <div class="carousel-inner" role="listbox">
            @php($count=0)
            @foreach($data['slider'] as $slider)
            <div class="carousel-item @if ($count++==0) active @endif" style="background-image: url('/images/sliders/{{$slider->slider_file}}')">
                <div class="carousel-caption d-none d-md-block">
                    <a href="@if(strlen($slider->slider_url)>0) {{$slider->slider_url}} @else javascript:void(0) @endif ">
{{--                        <h3>{{$slider->slider_title}}</h3>--}}
                    </a>
                </div>
            </div>
            @endforeach

        </div>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
</header>
<body>
<!-- Page Content -->
<div class="container" >


    <!-- Portfolio Section -->
    <h2 class="mt-4">Duyurular</h2>

    <div class="row">

        @foreach($data['blog'] as $blog)
        <div class="col-lg-4 col-sm-6 portfolio-item">
            <div class="card h-100">
                <a href="{{route('blog.Index')}}"><img class="card-img-top" src="/images/blogs/{{$blog->blog_file}}" alt=""></a>
                <div class="card-body">
                    <h4 class="card-title">
                        <a href="{{route('blog.Index')}}">{{$blog->blog_title}}</a>
                    </h4>
                    <p class="card-text">{!! substr($blog->blog_content,0,140)!!}</p>
                </div>
            </div>
        </div>
        @endforeach

    </div>
    <!-- /.row -->

    <!-- Features Section -->
    <div class="row" >
        <div class="col-lg-6" >
            <h2>Bilgi Güvenliği Politikamız</h2>
            <p>İdaremizin hedefleri doğrultusunda çalışmalarını gerçekleştirirken üretilen, kamu kurum/kuruluşları ile ortak kullanılan her formattaki verinin BGYS gereksinimleri çerçevesinde güvenliğinin sağlanması, bilgi varlıklarımıza yönelik kasıtlı veya kasıtsız her türlü tehdidin belirlenmesi ve bu tehditlerin oluşturabileceği risklerin yönetilebilmesi, E-Devlet çalışmaları kapsamında oluşturulan ULAKNET ağı üzerinden sağlanan veri alışverişinin güvenliğinin sağlanması amacıyla;</p>
            <ul>
                <li>BGYS’nin yürütülmesi için kullanılan süreç ve faaliyetlerin sürekli iyileştirilmesi amacıyla düzenli gözden geçirilmesini,</li>
                <li>Kapsam dâhilindeki kurumsal bilginin gizliliği, bütünlüğü, yetkiler dâhilinde erişilebilirliği ve sürekliliğini,</li>
                <li>Yasal düzenlemelere, mevzuat hükümlerine ve sözleşmelere uygun şekilde hizmetlerin; hatasız, mümkün olan en kısa sürede ve kesintisiz olarak sunulmasını,</li>
                <li>İş süreçlerinin bilgi güvenliği yönetim sistemi kapsamında hazırlanan ve onaylanan politika ve prosedürlere uygun şekilde yürütülmesini,</li>
                <li>Bilgi güvenliği risklerinin tanımlanmasını ve sistematik olarak yönetilmesini,</li>

            </ul>
            <p>taahhüt ederiz.</p>
        </div>
        <div class="col-lg-6">
            <img class="img-fluid rounded" src="/images/logodu.png" alt="">
        </div>
    </div>
    <!-- /.row -->

    <hr>

</div>

</body>
@endsection
@section('css') @endsection
@section('js') @endsection
