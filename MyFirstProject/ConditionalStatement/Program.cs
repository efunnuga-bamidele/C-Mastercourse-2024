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

            string message = "";
            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                message = "You won a new bag!";
            }
            else if (userValue == "3")
            {
                message = "You won a new boat!";
               
            }
            else
            {
                message = "Sorry, we didn't understand. You loose!";
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
