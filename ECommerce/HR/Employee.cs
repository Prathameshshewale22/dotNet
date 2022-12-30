namespace HR;
public abstract class Employee
{
    public int Id{get;set;}
    public string FirstName{get;set;}

    public string LastName{get;set;}

    public string Email{get;set;}

    public string Location{get;set;}

    public string ContactNumber{get;set;}

    public DateTime birthdate{get;set;}

    public double BasicSal{get;set;}

    public double HRA{get;set;}

    public double DA{get;set;}

    public Employee():this(1,"prathamesh","shewale","prathameshs13@gmail.com","pune","9970162129",new DateTime(1996,10,22),
                           50000,10000,4000){

    }

    public Employee(int id,string firstName,string lastName,string email,string location,
                    string contactNumber,DateTime bdate,double bsal,double hra,double DA)
    {
        this.Id=id;
        this.FirstName=firstName;
        this.LastName=lastName;
        this.Email=email;
        this.Location=location;
        this.ContactNumber=contactNumber;
        this.birthdate=bdate;
        this.BasicSal=bsal;
        this.HRA=hra;
        this.DA=DA;
    }

    public virtual double ComputeSal(){
        double sal=(25*DA)+BasicSal+HRA;
        return sal;
    }

    public abstract void DoWork();

    public override string ToString()
    {
        string str=string.Format("{0},{1},{2},{3},{4},{5}", Id,FirstName,LastName,Email,Location,ContactNumber);
        return str;
    }


}
