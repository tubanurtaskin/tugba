<?php

namespace App\Http\Controllers\Frontend;

use App\Http\Controllers\Controller;
use App\Models\Blogs;
use Illuminate\Http\Request;

class BlogController extends Controller
{
    public function index()
    {   $data['blog']=Blogs::all()->sortby('blog_must');
        return view('frontend.blog.index',compact('data'));
    }
}
