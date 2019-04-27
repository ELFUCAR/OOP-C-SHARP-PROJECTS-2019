/*--------------------------

 OperatorOvlApplication-Vector
 
 ---------------------------*/

using System;

namespace OperatorOvlApplication
{
    class Vector
    {
        public double x;   // X of a Vector
        public double y;  // Y of a Vector
         

        public void setX(double px)
        {
            x = px;
        }
        public void setY(double py)
        {
            y = py;
        }
        

        // Overload + operator to add two Vector objects.
        public static Vector operator +(Vector b, Vector c)
        {
            Vector Vector = new Vector();

            Vector.x = b.x + c.x;
            Vector.y = b.y + c.y;
           
            return Vector;
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Vector u = new Vector();   // Declare Vector1 of type Vector
            Vector v = new Vector();   // Declare Vector2 of type Vector
            Vector t = new Vector();   // Declare Vector3 of type Vector
           

            // Vector 1 specification
            u.setX(6.0);
            u.setY(7.0);
     
            v.setX(12.0);
            v.setY(13.0);

            t = u + v;
          
            Console.WriteLine("Vector t : {0} {1} ", t.x ,t.y);
            Console.ReadKey();
        }
    }
}