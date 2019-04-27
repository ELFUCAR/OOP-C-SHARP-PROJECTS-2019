/*----------------------------------

PolymorphismApplication-Rectangle-Trapeze

------------------------------*/

using System;

namespace PolymorphismApplication
{
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }

    class Trape : Shape
    {  private int side;
        public Trape(int a = 0, int b = 0,int s=0) : base(a, b)
        {
            side = s;

        }
        public override int area()
        {
            Console.WriteLine("Trape class area :");
            return (((width + height)*side/2));
        }
    }

    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            Trape t1 = new Trape(12,8,10);

            c.CallArea(r);
            c.CallArea(t);
            c.CallArea(t1);
            Console.ReadKey();
        }
    }
}