namespace DataAccessLayer;
using System;
using System.Text.Json;
using System.Text;
using bussinesslayer;
using DataLayer;

public static class DataAccess{
 
        public static List<Student> RestoreData(){
        var options=new JsonSerializerOptions {IncludeFields=true};
         string fileName=@"E:\cdac\pg-dac\dotNet\localRepo_dotnet\dotnet\day8\StudentRegistration\studnet.json";
         string jsondata= File.ReadAllText(fileName);
         List<Student> st=JsonSerializer.Deserialize<List<Student>>(jsondata);
         return st;
         }
         
}
    
