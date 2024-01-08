using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            */
            // Console.WriteLine(numbers[1].ToString());


            //Single line initialization
            // int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            /*
             * for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Array element is {0}", numbers[i]);
            }
            */


            /*
            //Any dataType array
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David" };

            //foreach loop
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            */

            string zig = "You can get what you want out of life if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
                //Console.WriteLine(zigChar);
            }

            Console.ReadLine();
        }
    }
}
