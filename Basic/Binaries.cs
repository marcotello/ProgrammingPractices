using System;
using System.Collections.Generic;

namespace Basic
{
    public class Binaries
    {
        public int GetMaximun(int originalNumber)
        {
            int[] convinations = GetConvinations(originalNumber);
            return GetMaximunValue(convinations);
        }

        public int GetMaximunValue(int[] convinations)
        {
            Array.Sort(convinations);
            return convinations[convinations.Length-1];
        }

        public int[] GetConvinations(int originalNumber)
        {
            if(originalNumber == 1)
            { 
                return new int[]{ 1 };
            }

            double half = originalNumber / 2;
            List<int> values = new List<int>();
            int secondNumber = 0;

            for(int i = originalNumber; i >= Math.Truncate(half); i--)
            {
                secondNumber = originalNumber - i;
                values.Add(GetTotalOfOnes(i, secondNumber));
            }

            return values.ToArray();
        }

        public int GetTotalOfOnes(int firstNumber, int secondNumber)
        {
            string binary = Convert.ToString(firstNumber, 2);
            binary = binary + Convert.ToString(secondNumber, 2);
            char[] chars = binary.ToCharArray();
            int result = 0;

            foreach(int character in chars)
            {
                if(character == '1')
                {
                    result+=1;
                }
            }
            return result;
        }
    }
}