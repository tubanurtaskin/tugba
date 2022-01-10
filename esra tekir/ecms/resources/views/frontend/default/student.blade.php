@extends('frontend.layout')
@section('title',"Anasayfa Başlığı")
@section('content')

    <body>
     <style>
     a{
         text-decoration:none;
         color:#0b58a2;
     }
     a:hover{
         text-decoration:none; color:#0b58a2;
     }
</style>

        <section class="units">
            <div class="wrapper flex container">
                <div class="content" style="width: 100%;">
                    <div class="unit-container">
                        <h2 class="unit-title">Öğrenci Bilgi Sayfası</h2>

                        <div class="unit-content">
                            <div class="quick-nav-container">
                                <span class="title">Bağlantılar</span>
                                <div class="row" style="text-decoration:none;color:#66788f;font-size:16px">
                                <div class="col-3">
                                    <ul>
                                        <li><a href="https://obs.duzce.edu.tr" target="_blank">OBS</a></li>
                                        <li><a href="#">UZEM</a></li>
                                        <li><a href="#">Kampüsler</a></li>
                                        <li><a href="#">E-Posta Hizmeti</a></li>
                                        <li><a href="#">Aday Öğrenci Portalı</a></li>
                                        <li><a href="#">Öğrenci Oryantasyonu</a></li>
                                        <li><a href="#">Danışman Onayları</a></li>
                                        <li><a href="https://sks.duzce.edu.tr/Dokumanlar/sks/PDR/pdr.html">Psikolojik Danışma ve Rehberlik</a></li>
                                    </ul>
                                </div>
                                <div class="col-3">
                                    <ul>
                                        <li><a href="/idari/kutuphane">Kütüphane</a></li>
                                        <li><a href="#">Barınma</a></li>
                                        <li><a href="#">Engelli Öğrenci</a></li>
                                        <li><a href="#">Öğrenci Destekleri</a></li>
                                        <li><a href="#">Öğrenci Toplulukları</a></li>
                                        <li><a href="#">Öğrenci İşleri Daire Başkanlığı</a></li>
                                        <li><a href="#">Sağlık, Kültür ve Spor Daire Başkanlığı</a></li>
                                        <li><a href="https://dukart.duzce.edu.tr/" target="_blank">DÜKart Para Yükleme</a></li>
                                    </ul>
                                </div>
                                <div class="col-3">
                                    <ul>
                                        <li><a href="https://duzce.edu.tr/diger/sbs">Staj</a></li>
                                        <li><a href="#">Burslar</a></li>
                                        <li><a href="#">Yaz Okulu</a></li>
                                        <li><a href="#">Yan Dal/Çift Anadal Programları</a></li>
                                        <li><a href="#">Pedagojik Formasyon</a></li>
                                        <li><a href="#">Lisansüstü Programlar</a></li>
                                        <li><a href="#">Diploma Takip</a></li>
                                        <li><a href="#" target="_blank">Kariyer Geliştirme ve Mezun İzleme Uygulama Araştırma Merkezi</a></li>
                                        <li><a href="#">WhatsApp Bildirim Hattı</a></li>
                                    </ul>
                                </div>
                                <div class="hr"></div>
                                <div class="col-3">
                                    <span class="title">Restoran, Kafeterya ve Konuk Evi</span>
                                    <ul>
                                        <li><a href="#">Turkuaz Restaurant</a></li>
                                        <li>Üskübü Cafe Restoran</li>
                                        <li><a href="#">Tıp A Tıp</a></li>
                                        <li>Orta Cafe</li>
                                        <li><a href="#">Merkez Yemekhane</a></li>
                                        <li><a href="#">Konuk Evi</a></li>
                                    </ul>
                                </div>
                                <div class="col-3">
                                    <span class="title">Bilgi ve Belgeler</span>
                                    <ul>
                                        <li><a href="#">Akademik Takvim</a></li>
                                        <li>Taban-Tavan Puanlar</li>
                                        <li><a href="#">Kanun ve Yönetmelikler</a></li>
                                        <li><a href="http://www.bap.duzce.edu.tr/" target="_blank">Bilimsel Araştırma Projeleri (BAP)</a></li>
                                        <li><a href="#">Erasmus, Mevlana, Farabi Programları</a></li>
                                        <li><a href="http://ebs.duzce.edu.tr/" target="_blank">Eğitim Öğretim Bilgi Sistemi ve Ders Bilgi Paketleri</a></li>
                                    </ul>
                                </div> </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

    </body></html>

@endsection
@section('css') @endsection
@section('js') @endsection
