using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type something and press the Enter key.");
            string userValue;
            userValue = Console.ReadLine();
            Console.WriteLine("You typed: " + userValue);
            Console.ReadLine();
        }
    }
}
