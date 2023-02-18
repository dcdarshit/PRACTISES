using System;

namespace AbstractImplementation
{
    public abstract class Figures
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }
    public class Rectangle : Figures
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class Circle : Figures
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi*Radius * Radius;
        }
    }

    public class Cone:Figures
    {
        public Cone(double Radius, double Height)
        {
            this.Height = Height;
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Radius;
        }

        static void Main()
        {
            Rectangle rc = new Rectangle(12.0,56.67);
            Circle c = new Circle(45.98);
            Console.WriteLine("Area of a Rectangle is"+rc.GetArea());
            Console.WriteLine("Area of a Circle is"+c.GetArea());
        }
    }
}