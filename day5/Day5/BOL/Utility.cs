namespace BOL;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public static class Utility{


    public static Student GetById(int id,List<Student> stud){
        foreach(Student st in stud){
            if(st.Sid==id){
                return st;
            }
        }
        return null;
    }

    public static bool deleteReacord(int id,List<Student> stud){
        foreach(Student st in stud){
            if(st.Sid==id){
                stud.Remove(st);
                return true;
            }
        }
        return false;

    }

    public static void StoredData(List<Student> st){
        try{

            var options=new JsonSerializerOptions {IncludeFields=true};
            var jsondata=JsonSerializer.Serialize<List<Student>>(st,options);
            string fileName=@"E:\cdac\pg-dac\dotNet\localRepo_dotnet\dotnet\dotNet\day5\Day5\stud.json";
            File.WriteAllText(fileName,jsondata);
            Console.WriteLine("data added in file");

        }
        catch(Exception e){

        }
        finally{

        }
    }

    public static List<Student> GetDataFromFile(){
        var options=new JsonSerializerOptions {IncludeFields=true};
         string fileName=@"E:\cdac\pg-dac\dotNet\localRepo_dotnet\dotnet\dotNet\day5\Day5\stud.json";
         string jsondata= File.ReadAllText(fileName);
         List<Student> st=JsonSerializer.Deserialize<List<Student>>(jsondata);
         return st;
        
    }
}