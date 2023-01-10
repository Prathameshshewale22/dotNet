using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Estore.Models;
using BusinessLogicLayer;
using BusinessObjectLayer;

namespace Estore.Controllers;

public class EmployeesController : Controller
{
    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int id)
    {  Console.WriteLine(id);
        HRManger HRM=new HRManger();
        List<Employee> emp=HRM.allEmpDetails(id);
        ViewData["emps"]=emp;
        return View();
    }
}