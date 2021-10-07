using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructors
{
    class Restaurant
    {

        public string menu;
        public int capacity;
        public bool child;
        public Restaurant(string whatIWant, int numberOfPeeps, bool isThereAChild) //Creating the class constructor for the Restaurant class with parameters - constructor 1
        {
            menu = whatIWant;
            capacity = numberOfPeeps;
            child = isThereAChild;
        }

        // Constructor method 2
        public Restaurant(int peeps)
        {
            capacity = peeps;
        }

        // Constructor method 3
        public Restaurant(string whatIWant, int numberOfPeeps)
        {
            menu = whatIWant;
            capacity = numberOfPeeps;
        }

        static void Main(string[] args)
        {
            Restaurant nandos = new Restaurant("Vegan", 2, false); // Creating a new instance of the Restaurant Class, calling the constructor, with a 'menu' of the user's choice.
            Console.WriteLine("Booking for Nandos: " + nandos.capacity + ", menu type: " + nandos.menu + ", Child seat needed? " + nandos.child);

            Restaurant wags = new Restaurant(2);
            Console.WriteLine("Booking for Wagamamas, number of guests: " + wags.capacity);
            // Output: Booking for Wagamamas, number of guests: 2
        }
    }
}
