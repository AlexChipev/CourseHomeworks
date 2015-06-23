using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname, fullname;
            { 
                Console.Write("Please type in firstname: ");
            firstname = Console.ReadLine();

            Console.Write("Please type in lastname: ");
            lastname = Console.ReadLine();

            fullname = String.Concat(firstname + " " + lastname);
            Console.WriteLine(fullname);
            }
        }
    }
}
