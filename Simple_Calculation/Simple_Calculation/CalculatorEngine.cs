using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculation
{
    class CalculatorEngine
    {
        public double Calculate(double first_Number, double second_Number, string operation)
        {
            double result = 0;

            switch(operation)
            {
                case "+":
                    result = first_Number + second_Number;
                    break;
                case "-":
                    result = first_Number - second_Number;
                    break;
                case "*":
                    result = first_Number * second_Number;
                    break;
                case "/":
                    result = first_Number / second_Number;
                    break;
                default:
                    throw new InvalidOperationException("Belirtilen islem taninmadi!!");
            }
            return result;
        }
    }
}
