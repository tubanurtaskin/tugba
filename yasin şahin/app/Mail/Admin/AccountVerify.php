<?php

namespace App\Mail\Admin;

use App\Models\Admin\Users;
use Illuminate\Bus\Queueable;
use Illuminate\Contracts\Queue\ShouldQueue;
use Illuminate\Mail\Mailable;
use Illuminate\Queue\SerializesModels;

class AccountVerify extends Mailable
{
    use Queueable, SerializesModels;

    public $user;

    /**
     * Create a new message instance.
     *
     * @return void
     */
    public function __construct(Users $user)
    {
        //
        $this->user = $user;

        if(!\Cache::has("account_verify_".$user->token)){
            \Cache::put("account_verify_".$user->token,true,3600);
        }

    }

    /**
     * Build the message.
     *
     * @return $this
     */
    public function build()
    {
        return $this->view('admin.emails.verify_account')->subject("Hesap Doğrulama");
    }
}
