using BOL;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

List<Student> Studentlist=new List<Student>();
Student s1=new Student(1,"prathamesh","Shewale",new DateTime(1996,10,22),"Pune123");
Student s2=new Student(2,"Abhi","Shewale",new DateTime(1998,07,2),"Mumbai");
Studentlist.Add(s1);
Studentlist.Add(s2);

bool flag=false;
while(!flag){
    Console.WriteLine("Enter the choice");
    Console.WriteLine("1.Add Studnet/2.getAll/3.getById/4.delete student record/5.stored data in file/6.retrive data from file/7.update FirstName/8.exit");
    int choice=Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
        Console.WriteLine("enter the studnet id, FirstName, LastName, date of birth(YYYY,MM,DD), Location ");
        Student s=new Student(Convert.ToInt32(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(),
                new DateTime(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())),
                Console.ReadLine());
                Studentlist.Add(s);
                // Utility.StoredData(Studentlist); 
        break;

        case 2:
           foreach(Student stud in Studentlist){
            Console.WriteLine(stud);
           }
        break;

        case 3:
            Console.WriteLine("enter the Student id ");
            Student studbyid=Utility.GetById(Convert.ToInt32(Console.ReadLine()),Studentlist);
            Console.WriteLine("found Student="+studbyid);
        break;
        
        case 4:
        Console.WriteLine("enter the Studnet id ");
        bool fflag=Utility.deleteReacord(Convert.ToInt32(Console.ReadLine()),Studentlist);
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
 
         Utility.StoredData(Studentlist); 
        break;

        case 6:
        //deseralizer 
        
                List<Student> std=Utility.GetDataFromFile();
                foreach( Student st in std){
                 Console.WriteLine(st);
                }
        break;

        case 7:
        //update Firstname
        Console.WriteLine("enter id,change name");
        Student st1=Utility.UpdateName(Convert.ToInt32(Console.ReadLine()),Console.ReadLine(),Studentlist);
        Console.WriteLine(st1);
        break; 

        case 8:
        flag=true;
        break;  
      
    }







}



