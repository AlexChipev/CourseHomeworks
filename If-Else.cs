using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number from 1 to 9: ");
            int number = int.Parse(Console.ReadLine());
            {
                if (number == 1) 
                {
                    Console.WriteLine("You have 5 points");
                }
                {
                    if (number == 2)
                    {
                        Console.WriteLine("You have 10 points");
                    }
                    {
                        if (number == 3)
                        {
                            Console.WriteLine("You have 15 points");
                        }
                        {
                            if (number == 4)
                            {
                                Console.WriteLine("You have 40 points");
                            }
                            {
                                if (number == 5)
                                {
                                    Console.WriteLine("You have 50 points");
                                }
                                {
                                    if (number == 6)
                                    {
                                        Console.WriteLine("You have 60 points");
                                    }
                                    {
                                        if (number == 7)
                                        {
                                            Console.WriteLine("You have 350 points");
                                        }
                                        {
                                            if (number == 8)
                                            {
                                                Console.WriteLine("You have 400 points");
                                            }
                                            {
                                                if (number == 9)
                                                {
                                                    Console.WriteLine("You have 450 points");
                                                }
                                                else if (number > 9)
                                                {
                                                
                                                Console.WriteLine("Error: Please enter a number from 1 to 9");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
}
 