using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Models;
using bussinesslayer;

using DataLayer;

namespace StudentRegistration.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public ActionResult Index()
    {
        StudnetBusinessLayer std=new StudnetBusinessLayer();
        List<DataLayer.Student> studes=std.getData();
        return View(studes);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Registration(){
        return View();
    }

    public IActionResult RegistrationSuccess(int Sid, string name,string email,string password){
        StudnetBusinessLayer std=new StudnetBusinessLayer();
        std.insertData(Sid,name,email,password);
        std.StoredData();
        return View();
    }

    public IActionResult WelcomePage(){
        return View();
    }

    public IActionResult Login(){
        return View();
    }

    
    public IActionResult Validate(string email,string password){
         StudnetBusinessLayer std=new StudnetBusinessLayer();
         if(std.validate(email,password)){
            Console.WriteLine("in if");
            return Redirect("/home");
         }
          return View() ; 
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
