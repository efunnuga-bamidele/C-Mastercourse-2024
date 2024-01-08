using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = superSecretFormula();
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string superSecretFormula()
        {
            string name = greetMe("Bamidele");
            // some cool stuff here
            return String.Format("{0}, Hello World!", name);
        }

        private static string greetMe(string name)
        {
            return String.Format("Hello, {0}", name);
        }
    }
}
