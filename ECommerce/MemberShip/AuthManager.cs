namespace MemberShip;
public  static class AuthManager
{

public static bool validate(string email,string password){
bool status=false;

if(email=="prathamesh13@gmail.com" && password=="abc@123"){
    Console.WriteLine("in validate");
    status=true;
}
return status;
}

public static bool register(string firstName,string lastNme,string email,string location,string contactNumber){
    bool status=false;
    try{
    User newUser=new User();
    newUser.FirstName=firstName;
    newUser.LastName=lastNme;
    newUser.Email=email;
    newUser.Location=location;
    newUser.ContactNumber=contactNumber;
    status=true;
    }
    catch(Exception e){

    }
    finally{

    }
    return status;
}

}
