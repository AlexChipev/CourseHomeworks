using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            int index, counter, smallest, largest;
            smallest = 0;
            largest = 0;

            Console.WriteLine("How many numbers will you enter?");
            index = Convert.ToInt32(Console.ReadLine());


            for (counter = 1; counter <= index; counter++)
            {
                Console.WriteLine("Please enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (counter == 1)
                {
                    smallest = number;
                    largest = number;
                }
                else
                {
                    if (number > largest)
                    
                        largest = number;
                    
                    else if (number < smallest)    
                    
                        smallest = number;               
                }        
            }
            Console.WriteLine("The smallest and the largest numbers are: " + smallest + " " + largest);
            Console.ReadLine();
        }
    }
}