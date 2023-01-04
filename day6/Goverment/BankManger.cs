namespace Banking;

public delegate void MonitorBalance();
public class BankManger{

     public void BlockAcc(){
        Console.WriteLine("Your Account is Block due to low balance");
     }

     public void SendEmail(){
        Console.WriteLine("Email send");
     }

     public void SendSMS(){
        Console.WriteLine("SMS send");
     }
}