using System;

public class calculator
{
    public int num1;
    public int num2;

    public calculator(int a, int b)
    {
        num1 = a;
        num2 = b;
    }

    public void add()
    {
        Console.WriteLine(num1 + num2);
    }

    public void sub()
    {
        Console.WriteLine(num1 - num2);
    }

    public void prod()
    {
        Console.WriteLine(num1 * num2);
    }

    public void div()
    {
        Console.WriteLine(num1 / num2);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first num: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the sec num: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Function to be performed: ");
        char opr = Convert.ToChar(Console.ReadLine());

        calculator calc = new calculator(num1, num2);

        if (opr == '+')
        {
            calc.add();
        }
        else if (opr == '-')
        {
            calc.sub();
        }
        else if (opr == '*')
        {
            calc.prod();
        }
        else if (opr == '/')
        {
            calc.div();
        }
        else
        {
            Console.WriteLine("Invalid operator");
        }
    }
}