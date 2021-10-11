using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{//process of hiding details of a program's implementation details from other classes or methods.
 //Abstraction is the process of hiding details.
 //While encapsulation is the process of hiding data.
    abstract class Shapes
    { //this is an abstract method
        public abstract int area();
    }
    class Rectangle : Shapes
    {

        private int side;

        // method of  Rectangle class 
        public Rectangle(int x = 0)
        {
            side = x;
        }

        // Using override keyword to override class
        public override int area()
        {
            Console.WriteLine("Area of Rectangle: ");
            return (side * side);
        }
    }

    class S
    {

        static void Main(string[] args)
        {
            // Referencing Shapes class to refer to rectangle instance
            Shapes sh = new Rectangle(4);

            double result = sh.area();

            Console.Write("{0}", result);
        }
    }
}
