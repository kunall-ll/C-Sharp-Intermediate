using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{//Delegates are used to pass methods as arguments to other methods, they are object-oriented, type safe, and secure.
    public delegate void exDel(string msg);

    class Del
    {
        static void Main(string[] args)
        {

            exDel del = Ex1.Message1;
            del("Hello World");

            del = Ex2.Message2;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");

        }
    }

    class Ex1
    {

        internal static void Message1(string message)
        {
            Console.WriteLine("Called Ex1.Message1() with parameter: " + message);
        }
    }

    class Ex2
    {
        internal static void Message2(string message)
        {
            Console.WriteLine("Called Ex2.Message2() with parameter: " + message);
        }
    }

}
