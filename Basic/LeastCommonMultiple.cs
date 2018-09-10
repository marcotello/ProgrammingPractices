using System;
using System.Collections.Generic;

namespace Basic
{
    public class LeastCommonMultiple
    {
        public double Find(double number1, double number2, double number3)
        {
            double[] numbers = createOrderedArrayOfNumbers(number1, number2, number3);

            List<int> multipliers = new List<int>();
            double factor = 0;
            int counter = 0;
            int divisible = 2;

            for(int i = 0; i <= numbers.Length; i++)
            {
                factor = numbers[i];
                while(factor >= 1)
                {
                    if(factor % divisible == 0)
                    {
                        factor = factor / divisible;
                        if(multipliers.Count > 0)
                        {
                            if(multipliers[counter] != divisible)
                            {
                                multipliers.Insert(counter, divisible);
                            }
                        }
                        else
                        {
                            multipliers.Add(divisible);
                        }
                        counter++;
                    }
                    else
                    {
                        divisible = GetNextPrimeNumber(divisible);
                    }
                }
                counter = 0;
            }

            return multiplyNumbersInAList(multipliers.ToArray());
        }

        public double[] createOrderedArrayOfNumbers(double number1, double number2, double number3)
        {
            double[] numbers = new double[] { number1, number2, number3 };

            Array.Sort(numbers);

            return numbers;
        }

        public bool IsPrime(int number)
        {
            if(number <= 1) return false;
            if(number == 2) return true;
            if(number % 2 == 0) return false;

            for(int i = 3; i <= (number*number); i+=2){
               
                if(number % i == 0)
                {
                    if(number == i) 
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } 
            }
            return true;
        }

        public int GetNextPrimeNumber(int number)
        {
            if(number > 1)
            {
                
                while(number < (number*2))
                {
                    number++;
                    if(IsPrime(number))
                    {
                        return number;
                    }
                }
            }
            return 2;
        }

        public double multiplyNumbersInAList(int[] numbers)
        {
            double result = 1;
            for(int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }

            return result;
        }
    }
}