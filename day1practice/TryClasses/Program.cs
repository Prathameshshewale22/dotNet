using Bank;
using System.Collections.Generic;
List<Account> accounts=new List<Account>();
accounts.Add(new Account("prathamesh","saving",10000));

accounts.Add(new Account("akash","current",20000));

bool flag=false;

while(!flag){
    Console.WriteLine("enter choice");
    Console.WriteLine("1.add account/2.display all account/3.deposit amount/4.withdraw amount/5.exit");
    int choice=Convert.ToInt32(Console.ReadLine());
 switch(choice){
    case 1:
    Console.WriteLine("enter name accouttype balnce");
    Account acc=new Account(Console.ReadLine(),Console.ReadLine(),Convert.ToDouble(Console.ReadLine()));
    accounts.Add(acc);
    break;

    case 2:
    foreach(Account theAcc in accounts){
        // Console.WriteLine("acc-"+theAcc.Name+" "+theAcc.AccountType+" "+theAcc.Balance);
        Console.WriteLine(theAcc);
    }
     break;
    case 3:
    //deposit
    Console.WriteLine("enter the amount to deposit and account name");
    double amt=Convert.ToDouble(Console.ReadLine());
    String nm=Console.ReadLine();
    foreach(Account theAcc in accounts){
        if(theAcc.Name==nm){
            theAcc.DepositAmt(amt);
            break;
        }  
    }
            Console.WriteLine("Account not found");   
    break;
    case 4:
    //Withdraw
    Console.WriteLine("enter the amount to deposit and account name");
     amt=Convert.ToDouble(Console.ReadLine());
     nm=Console.ReadLine();
    foreach(Account theAcc in accounts){
        if(theAcc.Name==nm){
            theAcc.WithDrawAmt(amt);
            break; 
        }
        else
        {
            Console.WriteLine("Account not found");
        }
    }
    break;
    case 5:
    flag=true;
    break;

 }
}

