using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try //this simply provides a scope that can run code, here we can anticipate Exceptions that might be thrown and place them within the try block
            {
                throw new Exception("Generic Exception thrown!");
            }
            catch (Exception e) //this uses the catch keyword in conjunction with a parameter for the expected exception. When an exception is thrown, you can use the scope of the catch block to print out or otherwise handle the exception.
            {
                Console.WriteLine(e);
            }

            finally //ensures that success or failure, the code will still perform a certain action before continuing further execution of the program
            {
                Console.WriteLine("Exception has been thrown, closing resources...");

                // pseudo code, close resources
                Console.WriteLine("Resources have been successfully closed.");
            }

            void methodException() 
            {
                throw new Exception("Generic Exception thrown!"); //Announces to the compiler to anticipate a new exception
            }


            try
            {
                Console.WriteLine(divide(10, 0));//would usually give a scary error since you can't divide by 0
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("You can't divide by zero you numpty, now look at this: " + ex.Message);
            }
            finally { Console.WriteLine("Hello World"); } //I need this to run regardless of the error

        }

        private static int divide(int num1, int num2)
        {
            int num3 = (num1 / num2);
            return num3;
        }
    }
}
