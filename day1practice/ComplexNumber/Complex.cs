namespace Maths;

public class Complex{
    private int real;
    private int imag;

    public Complex(int r,int i){
        this.real=r;
        this.imag=i;
    }

    public Complex(){
        this.real=0;
        this.imag=0;
    }
   
   public int Real{
    get{return this.real;}
    set{this.real=value;}
   }

   public int Imag{
    get{return this.imag;}
    set{this.imag=value;}
   }


   public static Complex operator+ (Complex c1,Complex c2){
    Complex temp=new Complex();
    temp.real=c1.real+c2.real;
    temp.imag=c1.imag+c2.imag;
    return temp;
   }
   

}