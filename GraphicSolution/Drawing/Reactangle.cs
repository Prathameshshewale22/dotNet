namespace Drawing;

public class Rectangle:Shape,IPrintable{

    public Point StartPoint{get;set;}

    public Point EndPoint{get;set;}

    public Rectangle():base(0){
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);

    }

    public Rectangle(Point pt1,Point pt2,int width):base(width){
        this.StartPoint=pt1;
        this.EndPoint=pt2;
    }

    public override void Draw()
    {
        Type t=this.GetType();
        Console.WriteLine("Type is="+t.Name);
        Console.WriteLine("StartingPoint="+this.StartPoint+" endpoint"+this.EndPoint);
        
    }

    public override string ToString()
    {
        
        return base.ToString()+"StartPoint="+this.StartPoint+" endpoint="+this.EndPoint;
    }

    public void Print(){
        Console.WriteLine("In Print method");
        Console.WriteLine("StartingPoint="+this.StartPoint+" endpoint"+this.EndPoint);
    }

}