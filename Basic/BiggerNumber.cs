using System;

namespace Basic
{
    public class BiggerNumber
    {
        public double getBiggerNumber(double number1, double number2)
        {
            // compare if number 1 is greater then number 2
            if(number1 >= number2)
            {
                // if number 1 is greater then return number 1
                return number1;
            }
            else
            {
                // if not return number 2 
                return number2;
            }
        }
    }
}