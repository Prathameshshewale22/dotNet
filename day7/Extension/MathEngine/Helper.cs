namespace MathEngine;


public static class Helper{

    public static int Multiple(this MathOprations m,int a,int b){
        m.Result=a*b;
        return m.Result;
    }

    public static double Divide(int a,int b){
        return a/b;
    }
}