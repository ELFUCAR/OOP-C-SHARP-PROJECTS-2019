/*-----------------------------------
 
 PolymorphismApplication-Shape-Rectangle-Rombe

 -----------------------------------*/
using System;

namespace PolymorphismApplication
{
    abstract class Shape
    {
        public abstract int area();
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }

    }

        class Rombe :Shape
        {
            private int length;
            private int heigth;

            public Rombe(int l = 0, int h = 0)
            {
                length = l;
                heigth = h;
            }
            public override int area()
            {
                Console.WriteLine("Rombe class area :");
                return (heigth * length);
            }
        }


    
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);


            Rombe r1 = new Rombe(8,5);
           double a1 = r1.area();
            Console.WriteLine("Area: {0}", a1);



            Console.ReadKey();
        }
    }
}