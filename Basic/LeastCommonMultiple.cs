using System;
using System.Collections.Generic;

namespace Basic
{
    public class LeastCommonMultiple
    {
        public double Find(double number1, double number2, double number3)
        {
            List<double> numbers = createOrderedListOfNumbers(number1, number2, number3);


            return 23;
        }

        public List<double> createOrderedListOfNumbers(double number1, double number2, double number3)
        {
            List<double> numbers = new List<double>(){ number1, number2, number3 };

            foreach(double number in numbers)
            {

            }

            return numbers;
        }
    }
}