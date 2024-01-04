using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Data Types
 * and Variable Declaration
 * in C#
 */

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 7;
             int y = x + 3;
             Console.WriteLine(y);
             */


            // string myFirstName = "Bamidele";
            /* var myFirstName = "Bamidele";  //self assigned data type
            Console.WriteLine(myFirstName);
            */

            //Data Type Conversion

            int x = 7;
            string y = " Oranges";
            string myFirstConversion = x.ToString() + y; //Implicit Conversion

            string z = "5";

            int mySecondConversion = x + int.Parse(z); //Explicit Conversion

            Console.WriteLine(myFirstConversion);
            Console.WriteLine(mySecondConversion);


            Console.ReadLine();

        }
    }
}
