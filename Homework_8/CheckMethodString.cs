using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMetodString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = YourName();
            Console.WriteLine("Greetings, {0}!", name);

        }
        private static string YourName()
        {
            string name;
            Console.Write("Type in your name: ");
            name = string.Concat(Console.ReadLine());
            return name;

        }
    }
}

