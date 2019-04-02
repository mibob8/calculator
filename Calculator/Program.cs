using System;
using System.Collections.Generic;
using System.IO;
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

            Console.WriteLine($@"Your result is {calculationResult}.");
            Console.ReadKey();

        }

        private static double Calculate(string parametersFile)
        {
            double result;

            var parameters = File.ReadAllText(parametersFile).ToUpper().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            double.TryParse(parameters.Where(n => n.Contains("BASE")).First().Replace("BASE", ""), out result);

            foreach (var parameter in parameters.Where(n => !n.Contains("BASE")))
            {
                var operationName = parameter.Split(' ')[0].Trim(); 
                var operationValue = Convert.ToDouble(parameter.Split(' ')[1].Trim());  
                 
                switch (operationName)
                {
                    case "DIVIDE":
                        result /= operationValue;
                        break;
                    case "MULTIPLY":
                        result *= operationValue;
                        break;
                    case "ADD":
                        result += operationValue;
                        break;
                    case "MINUS":
                        result -= operationValue;
                        break;
                } 
            } 

            return result;
        }  
    }
}
