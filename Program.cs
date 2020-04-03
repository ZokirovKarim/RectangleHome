using System;
public class Rectangle
{
    double side1, side2;
    double area,perimeter;
     static void Main(string[] args)
    {
        var rectangle = new Rectangle(5.5,6.5);
        Console.WriteLine($"Площадь: {rectangle.Area}, Прямоугольник: { rectangle.Perimeter}");
        Console.ReadLine();
    }
    
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    
    public double AreaCalculator()
    {
        return this.area=side1*side2;
    }
    
    public double PerimeterCalculator()
    {
        return  this.perimeter=(side1+side2)*2;
    }
    
    public double Area
    {
        get { return AreaCalculator(); }
    }
    
    public double Perimeter
    {
        get { return PerimeterCalculator(); }
    }
}

   


 
