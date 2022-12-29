namespace Bank;

public class Account{

 private String name;
 private String accountType;
 private double balance;


//  public Account(){
//     name=null;
//     balance=0;
//     accountType="";

//  }

 public Account(String name,String accountType,double balance){
    this.name=name;
    this.accountType=accountType;
    this.balance=balance;
 }

 public double Balance{
    get{return this.balance;}
    set{this.balance=value;}
 }

 public String Name{
    get{return this.name;}
    set{this.name=value;}
 }

 public String AccountType{
    get{return this.accountType;}
    set{this.accountType=value;}
 }

public void DepositAmt(double amt){
    this.balance+=amt;
}

public void WithDrawAmt(double amt){
  if(amt==0){
    return;
  }
  if(this.balance>amt){
    balance=balance-amt;
  }
  else{
    Console.WriteLine("balance is low!!!!");
  }
}

}