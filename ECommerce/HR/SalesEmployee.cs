namespace HR;

public class SalesEmployee:Employee{

    public double Target{get;set;}

    public double SalesDone{get;set;}

    public double Incentive{get;set;}


    public SalesEmployee():base(){
         this.Target=0;
         this.SalesDone=0;
         this.Incentive=0;
    }

    public SalesEmployee(int id,string firstName,string lastName,string email,string location,
                    string contactNumber,DateTime bdate,double bsal,double hra,double DA,double target,
                    double salesDone):base(id,firstName,lastName,email,location,contactNumber,bdate,bsal,hra,DA){
         this.Target=target;
         this.SalesDone=salesDone;
         this.Incentive=0;               
    }

    public override void DoWork()
    {
        if(SalesDone>=Target){
            this.Incentive=5000;
        }
        else{
            this.Incentive=0;
        }
    }

    public override string ToString()
    {
        return base.ToString()+" "+Incentive;
    }

    public override double ComputeSal()
    {
        return base.ComputeSal()+Incentive;
    }
}