namespace DataLayer;


public class Student{
    

    public string Name{get;set;}
    public int sid{get;set;}

    public Student(string name, int sid)
    {
        Name = name;
        this.sid = sid;
    }
}
