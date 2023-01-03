namespace BOL;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Student
{

    public int Sid{get;set;}

    public string FirstName{get;set;}

    public string LastName{get;set;}

    public DateTime Birthdate{get;set;}

    public string Loction{get;set;}

    
public Student()
    {
        Sid = 1;
        FirstName = "Prathamesh";
        LastName = "shewale";
        Birthdate = new DateTime(1996,10,22);
        Loction = "Pune";
    }
    public Student(int sid, string firstName, string lastName, DateTime birthdate, string loction)
    {
        Sid = sid;
        FirstName = firstName;
        LastName = lastName;
        Birthdate = birthdate;
        Loction = loction;
    }

    public override string ToString()
    {
        return "StudentId= "+Sid+" FirestName= "+FirstName+" LastName= "+LastName+" BirthDate= "+Birthdate+" Location= "+Loction; 
    }

}
