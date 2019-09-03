using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2(x – 3) + x = 12
                 2x -6 + x = 12
                 3x -6 = 12
                 3x = 12 + 6
                 3x = 18
                 x = 6
                 */
            int x = 6;
            Console.Write("Enter your guess at the value of x: ");
            int guess = int.Parse(Console.ReadLine());
            if(guess!=x)
            {
                Console.WriteLine("Your guess is correct");
            }
            else
            {
                Console.WriteLine("sorry that guess is incorrect");
            }
            Console.ReadLine();

        }
    }
}
