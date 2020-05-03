using System;

class Circle
{
    static float PI = 3.141F;
    int Rad;
    public Circle(int Radius)
    {
        Rad = Radius;
    }
    //public static Area()
    //{

    //}
    public float Area()
    {
        return Circle.PI * this.Rad * this.Rad;
    }
}
class Program
{
    static void Main()
    {
        Circle C1 = new Circle(4);
        float area = C1.Area();
        Console.WriteLine("Area = {0}", area);

    }
}

