namespace Banking;
using Goverment;


public class Account{

    public event TaxOprations overBalance;
    public event MonitorBalance underBalance;
    public double Balance{get;set;}

    public Account(double balance)
    {
        this.Balance = balance;
    }

    public void Deposit(double amt){
        this.Balance=this.Balance+amt;
        ProcessTax();
    }

    public void Withdraw(double amt){
        if(amt<Balance){
       this.Balance=this.Balance-amt;
        }
        else{
            Console.WriteLine("not sufficent balance");
        }
        CheckBalance();
    }

    public void ProcessTax(){
        if(this.Balance>=250000){
            Console.WriteLine("in if");
               overBalance();
        } 
    }

    public void CheckBalance(){
        if(this.Balance<5000){
           underBalance();
        }
    }

    public override string ToString()
    {
        return "balance "+Balance;
    }
}