using System;

namespace maths
{
    public class Calculator
    {
        public int Add (int number1, int number2)
        {

            if(number1 == 0 || number2 == 0)
                throw new ArgumentNullException("unexpected value");

            var result = number1 + number2;

            return result;
        }
    }
}
