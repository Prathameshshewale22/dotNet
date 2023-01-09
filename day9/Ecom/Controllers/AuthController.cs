namespace Ecom.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.CookieBuilder;

public class AuthController:Controller
{

 private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login(string email,string password)
    {
        
        if(email=="Prathameshs13@gmail.com" && "123"==password){
            // HttpCookie kt=new HttpCookie("User","prathamesh"); 
            // CookieBuilder kb=new CookieBuilder();
            // kb.
            return Redirect("/home");
        }
        return View();
    }
    
}