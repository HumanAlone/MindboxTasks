using System;

namespace SquareComputingLibrary
{
    abstract public class Shape
    {
        abstract public double GetSquare();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetSquare()
        {
            // Полупериметр треугольника
            double p = (a + b + c) / 2;
            // Формула Герона
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
            {
                Console.WriteLine("Треугольник прямоугольный!");
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
