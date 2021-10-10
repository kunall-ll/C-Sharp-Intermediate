using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{//provides the ability for the classes to implement different methods that are called through the same name and it provides an ability to invoke the methods of a derived class through base class references during runtime
    
    
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Piggy says oink");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Pupper says woooof");
        }
    }

    class Whale : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("eeeeeeeeeeeeeeeee");
        }
    }
    class Runner
    {
        static void Main()
        {
            Animal animal = new Animal(); // Creates an animal object
            Animal piggy = new Pig(); //creates the piggy, which is an animal object 
            Animal puppy = new Dog(); //creates the dog, which is an animal object 
            Animal whale = new Whale(); //creates the whale, which is an animal object 

            animal.animalSound();
            piggy.animalSound();
            puppy.animalSound();
            whale.animalSound();
        }
    }
}
