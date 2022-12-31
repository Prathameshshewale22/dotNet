
using Drawing;

using System.Collections.Generic;

Point pt1=new Point(10,20);
Point pt2=new Point(30,40);
Shape shape1=new Rectangle(pt1,pt2,10);

Point pt3=new Point(15,20);
Point pt4=new Point(5,15);
Point pt5=new Point(40,10);

Shape shape2=new Line(pt3,pt4,20);
Shape shape3=new Circle(pt5,50,5);

List<Shape> shapes=new List<Shape>();
shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(shape3);


foreach(Shape s in shapes){
 
 s.Draw();
 Console.WriteLine(s.ToString());
 IPrintable obj = (IPrintable)s;
 obj.Print();
}

