using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(2 , "red");
            c.Area();
            Console.WriteLine("Area of circle " + c.Area());


            Cylinder ch = new Cylinder(2,5,"red");
            ch.Area();
            Console.WriteLine("Area of cylinder " + ch.Area());


        }

    }
}