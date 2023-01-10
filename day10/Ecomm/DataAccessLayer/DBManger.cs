namespace DataAccessLayer;
using BusinessObjectLayer;
using System.Text.Json;
public static class DBManager
{

    public static List<Product> GetAllProducts(){
     List<Product> allProducts=new List<Product>();
            allProducts.Add(new Product(1,"Gerbera","Wedding Flower",6,5000));
            allProducts.Add(new Product( 2,"Rose","Valentine Flower",15,7000 ));
            allProducts.Add(new Product(3,"Lotus","Worship Flower",26,3400 ));
            allProducts.Add(new Product(4,"Carnation","Pink carnations signify a mother's love, red is for admiration and white for good luck", 16, 27000 ));
            allProducts.Add(new Product(5,"Lily","Lilies are among the most popular flowers in the U.S.",6,1000 ));
            allProducts.Add(new Product(6,"Jasmine","Jasmine is a genus of shrubs and vines in the olive family",26,2000 ));
            allProducts.Add(new Product(7,"Daisy","Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.",36,159 ));
            allProducts.Add(new Product(8,"Aster","Asters are the September birth flower and the the 20th wedding anniversary flower.", 16, 67 ));
            allProducts.Add(new Product(9,"Daffodil", "Wedding Flower",6,5000 ));
            allProducts.Add(new Product(10,"Dahlia","Dahlias are a popular and glamorous summer flower.",7,0 ));
                
        //           var options=new JsonSerializerOptions {IncludeFields=true};
        // string filename=@"E:\cdac\pg-dac\dotNet\localRepo_dotnet\dotnet\dotNet\day10\Ecomm\Product.json";
        //   var jsondata=JsonSerializer.Serialize<List<Product>>(allProducts,options);
        //       File.WriteAllText(filename,jsondata);
                return allProducts;

    } 

    public static List<Product> GetDataFromJsonFile(){
        // var options=new JsonSerializerOptions {IncludeFields=true};
        string filename=@"E:\cdac\pg-dac\dotNet\localRepo_dotnet\dotnet\dotNet\day10\Ecomm\Product.json";
        var jsondata=File.ReadAllText(filename);
          List<Product> allprod=JsonSerializer.Deserialize<List<Product>>(jsondata);
          return allprod; 
    } 

    // public static List<Product> GetDataFromDataBase(){
    //     List<Product> allproduct=
    //     return allproduct; 
    // }

}
