<?php

namespace App\Http\Controllers\Frontend;

use App\Http\Controllers\Controller;
use App\Models\Blogs;
use Illuminate\Http\Request;
use App\Models\Sliders;

class DefaultController extends Controller
{
    public function index()
    {   $data['blog']=Blogs::all()->sortby('blog_must');
        $data['slider']=Sliders::all()->sortby('slider_must');
        return view('frontend.default.index',compact('data'));
    }

    public function contact()
    {
        return view('frontend.default.contact');
    }

    public function student()
    {
        return view('frontend.default.student');
    }

    public function about()
    {
        return view('frontend.default.about');
    }

    public function faculty()
    {
        return view('frontend.default.faculty');
    }
}
