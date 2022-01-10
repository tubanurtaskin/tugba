@extends('frontend.layout')
@section('title',"Anasayfa Başlığı")
@section('content')

    <div class="container">

        <!-- Page Heading/Breadcrumbs -->
        <h1 class="mt-4 mb-3">İletişim</h1>
        <HR>


        <!-- Content Row -->
        <div class="row">
            <!-- Map Column -->
            <div class="col-lg-8 mb-4">
                <h3>Bize Ulaşın</h3>
                <form name="sentMessage" id="contactForm" novalidate="">
                    <div class="control-group form-group">
                        <div class="controls">
                            <label>Ad Soyad:</label>
                            <input type="text" class="form-control" id="name" required="" data-validation-required-message="Please enter your name.">
                            <p class="help-block"></p>
                        </div>
                    </div>
                    <div class="control-group form-group">
                        <div class="controls">
                            <label>Telefon:</label>
                            <input type="tel" class="form-control" id="phone" required="" data-validation-required-message="Please enter your phone number.">
                            <div class="help-block"></div></div>
                    </div>
                    <div class="control-group form-group">
                        <div class="controls">
                            <label>Mail Adresi:</label>
                            <input type="email" class="form-control" id="email" required="" data-validation-required-message="Please enter your email address.">
                            <div class="help-block"></div></div>
                    </div>
                    <div class="control-group form-group">
                        <div class="controls">
                            <label>Mesaj:</label>
                            <textarea rows="10" cols="100" class="form-control" id="message" required="" data-validation-required-message="Please enter your message" maxlength="999" style="resize:none"></textarea>
                            <div class="help-block"></div></div>
                    </div>
                    <div id="success"></div>
                    <!-- For success/fail messages -->
                    <button type="submit" class="btn btn-primary" id="sendMessageButton">Mesaj Gönder</button>
                </form>
            </div>

            <!-- Contact Details Column -->
            <div class="col-lg-4 mb-4">
                <h3>Adres Detayları</h3>
                <p>
                    ANA KAMPÜS

                    Düzce Üniversitesi Konuralp Yerleşkesi Yörük Mah.
                    <br> Merkez/DÜZCE, 81620
                    <br>
                </p>
                <p>
                    <abbr title="Phone">TEL</abbr>:  0850 800 81 81
                </p>
                <p>
                    <abbr title="Fax">FAX</abbr>:   0380 542 11 03
                </p>
{{--                <p>--}}
{{--                    <abbr title="Email">E</abbr>:--}}
{{--                    <a href="mailto:name@example.com">name@example.com--}}
{{--                    </a>--}}
{{--                </p>--}}

            </div>
        </div>
        <!-- /.row -->


    </div>
@endsection
@section('css') @endsection
@section('js') @endsection
