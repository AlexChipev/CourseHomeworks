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
            for (int i = 10; i <= 999; i++)
            {
                SimmetricNumbers(i);  
            }
        }

        private static int SimmetricNumbers(int simmetrical)
        {

            {
                if (simmetrical % 11 == 0 && simmetrical <= 99)
                   
                Console.WriteLine("Simmetrical: {0}", simmetrical);

                if (simmetrical % 101 == 0 && simmetrical >= 100 && simmetrical <= 999)
                 
                Console.WriteLine("Simmetrical: {0}", simmetrical);
                return simmetrical;

            }
        } 
            } 
        }
    

