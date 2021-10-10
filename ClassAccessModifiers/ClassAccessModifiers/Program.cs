using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAccessModifiers
{
    class CarClass
    {
        
        //We use access modifiers in order to control the visibility of class members. We call this Encapsulation - this prevents direct access to data that might be considered sensitive.
         //If a method or variable is marked as private, then only code inside the same class can access the variable, or call the method. Code inside the subclasses cannot access the variable or method, nor can code from any external class.
        private string model = "Mustang";
        //The public access modifier allows all other code in the program to access the resource, irrespective of location:
        public string Model = "Nissan";
        //Note protected
        protected string Model1 = "Tesla";
        static void Main(string[] args)
        {
            CarClass Ford = new CarClass();
            Console.WriteLine(Ford.model); //If you try to access a private class member outside of the class, an error will occur.
            var car = new CarClass();
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Model1); //accessible from within the same class
        }

        

    }
}

