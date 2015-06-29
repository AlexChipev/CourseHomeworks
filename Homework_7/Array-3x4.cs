using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която позволява на потребителя да попълва масив с размери 3х4. Изведете масива на екрана.

            Console.WriteLine("Enter 12 numbers: ");
            
            int[,] matrix = new int[3, 4];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   
                    {
                        Console.Write("Enter a number: ");
                    }
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }

                {
                    
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("\t" + matrix[i,j]);
                }
                    Console.WriteLine();
            {
                
            }
        }
    }
}