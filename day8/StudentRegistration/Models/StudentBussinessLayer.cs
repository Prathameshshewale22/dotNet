namespace bussinesslayer;
using DataLayer;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class StudnetBusinessLayer{
List<Student> students=new List<Student>(DataAccessLayer.DataAccess.RestoreData());


public bool insertData(int sid,string name,string email,string password){
    students.Add(new Student(name,sid,email,password));
    students.ForEach((st)=>{Console.WriteLine(st);});
    return true;
}

public List<Student> getData(){
    Console.WriteLine("in getdatamethod");
    students.ForEach((st)=>{Console.WriteLine(st);});
    return students;
}
public void StoredData(){
        try{
            var options=new JsonSerializerOptions{IncludeFields=true};
            var jsondata=JsonSerializer.Serialize<List<Student>>(students,options);
            string fileName=@"E:\cdac\pg-dac\dotNet\localRepo_dotnet\dotnet\day8\StudentRegistration\studnet.json";
            File.WriteAllText(fileName,jsondata);
            Console.WriteLine("data added in file");
        }
        catch(Exception e){

        }
        finally{

        }
}

public bool validate(string email,string password){

   foreach(Student s in students){
    if(s.Email==email && s.Password==password){
        return true;
    }
   }
   return false;
}

}


