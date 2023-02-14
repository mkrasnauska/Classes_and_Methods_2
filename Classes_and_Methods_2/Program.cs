using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment2
{
    class Program
    {
        public static void Main()
        {
            int x = Math.MySumInt(399);
            Console.WriteLine("399 +optional value = " + x);
            Console.WriteLine("Please type in a first number ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type in second Number (optional)");

            string n = Console.ReadLine();
            if (n == "")
            {
                int y = Math.MyTimesInt(m);
                Console.WriteLine("result: " + y);
                Console.ReadLine();


            }
            else
            {

                int y = Math.MyTimesInt(m, Convert.ToInt32(n));
                Console.WriteLine("result: " + y);
                Console.ReadLine();
            }
        }
    }
}