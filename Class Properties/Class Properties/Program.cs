using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Properties
{
    class Item
    {
        // Auto-implemented property
        public string Name { get; set; } //this maintains encapsulation - read AND write
       // public int Secret { set; } //write only
        // field
        private DateTime _manufacturedDate; //{ get; } <-- when this is in code, line 19 shows an error. read only

        // getters and setters for field
        public DateTime GetManufacturedDate() { return _manufacturedDate; }
        public void SetManufacturedDate(DateTime date) { this._manufacturedDate = date; }
    }

    class TimePeriod
    {
        private double _seconds;

        public double Hours
        {
            // Example: 7200 / 3600 = 2 Hours
            get { return _seconds / 3600; } //returns the value of the private field divided by the number of seconds in an hour

            set //setter method can have instructions - will run a conditional validation to ensure the passed in value is in a specific range before setting the result
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be between 0 and 24.");

                // Example: 2 * 3600 = 7200 Seconds
                _seconds = value * 3600;
            }
        }
    }

    public class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }

        public string Name => $"{_firstName} {_lastName}";

        public string Forename
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string Surname
        {
            get => _lastName;
            set => _lastName = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var item = new Item { Name = "Apple" };
            Console.WriteLine($"I have an {item.Name}");
        }
    }
}
