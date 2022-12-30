using MemberShip;
using HR;

Console.WriteLine("enter nemail and password");
string? email=Console.ReadLine();
string? password=Console.ReadLine();


Console.WriteLine(email+" "+password);

if(AuthManager.validate(email,password)){
    Console.WriteLine("in if");
     Console.WriteLine("welcome");
     SalesManager manager=new SalesManager();
     manager.DoWork();
    Console.WriteLine( manager.ToString());
}
else{
    Console.WriteLine("please try again");
}
Console.WriteLine("Thank you ");
