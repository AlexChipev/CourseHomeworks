using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
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
                    Console.WriteLine("You have: " + 1 * 5 + " points");
                }
                if (number == 2)
                {
                    Console.WriteLine("You have: " + 2 * 5 + " points");
                }
                if (number == 3)
                {
                    Console.WriteLine("You have: " + 3 * 5 + " points");
                }
                {
                if (number == 4)
                    {
                    Console.WriteLine("You have: " + 4 * 10 + " points");
                    }
                    {
                    if (number == 5)
                        {
                            Console.WriteLine("You have: " + 5 * 10 + " points");
                        }
                        {
                            if (number == 6)
                            {
                                Console.WriteLine("You have: " + 6 * 10 + " points");
                            }
                            {
                                if (number == 7)
                                {
                                    Console.WriteLine("You have: " + 7 * 50 + " points");
                                }
                                {
                                    if (number == 8)
                                    {
                                        Console.WriteLine("You have: " + 8 * 50 + " points");
                                    }
                                    {
                                        if (number == 9)
                                        {
                                            Console.WriteLine("You have: " + 9 * 50 + " points");
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

