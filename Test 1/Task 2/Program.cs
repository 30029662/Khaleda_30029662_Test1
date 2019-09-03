using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            for(int i=1;i<=5;i++)
            {
                Console.Write($"Enter the price of item {i}: ");
                total = total + double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The total of those items is: ${total}");
            Console.ReadLine();
        }
    }
}
