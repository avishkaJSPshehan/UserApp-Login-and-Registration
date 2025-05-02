using System;
using Microsoft.AspNetCore.Mvc;

namespace UserApp_Login_and_Registration.Controllers;

public class AccountController : Controller
{
    public IActionResult Login(){
        return View();
    }

    public IActionResult Register(){
        return View();
    }

    public IActionResult VerifyEmail(){
        return View();
    }
}
