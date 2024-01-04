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
            /*
            Console.WriteLine("Please type something and press the Enter key.");
            string userValue;
            userValue = Console.ReadLine();
            Console.WriteLine("You typed: " + userValue);
            */

            Console.WriteLine("Would you prefer what is behing door number 1, 2, or 3?");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                Console.WriteLine("You won a new car!");
                Console.ReadLine();
            }
            else if (userValue == "2")
            {
                Console.WriteLine("You won a new bag!");
                Console.ReadLine();
            }
            else if (userValue == "3")
            {
                Console.WriteLine("You won a new boat!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                Console.ReadLine();
            }
           
        }
    }
}
