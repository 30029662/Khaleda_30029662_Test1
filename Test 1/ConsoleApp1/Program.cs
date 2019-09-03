using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the value of base: ");
            double bese = double.Parse(Console.ReadLine());
            Console.Write("please enter the value of exponent: ");
            int power = int.Parse(Console.ReadLine());
            double result;
            result = Math.Pow(bese, power);



            Console.WriteLine($" bese^power = {result} ");
            Console.ReadLine();
        }
    }
}
