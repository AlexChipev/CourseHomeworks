using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some number between 2 and 9: ");
            int n = int.Parse(Console.ReadLine());

            int result = n * n;
            Console.WriteLine();
            Console.WriteLine("Your array is with " + result + " elements length" );
            int[] arr = new int[result];

            Console.WriteLine("Please enter " + result + " values: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int ArrSum = 0;
  
            foreach (int item in arr)
            {
                ArrSum += item;
            }
            Console.WriteLine();
            Console.WriteLine("Array elements sum is: {0}", ArrSum);

            int counter = 0;
            int [,] matrix = new int [n,n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = arr[counter++];
                }

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            }
        }
    }
