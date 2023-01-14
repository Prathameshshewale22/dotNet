namespace DAL;

using BOL;

public class DBManger:IDBManager{

    public List<Product> GetAll(){

        using (var context=new CollectionContext()){
            var Product=from prod in context.Products select prod;
            return Product.ToList<Product>();
        }
    }
}