using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simetrical
{
    class Program
    {
        static void Main(string[] args)
        {
          // int[] arr = new int[999];
            //for (int i = 10; i <= 999; i++)
            {
                for (int i = 10; i < 999; i++)
                    SimmetricNumbers(i);
            }
        }

        private static void SimmetricNumbers(int simmetrical)
        {


            int[] array = new int[999];
            array[0] = array.Length;
            array[1] = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                simmetrical = array[i];
            }
                if (array[0] == array[1])

                    Console.WriteLine(simmetrical);
            
                }
     
            }
        }
