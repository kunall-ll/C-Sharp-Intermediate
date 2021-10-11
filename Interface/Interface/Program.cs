using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
//An interface is an abstract class so it can only contain abstract methods and properties with empty bodies
{    // This is the interface we will be implementing.
    public interface ITransactions //starts off with an I so it is easy to remember that it is an interface
    {
        // interface members
        void showTransaction();
        double getAmount();
    }

    // This is the class which implements our interface
    public class Transaction : ITransactions //transaction implements the transactions interface
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction() //body of show transaction written here
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
        class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
        }
    }
}
}
