using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using DAL;
using BOL;
namespace TestReactApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }
    //  [HttpGet(Name = "GetProducts")]
     [EnableCors()]
    [HttpGet]
    public IEnumerable<Product> Get()
    {
        Console.WriteLine("in get");
        DBManger db=new DBManger();
        List<Product> allres=db.GetAll();
        Console.WriteLine(allres);
        return  allres;

        // Product prod=new Product(1,"prod-1","test",200,5000);
        // List<Product> prods=new List<Product>();
        // prods.Add(prod);
        // return prods;

    }
}
