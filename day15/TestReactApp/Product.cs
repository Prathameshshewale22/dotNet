namespace DOL;
public class Product{

    public int Pid{get;set;}

    public string Pname{get;set;}

    public string Description{get;set;}

    public int  Price{get;set;}

    public int Quntity{get;set;}

    public Product(int pid, string pname, string description, int price, int quntity)
    {
        Pid = pid;
        Pname = pname;
        Description = description;
        Price = price;
        Quntity = quntity;
    }
}