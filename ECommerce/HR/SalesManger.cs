namespace HR;

public class SalesManager:SalesEmployee{
    
    public double Bonus{get;set;}


    public SalesManager(int id,string firstName,string lastName,string email,string location,
                    string contactNumber,DateTime bdate,double bsal,double hra,double DA,double target,
                    double salesDone,double bonus):base(id,firstName,lastName,email,location,contactNumber,
                    bdate,bsal,hra,DA,target,salesDone){
        this.Bonus=bonus;
    }

    public SalesManager():base(){
        this.Bonus=0;
    }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public override double ComputeSal()
    {
        return base.ComputeSal();
    }
}