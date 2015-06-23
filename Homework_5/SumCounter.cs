using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            {

                do
                {

                    Console.Write("Please enter a number and press enter: ");
                    number1 = int.Parse(Console.ReadLine());
                    {
                        Console.Write("Please enter a second number and press enter: ");
                        number2 = int.Parse(Console.ReadLine());
                        {
                            Console.WriteLine(number1 + number2);
                        } 
                    }
                } while (number1 > 0);

            }
        }
    }
}
