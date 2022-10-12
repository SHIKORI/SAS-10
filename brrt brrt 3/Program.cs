using brrt_brrt_3;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Color of the circle: ");
        string color = Convert.ToString(Console.ReadLine());
        Console.WriteLine("What is the circle’s radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle ans = new Circle(radius);

        Console.WriteLine("The color of the circle is: "+ color);
        Console.WriteLine("The area of the circle is " + ans.getArea);
        Console.WriteLine("The Circumference of the circle is " + ans.getCircumference);
    }
}