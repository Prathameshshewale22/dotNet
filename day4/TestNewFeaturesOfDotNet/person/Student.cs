namespace person;

public class Student:ICloneable{

   public int Mark{get;set;}

   public Student(){

   }

    public Student(int mark)
    {
        Mark = mark;
    }

    public new void Display(){
    Console.WriteLine("In student display");
    } 

    public object Clone(){
        return new Student(this.Mark);
    }
}