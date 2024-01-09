using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 12;
            int z = 27;
            int answer = 0;

            // Addition Operator
            answer = x + y + z;
            Console.WriteLine("Sum of three numbers is {0}", answer);

            // Subtraction Operator
            answer = z - y - x;
            Console.WriteLine("Subtraction ofthe three numbers is {0}", answer);

            // Multiplication Operator
            answer = y * x;
            Console.WriteLine("Multiplication of x and y is {0}", answer);

            // Division Operator
            answer = z / y;
            Console.WriteLine("Division of z by y is {0}", answer);

            //Modulus Operator
            answer = z % y;
            Console.WriteLine("Remainder of z divided by y is {0}", answer);

            // Comparator Operator

            Console.WriteLine("Is x equal to y {0}", x == y);

            Console.WriteLine("Is y greater than z {0}", y > z);

            Console.ReadLine();
        }
    }
}
