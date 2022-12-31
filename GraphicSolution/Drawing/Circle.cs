namespace Drawing;

public class Circle:Shape,IPrintable{

    public Point Center{get;set;}

    public int Radius{get;set;}

    public Circle():base(0){
        this.Center=new Point(0,0);
        this.Radius=0;
    }

    public Circle(Point center,int radius,int width):base(width){
    this.Center=center;
    this.Radius=radius;
    }

    public override void Draw()
    {
        Type t=this.GetType();
        Console.WriteLine("Type is="+t.Name);
        Console.WriteLine("CenterPoint="+this.Center+"Radius"+this.Radius);
    }

    public override string ToString()
    {
        return base.ToString()+" CenterPoint="+this.Center+"Radius"+this.Radius;
    }

    public void Print(){
        Console.WriteLine("In Print");
        Console.WriteLine("CenterPoint="+this.Center+"Radius"+this.Radius);
    }

}