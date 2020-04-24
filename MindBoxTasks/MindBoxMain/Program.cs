using System;
using SquareComputingLibrary;

namespace MindBoxMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2);            
            Triangle triangle = new Triangle(6, 8, 10);
            double circleSquare = circle.GetSquare();
            double triangleSquare = triangle.GetSquare();

            Console.WriteLine(circleSquare);
            Console.WriteLine(triangleSquare);
        }
    }
}
