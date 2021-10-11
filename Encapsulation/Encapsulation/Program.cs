using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{//The point of this is to make variables private so that the values of the variables have restricted access, only allowing access through the methods of their current class. We can then have read-only access using getters and write-only access using setters.
 //This allows us to have more flexible code, we are able to prevent or permit read or write access to certain variables.
    public class CarShowRoom
    {

        // Declares private variable
        private string carName;

        // Make use of accessors and then getters and setters
        public string Name
        {
            get
            {
                return carName;
            }

            set
            {
                carName = value;
            }

        }
    }

    class Ex
    {

        static public void Main()
        {
            CarShowRoom obj = new CarShowRoom();

            // Passes a name through the accessor
            obj.Name = "Nissan GTR";

            Console.WriteLine("Name: " + obj.Name);
        }
    }
}
