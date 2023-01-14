using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Estore.Models;
using BusinessLogicLayer;
using BusinessObjectLayer;

namespace Estore.Controllers;

public class DepartmentsController : Controller
{
    private readonly ILogger<DepartmentsController> _logger;

    public DepartmentsController(ILogger<DepartmentsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    { HRManger HRM=new HRManger();
        List<Department> depts=HRM.GetallDept();
        ViewData["depts"]=depts;
        return View();
    }
}