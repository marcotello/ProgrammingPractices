using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    public class PrimeFactors
    {
        public string FindPrimeFactors(double number)
        {
            double initialNumber =  number;
            List<int> primes = new List<int>();
            int factor = 2;
            
            while(number>1)
            {
                if(number % factor == 0)
                {
                    number =  number / factor;
                    factor = GetNextPrime(factor);
                    primes.Add(factor);
                }
            }
            return GetOutput(initialNumber, primes.ToArray());
        }

        public bool IsPrime(int number)
        {
            if(number < 2) return false;
            if(number == 2) return true;
            
            for(int i = 3; i < (number*2); i+=2)
            {
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
            return false;
        }

        public int GetNextPrime(int number)
        {
            if(number<2) return 2;

            int initNumber = number + 1;
            for(int i = (initNumber); i < (number * 2); i++)
            {
                if(IsPrime(i))
                {
                    return i;
                }
            }
            return initNumber;
        }

        public string GetOutput(double number, int[] primes)
        {
            StringBuilder output = new StringBuilder(number + " = ");
            for(int i = 0; i < primes.Length; i++)
            {
                output.Append(primes[i] + " ");
            }
            return output.ToString().Trim();
        }
    }
}