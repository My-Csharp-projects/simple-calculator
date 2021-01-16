using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;

            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Please enter a numeric value");

            return convertedNumber;
        }
    }
}
