using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Assign1
{

    abstract class GeometricSymbols
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Square : GeometricSymbols
    {
        public int a;
        public Square(int a)
        {
            this.a = a;
        }
        public override double Area()
        {
            return a * a;
        }
        public override double Perimeter()
        {
            return 4 * a;
        }
    }
    class Rectangle : GeometricSymbols
    {
        public int l;
        public int b;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }

        public override double Area()
        {
            return l * b;
        }

        public override double Perimeter()
        {
            return 2 * (l + b);
        }
    }

    class Triangle : GeometricSymbols
    {
        public int h;
        public int b;
        public int l;

        public Triangle(int h, int b, int l)
        {
            this.h = h;
            this.b = b;
            this.l = l;
        }

        public override double Area()
        {
            return (int)(0.5 * h * b);
        }

        public override double Perimeter()
        {
            return (2 * l) + b;
        }
    }

    abstract class RoundShape
    {
        public abstract double Area();
    }

    class Circle : RoundShape
    {
        public int r;

        public Circle(int r)
        {
            this.r = r;
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }
    }

    class Oval : RoundShape
    {
        public int r;
        public int b;

        public Oval(int r, int b)
        {
            this.r = r;
            this.b = b;
        }

        public override double Area()
        {
            return Math.PI * r * b;
        }
    }

    class Test
    {

        public static void Main(string[] args)
        {
            Square s1 = new Square(2);
            Console.WriteLine("Area of Square is : " + s1.Area());
            Console.WriteLine("Perimeter of Square is : " + s1.Perimeter());

            Rectangle r1 = new Rectangle(2, 3);
            Console.WriteLine("Area of Rectangle is : " + r1.Area());
            Console.WriteLine("Perimeter of Rectangle is : " + r1.Perimeter());

            Triangle t1 = new Triangle(5, 4, 2);
            Console.WriteLine("Area of Triangle is : " + t1.Area());
            Console.WriteLine("Perimeter of Triangle is : " + t1.Perimeter());

            Circle c1 = new Circle(3);
            Console.WriteLine("Area of Circle is : " + c1.Area());

            Oval oval1 = new Oval(3, 2);
            Console.WriteLine("Area of Oval is : " + oval1.Area());


        }
    }
}

