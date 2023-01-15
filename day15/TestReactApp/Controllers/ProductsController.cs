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

    }
     [EnableCors()]
    [HttpPost]
    public void insert(Product prod){
        Console.WriteLine("in insert");
        DBManger db=new DBManger();
        db.Insert(prod);
    }
    
    [Route("{id}")]
    [EnableCors()]
    [HttpDelete]
    public void delete(int id){
        Console.WriteLine("indelete");
        Console.WriteLine(id);
        DBManger db=new DBManger();
        db.Delete(id);
    }

}
