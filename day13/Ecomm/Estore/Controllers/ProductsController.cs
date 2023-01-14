using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Estore.Models;
using BusinessLogicLayer;
namespace Estore.Controllers;
using BusinessObjectLayer;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatalogManager CM=new CatalogManager();

        List<Product> list=CM.GetAllProduct();
    //    CM.InsertProducts(list);
        ViewData["List"]=list;

        return View();
    }

    public IActionResult Details(int id){
    CatalogManager CM=new CatalogManager(); 
      ViewData["product"]=(Product)CM.GetProdctById(id);
      return View();
    }


   public IActionResult AddData(){
    Product newProd=new Product();
    return View();
   }

    [HttpPost]
    public IActionResult AddData(Product prod){
        List<Product> prods=new List<Product>();
        prods.Add(prod);
        CatalogManager CM=new CatalogManager(); 
        CM.InsertProducts(prods);
        return Redirect("Index");
    }

}