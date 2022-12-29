using Maths;

public class Complex{
    private int real;
    private int imag;

    public Complex(int r,int i){
        this.real=r;
        this.imag=i;
    }
   
   public int Real{
    get{return this.real;}
    set{this.real=value;}
   }

   public int Imag{
    get{return this.imag;}
    set{this.imag=value;}
   }

   

}