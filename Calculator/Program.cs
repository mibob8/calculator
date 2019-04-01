using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the location of the text file with parameters and press any key");
            var parametersFile = Console.ReadLine();

            var calculationResult = Calculate(parametersFile);

            Console.WriteLine($@"Your result is {calculationResult}");
            Console.ReadKey();

        }

        private static double Calculate(string parametersFile)
        {
            double result;








            return result;
        }





    }
}
