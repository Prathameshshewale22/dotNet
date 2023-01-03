using BOL;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

List<Student> Studentlist=new List<Student>();
Student s1=new Student(1,"prathamesh","Shewale",new DateTime(1996,10,22),"Pune");
Student s2=new Student(2,"Abhi","Shewale",new DateTime(1998,07,2),"Mumbai");
Studentlist.Add(s1);
Studentlist.Add(s2);

bool flag=false;
while(!flag){
    Console.WriteLine("Enter the choice");
    Console.WriteLine("1.Add Studnet/2.getAll/3.getById/4.delete student record/8.exit");
    int choice=Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
        Console.WriteLine("enter the studnet id, FirstName, LastName, date of birth(YYYY,MM,DD), Location ");
        Student s=new Student(Convert.ToInt32(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(),
                new DateTime(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())),
                Console.ReadLine());
                Studentlist.Add(s);
        break;

        case 2:
           foreach(Student stud in Studentlist){
            Console.WriteLine(stud);
           }
        break;

        case 3:
            Console.WriteLine("enter the Student id ");
            Student studbyid=Validate.GetById(Convert.ToInt32(Console.ReadLine()),Studentlist);
            Console.WriteLine("found Student="+studbyid);
        break;
        case 4:
        Console.WriteLine("enter the Studnet id ");
        bool fflag=Validate.deleteReacord(Convert.ToInt32(Console.ReadLine()),Studentlist);
        if(fflag==true){
            Console.WriteLine("record deleted !!!");
            Console.WriteLine("updated list");
            foreach(Student stud in Studentlist){
            Console.WriteLine(stud);
            }
        }
        else{
            Console.WriteLine("record not found !!!1");
           }
        break;
        case 5:
        //serialize data
        try{
            var options=new JsonSerializerOptions {IncludeFields=true};
            var studnetJson=JsonSerializer.Serialize<List<Student>>(Studentlist,options);
            string fileName=@"E:\cdac\pg-dac\dotNet\localRepo_dotnet\dotnet\dotNet\day5\Day5\studnet.json";
            File.WriteAllText(fileName,studnetJson);
        }
        catch(Exception e){

        }
        finally{

        }     
        break;
        case 6:
        //deseralizer 
        try{
            var options=new JsonSerializerOptions {IncludeFields=true};
            var studnetJson=JsonSerializer.Serialize<List<Student>>(Studentlist,options);
            string fileName=@"E:\cdac\pg-dac\dotNet\localRepo_dotnet\dotnet\dotNet\day5\Day5\studnet.json";
            string jsonString = File.ReadAllText(fileName);
            List<Student> studlist=JsonSerializer.Deserialize<List<Student>>(jsonString);
            foreach( Student st in studlist){
                Console.WriteLine(st);
            }
        }
        catch(Exception e){

        }
        finally{

        }  


        break;

        case 7:

        break; 

        case 8:
        flag=true;
        break;  
      
    }







}



