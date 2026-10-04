using System;

namespace task
{
    public class transaction
    {
        public int ID;
        public string Prod_name;
        public int Amount;
        public string Date;
        public string Time;

        public transaction(int id, string prod_name, int amount, string date, string time)
        {
            ID = id;
            Prod_name = prod_name;
            Amount = amount;
            Date = date;
            Time = time;
        }

        public void Display()
        {
            Console.WriteLine("Transaction ID: " + ID);
            Console.WriteLine("Product Name: " + Prod_name);
            Console.WriteLine("Amount: " + Amount);
            Console.WriteLine("Date: " + Date);
            Console.WriteLine("Time: " + Time);
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            transaction t1 = new transaction(001, "bat", 1500, "03-03-2025", "10:30 PM");

            // Copy transaction
            transaction t2 = new transaction(001, "bat", 1500, "03-03-2025", "10:30 PM");

            // Displaying before changes
            Console.WriteLine("BEFORE CHANGES");

            Console.WriteLine("Transaction 1:");
            t1.Display();

            Console.WriteLine("Transaction 2:");
            t2.Display();

            // Making changes separately
            t1.Prod_name = "bowl";
            t1.Amount = 500;

            t2.ID = 002;
            t2.Date = "08-08-2025";

            Console.WriteLine("AFTER CHANGES");

            Console.WriteLine("Transaction 1:");
            t1.Display();

            Console.WriteLine("Transaction 2:");
            t2.Display();
        }
    }
}