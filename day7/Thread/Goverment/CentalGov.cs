namespace Goverment;
public delegate void TaxOprations();
public class CentralGov
{
    public void DeductIncomeTax(){
        Console.WriteLine("15% tax deducted");
    }

    public void DeductProfesionalTax(){
        Console.WriteLine("10% Propfessional tax deducted");
    }
    public void DeductServiceTax(){
        Console.WriteLine("5% service tax deducted");
    }

}
