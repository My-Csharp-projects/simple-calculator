using System;

namespace simple_calculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;

            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Please enter a numeric value");

            return convertedNumber;
        }
    }
}
