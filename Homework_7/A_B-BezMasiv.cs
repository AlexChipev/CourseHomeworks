using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_B
{
    class Program
    {
        static void Main(string[] args)
        {//Напишете програма, която приема от конзолата 2 числа a и b (b > a) и 
            //изкарва на екрана всички числа от a до b, които се делят на 3 без остатъk
            Console.WriteLine("Enter two integers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Result:");
            for (int i = 0; i >= a; i++)
            {

                if (i % 3 == 0 && i >= b)
                
                Console.WriteLine(i);
            }
      
            {
                for (int j = 0; j <= b; j++)
                {
                    if (j % 3 == 0 && j >= a)

                    Console.WriteLine(j);
                }
            }
           
        }
    }
}
