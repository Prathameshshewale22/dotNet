namespace BusinessLogicLayer;
using BusinessObjectLayer;
using DataAccessLayer;
public class CatalogManager
{
    List<Product> allProduct=new List<Product>();

    public List<Product> GetAllProduct(){

        List<Product> AllProduct=DBManager.GetDataFromJsonFile();
        return AllProduct;
    }

     public Product GetProdctById(int id){
        List<Product> AllProduct=DBManager.GetAllProducts();

//         Product prod=(Product)from p in AllProduct
//                      where p.Pid==id
//                      select p;
// Console.WriteLine(prod);
         Product prod=AllProduct.Find((prod)=>prod.Pid==id);
        // Console.WriteLine(prod);
         return prod;            
    }

}
