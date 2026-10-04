using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int num;
                int sum = 0;

                Console.Write("Enter Number: ");
                num = int.Parse(Console.ReadLine());
            
                while (num != -1)
                {
                    sum = sum + num;
            
                    Console.Write("Enter Number: ");
                    num = int.Parse(Console.ReadLine());
                }
                Console.Read();

                Console.WriteLine("The total sum is {0}", sum);
                    }    
    }
}