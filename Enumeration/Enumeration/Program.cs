using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Silvermans Sachs Bank. What would you like to do today?\n1 to open an account.\n2 to check your balance.\n3 to withraw cash.");
            int userOperation = int.Parse(Console.ReadLine());
            var userAction = (UserAction)userOperation;
            switch (userAction)
            {
                case UserAction.OpenAccount:
                    RegisterNewCustomer();
                    break;
            }
        }

        // Register New Customer Method
        private static void RegisterNewCustomer()
        {
            Console.WriteLine("First Name:");
            string customerFirstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string customerLastName = Console.ReadLine();
            Console.WriteLine("EmailAddress:");
            string customerEmailAddress = Console.ReadLine();
            Console.WriteLine("What account type do you want to open?1 for Savings. 2 for Current.");
            var customerAccountType = int.Parse(Console.ReadLine());
            var customerToAdd = new Customer()
            {
                FirstName = customerFirstName,
                LastName = customerLastName,
                Email = customerEmailAddress,
                AccountType = (AccountType)customerAccountType
            };
            Console.WriteLine($"Thank you {customerToAdd.FullName} for opening an account with us today. Your details have been sent to your email - {customerToAdd.Email}.");
        }
        enum UserAction
        {
            OpenAccount = 1, // 1 assigmed to member
            CheckBalance =2, // 2 and so forth
            Withdraw =3  // 3
        }
        class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName => $"{FirstName} {LastName}";
            public string Email { get; set; }
            public AccountType AccountType { get; set; }
            public decimal AccountBalance { get; set; } = 0;

        }
        enum AccountType
        {
            Saving = 1, // 1
            Current = 2, // 2
        }
    }
}

