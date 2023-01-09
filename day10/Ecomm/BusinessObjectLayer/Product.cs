namespace BusinessObjectLayer;
[Serializable]
public class Product
{

    public int Pid{get;set;}

    public string Pname{get;set;}

    public string Description{get;set;}

    public double Price{get;set;}

    public int Quntity{get;set;}


   public Product(){
    
   }
    public Product(int pid, string pname, string description, double price, int quntity)
    {
        Pid = pid;
        Pname = pname;
        Description = description;
        Price = price;
        Quntity = quntity;
    }

    public Product(int pid, string pname){
        this.Pid=pid;
        this.Pname=pname;
    }
}
