using System;

public class ATM
{
    public int balance;
    public string[] history = new string[100];
    public int count = 0;

    public ATM(int b)
    {
        balance = b;
    }

    public void deposit(int amount)
    {

        balance = balance + amount;

        history[count] = "Deposit: " + amount;
        count++;
    }

    public void withdraw(int amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;

            history[count] = "Withdrawal: " + amount;
            count++;
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public void check_balance()
    {
        Console.WriteLine("Balance: "+balance);
    }

    public void transaction_history()
    {
        Console.WriteLine("Transaction History:");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(history[i]);
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        ATM atm = new ATM(10000);

        atm.deposit(2000);
        atm.withdraw(3000);
        atm.check_balance();
        atm.withdraw(15000);
        atm.transaction_history();
    }
}