namespace DAL;

using BOL;

public class DBManger:IDBManager{

    public List<Product> GetAll(){

        using (var context=new CollectionContext()){
            var Product=from prod in context.products select prod;
            return Product.ToList<Product>();
        }
    }
     public void Insert(Product prod){
        Console.WriteLine("in insert");
            using (var context = new CollectionContext())
        {
            context.products.Add(prod);
            context.SaveChanges();  
        }
    }

}