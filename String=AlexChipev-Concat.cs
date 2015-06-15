using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, fullName;
            firstName = "Alex";
            lastName = "Chipev";
            fullName = String.Concat(firstName + "_" + lastName);
            Console.WriteLine(fullName);
        }
    }
}
