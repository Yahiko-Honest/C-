using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputCoverter inputConverter = new InputCoverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double first_Number = inputConverter.ConvertTheInput(Console.ReadLine());
                string operation = Console.ReadLine();
                double second_Number = inputConverter.ConvertTheInput(Console.ReadLine());


                double result = calculatorEngine.Calculate(first_Number, second_Number, operation);

                Console.WriteLine("Sonuc: " + result);
            }

            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            };
            Console.ReadLine();
        }
        
    }
}
