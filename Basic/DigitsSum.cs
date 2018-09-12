using System;
using System.Text;

namespace Basic
{
    public class DigitsSum
    {
        public string SumDigits(string digits)
        {
            int[] numbers = GetNumbers(digits);
            int sumResult = SumNumbers(numbers);
            return PrintResult(numbers, sumResult);
        }

        public string PrintResult(int[] numbers, int sumResult)
        {
            if(numbers.Length == 0) return "";

            StringBuilder result =  new StringBuilder();
            for(int number = 0; number < numbers.Length; number++)
            {
                if(number == numbers.Length-1)
                {
                    result.Append(numbers[number]);
                }
                else
                {
                    result.Append(numbers[number] + " + ");
                }
            }

            return result.Append(" = " + sumResult).ToString();
        }

        public int SumNumbers(int[] numbers)
        {
            int result = 0;
            foreach(int number in numbers)
            {
                result += number;
            }
            return result;
        }

        public int[] GetNumbers(string digits)
        {
            int[] result = new int[digits.Length];
            int counter = 0;
            if(!digits.Equals("-1"))
            {
                foreach (var ch in digits) 
                {
                    result[counter] = Int32.Parse(ch.ToString());
                    counter++;
                }
                return result;
            }
            else
            {
                return new int[]{};
            }
        }
    }
}