/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

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
        private double cost;
        public Arsacost(double l, double w) : base(l, w) { }

        public double PriceofArsa()
        {
           
          return  cost = GetArea() * cost;
        
        }

        public void setCost(double c)
        {
            cost = c;
        }
        /*public double getCost()
        {
            return cost;
        }*/

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", PriceofArsa());
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