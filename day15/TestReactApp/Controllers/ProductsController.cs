using Microsoft.AspNetCore.Mvc;
using DAL;
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

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        DBManger db=new DBManger();
        return db.GetAll();

    }
}
