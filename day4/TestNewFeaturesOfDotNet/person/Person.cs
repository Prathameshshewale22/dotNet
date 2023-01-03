namespace person;
public  class Person
{
 //   public const float PI=3.14;

    // private readonly int id;

     public int Id{get;set;}
    public string FirstName{get;set;}

    // public Person(string FirstName){
    //     Id=1;
    //     this.FirstName=FirstName;
    // }
  public Person(){

  }
    // Person(){
    //     this.Id=2;
    //     this.FirstName="prathamesh";
    // }

    public static Person _ref=null;

    public static Person createInstance(){
        Console.WriteLine("in createistance");
        if(_ref==null){
            return new Person();
        }
        else{
            return _ref;
        }
    }

   



    // // public Person(int id,string firstName ){
    // //     this.Id=id;
    // //     this.FirstName=firstName;
    // // }

    // public void Display(){
    //     Console.WriteLine("Id "+Id+" "+"firstname "+FirstName);
    // }

    public virtual void Display(params int [] marks){
        foreach(int s in marks){
            Console.WriteLine(s+" ");
        }
    }

    public virtual void display(){
        Console.WriteLine("in person display");
    }

    public void Swapping(ref int num1,ref int num2){
        int temp=num1;
        num1=num2;
        num2=temp;
        Console.WriteLine(num1+" "+num2);
    }

    public void Calculate(int val,out double area, out double circumference){
         area=3.14*val*val;
        circumference=2*3.14*val;
        
    }


  


}
