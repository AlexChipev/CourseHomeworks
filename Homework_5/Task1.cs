using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която отпечатва на конзолата числата от 1 до N. Числото N се въвежда от конзолата.
            Console.Write("Please enter a number and hit enter: ");
            int n = int.Parse(Console.ReadLine());
            int number = 0;
   
            do
            {
                if (number <= n) ;
                Console.WriteLine(number);
                number++;
   
            } while (number <= n);
        }
    }
}
