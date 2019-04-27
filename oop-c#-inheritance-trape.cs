/******************************************************************************
InheritanceApplication-trape(yamuk)

*******************************************************************************/
using System;

namespace InheritanceApplication
{
    class Shape
    {
        public void setLong(int l)
        {
            longs = l;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        public void setShort(int s)
        {
            shorts = s;
        }

        protected int longs;
        protected int shorts;
        protected int height;
    }

    // Derived class
    class Trape : Shape
    {
        public int getArea()
        {
            return (((longs + shorts)*height)/2);
        }
    }
    class TrapeTester
    {
        static void Main(string[] args)
        {
            Trape Tra = new Trape();

            Tra.setHeight(7);
            Tra.setShort(7);
            Tra.setLong(10);


            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Tra.getArea());
            Console.ReadKey();
        }
    }
}