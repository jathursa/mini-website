using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());
            if(IsDivisibleBy(x,4))
            {
                Console.WriteLine("That's even!");
            }else
            {
                Console.WriteLine("That's odd!");
            }
            /* for (int i = 0; i < 100; i++)
             {
                 Console.Write(i);
                 if (i % 3 == 0)
                 {
                     Console.Write("fizz");
                 }
                 if (i % 5 == 0)
                 {
                     Console.Write("buzz");

                 }
                 if (i % 7 == 0)
                 {
                     Console.Write("bang");
                 }
                 Console.WriteLine();
             }


             /* int magicnumber = int.Parse(Console.ReadLine());
        Console.WriteLine(magicnumber * 2);
            if (magicnumber % 2 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            */





        }
        static int timesByThree(int x)
        {
            return x * 3;
        }
        static bool IsDivisibleBy(int x, int y)
        {
            int remaider = x % y;
            return remaider == 0;
        }

    }
}
