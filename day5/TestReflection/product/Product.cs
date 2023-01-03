namespace product;
public class product
{
    public int Pid{get;set;}

    public string pname{get;set;}

    public double Price{get;set;}

    public product(int pid, string pname, double price)
    {
        Pid = pid;
        this.pname = pname;
        Price = price;
    }
    

    public void Display(){
        Console.WriteLine("Pid= "+Pid+" pname= "+pname+" Price="+Price);
    }

   
}
