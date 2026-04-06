using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphanumeric_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputString = ("11603529");
            int sum = 0;
            foreach (char c in inputString)
            {
                if (char.IsDigit(c))
                {
                    sum += int.Parse(c.ToString());
                }
            }
            Console.WriteLine("The sum of digits in the string is: " + sum);
        }
    }
}
