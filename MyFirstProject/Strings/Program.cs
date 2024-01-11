using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Go to your c:\\ drive";  //Using escape "\" character
            //string myString = "My \"so called\" life";
            //string myString = "What if i need \n a new line";  //new line character

            //string myString = string.Format("{0}", "Bonzai");
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760l1");

            //string myString = string.Format("{0:C}", 123.45); // Special character format

            //string myString = string.Format("{0:N}", 123456789); //Currency format with 2 decimal

            //string myString = string.Format("{0:P}", .123); // percentage format

            string myString = string.Format("Phone number: {0:(###) ####-####}", 23481669454); //custom format

            Console.WriteLine(myString);

            /* string myString2 = "";

             for (int i = 0; i < 100; i++)
             {
                 myString2 += "--" + i.ToString();
             }
             */

            // More effecient concatenation

            /*StringBuilder myString2 = new StringBuilder();

            for (int i = 0; i < 100; i++)   
            {
                myString2.Append("--");
                myString2.Append(i);
            }
            */


            string myString2 = "That summer we took threes accross the board  ";

            //String slicing
            //myString2 = myString2.Substring(5, 14);

            // To UpperCase
            //myString2 = myString2.ToUpper();

            //Replace character
            //myString2 = myString2.Replace(" ", "--");

            myString2 = string.Format("Length before: {0} -- After: {1}", myString2.Length, myString2.Trim().Length);

            Console.WriteLine(myString2.ToString());
            Console.ReadLine();
        }
    }
}
