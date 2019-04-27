/******************************************************************************

ArsaApplication-euro-tl-zl

*******************************************************************************/
using System;

namespace ArsaApplication
{
    class Arsa
    {

        //member variables
        protected double length;
        protected double width;

        public Arsa(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle  
    class Arsacost: Arsa
    {
        private double cost1,cost2,cost3;
        public Arsacost(double l, double w) : base(l, w) { }

        public double PriceofArsa1()
        {

            

            return  cost1 = (GetArea() * cost1)/6.53 ;
        
        }

        public double PriceofArsa2()
        {

           
            return  cost2 = (GetArea() * cost2) / 1.53;

        }

        public double PriceofArsa3()
        {


            return cost3 = (GetArea() * cost3);

        }


        public void setCost(double c)
        {
            cost1 = c;
            cost2 = c;
            cost3 = c;
        }
        /*public double getCost()
        {
            return cost;
        }*/

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost1: {0} euro", PriceofArsa1());
            Console.WriteLine("Cost2: {0} zloty", PriceofArsa2());
            Console.WriteLine("Cost3: {0} turkish liras", PriceofArsa3());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Arsacost t = new Arsacost(20,15);
            t.setCost(3000);
            t.Display();
            Console.ReadLine();
        }
    }
}
