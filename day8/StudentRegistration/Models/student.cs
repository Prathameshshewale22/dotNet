namespace DataLayer;


public class Student{
    

    public string Name{get;set;}
    public int Sid{get;set;}

    public string Email{get;set;}

    public string Password{get;set;}

    public Student(string name, int sid, string email, string password)
    {
        Name = name;
        this.Sid = sid;
        Email = email;
        Password = password;
    }

    public override string ToString()
    {
        return "sid="+Sid+"Name="+Name+"email="+Email+"password="+Password;
    }
}
