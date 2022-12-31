namespace Drawing;

public enum Color{RED,WHITE,GREEN}

public abstract class Shape{

    public int Width{get;set;}

    public Color ShapeColor{get;set;}

    public Shape(int width){
        this.Width=width;
        // this.ShapeColor=color;
    }

    public abstract void Draw();

    public override string ToString()
    {
        return "Width="+this.Width;
    }

}