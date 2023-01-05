
using Goverment;
using Banking;

CentralGov gov=new CentralGov();

BankManger manger=new BankManger();


// gov.DeductIncomeTax();

TaxOprations itopration=new TaxOprations(gov.DeductIncomeTax);

TaxOprations proopration=new TaxOprations(gov.DeductProfesionalTax);

TaxOprations seropration=new TaxOprations(gov.DeductServiceTax);

MonitorBalance blockopration=new MonitorBalance(manger.BlockAcc);
MonitorBalance emailopration=new MonitorBalance(manger.SendEmail);
MonitorBalance smsopration=new MonitorBalance(manger.SendSMS);




Account acc=new Account(5000);

acc.overBalance+=itopration;
acc.overBalance+=proopration;
acc.overBalance+=seropration;

acc.underBalance+=blockopration;
acc.underBalance+=smsopration;
acc.underBalance+=emailopration;

Console.WriteLine("enter amount");
acc.Deposit(double.Parse(Console.ReadLine()));
Console.WriteLine(acc);



Console.WriteLine("enter amount for withdraw");
acc.Withdraw(double.Parse(Console.ReadLine()));
Console.WriteLine(acc);




// itopration();
// proopration();
// seropration();

