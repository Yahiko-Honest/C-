using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculation
{
    class InputCoverter
    {
        public double ConvertTheInput(string arg_TextInput)
        {
            double int_Return;

            if (!double.TryParse(arg_TextInput, out int_Return)) throw new ArgumentException("Sayi bekleniyor!! ");

            return int_Return;
        }
    }
}
