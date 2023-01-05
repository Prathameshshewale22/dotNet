namespace Institute;
public class Student:IComparable
{

    public int Sid{get;set;}

    public string Name{get;set;}

    public string Location{get;set;}

    public Student(int sid, string name, string location)
    {
        Sid = sid;
        Name = name;
        this.Location = location;
    }

    public override bool Equals(object? obj)
    {
        if(obj== null){
            return false;
        }
        Student objAsStudent=obj as Student;
        if(objAsStudent==null){
            return false;
        }
        else return Equals(objAsStudent);
    }

    // public override int GetHashCode()
    // {
    //     return base.GetHashCode();
    // }

    public override string? ToString()
    {
        return "Student id="+Sid+" Name="+Name+" Location="+Location;
    }

    public int CompareTo(object? obj)
    {
        if(obj==null) return 1;
        Student stud=obj as Student;
        if(stud!=null){
            return this.Sid.CompareTo(stud.Sid);
        }
        else{
            throw new ArgumentException("Object doesn't have a proper sid");
        }
    }
}
