using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    public class Fraction
    {
        public string GetMinimumFraction(double number)
        {
            KeyValuePair<int, int> fraction = GetFraction(number);
            
            KeyValuePair<int, int> minimumFraction = ReduceFraction(fraction);
            
            return minimumFraction.Key.ToString() + "/" + minimumFraction.Value.ToString();
        }

        public KeyValuePair<int, int> ReduceFraction(KeyValuePair<int, int> fraction)
        {
            int numerator = fraction.Key;
            int denominator = fraction.Value;
            int divider = 2;

            while(numerator>1)
            {
                divider = 2;

                if(!IsPrime(numerator) || numerator == 5 || numerator == 2)
                {   
                    if(numerator % divider == 0 && denominator % divider == 0)
                    {
                        numerator /= divider;
                        denominator /= divider;
                    }
                    else
                    {
                        divider = 5;
                        if(numerator % divider == 0 && denominator % divider == 0)
                        {
                            numerator /= divider;
                            denominator /= divider;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            return new KeyValuePair<int, int>(numerator, denominator);
        }

        public KeyValuePair<int, int> GetFraction(double number)
        {
            string numerator = number.ToString();
            
            numerator = numerator.Substring(numerator.IndexOf(".")+1);

            StringBuilder denominator = new StringBuilder("1");

            for(int i = 0; i < numerator.Length; i++)
            {
                denominator.Append("0");
            }
            
            return new KeyValuePair<int, int>(Int32.Parse(numerator), Int32.Parse(denominator.ToString()));
        }

        public bool IsPrime(int number)
        {
            if(number<2) return false;
            if(number == 2) return true;
            if(number % 2 == 0) return false;

            for(int i = 3; i<(number*2); i+=2)
            {
                if(number % i == 0)
                {
                    if(number==i)
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
            if(number < 2) return 2;

            for(int i = (number+1); i < (number*2); i++)
            {
                if(IsPrime(i))
                {
                    return i;
                }
            }
            return 0;
        }
    }
}