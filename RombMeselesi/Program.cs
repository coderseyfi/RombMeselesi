using System;

namespace RombMeselesi
{
    class Program
    {
        static void Main(string[] args)
        {


            Romb romb = new Romb(5,5,5,5,4);

            Print(romb);

        }

        static void Print(Quadrangular shape)
        {
            double shapePerimeter = shape.Perimeter();
            double shapeArea = shape.Area();

            Console.WriteLine($"{shape.GetType().Name} | Perimeter: {shapePerimeter}, Area:{shapeArea}");

        }
    }
}
