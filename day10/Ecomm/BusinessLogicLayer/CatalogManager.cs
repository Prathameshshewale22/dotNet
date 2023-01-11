namespace BusinessLogicLayer;
using BusinessObjectLayer;
using DataAccessLayer;
using DataAccessLayer.Connected;
public class CatalogManager
{
    List<Product> allProduct=new List<Product>();

    public List<Product> GetAllProduct(){

        List<Product> AllProduct=DBManagerForSql.AllProduct();
        return AllProduct;
    }

     public Product GetProdctById(int id){
        List<Product> AllProduct=DBManagerForSql.AllProduct();

        // Product prod=(Product)from p in AllProduct
        //              where p.Pid==id
        //              select p;
// Console.WriteLine(prod);
         Product prod=AllProduct.Find((prod)=>prod.Pid==id);
         return prod;            
    }

    public bool InsertProducts(List<Product> prods){
        bool status=false;
        status=DBManagerForSql.InsertProduct(prods);
        return status;
    }

}
