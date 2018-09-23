using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Basic
{
    public class Biology
    {
        public string GetDNAMatch(string chain1, string chain2)
        {
            string[] subStrings;
            string result = "";
            for(int i = chain1.Length; i >= 0; i--)
            {
                subStrings = GetSubStrings(chain1, i);
                result = GetMatch(subStrings, chain2);
                if(!string.IsNullOrEmpty(result))
                {
                    break;
                }
            }

            return result;
        }

        public string GetMatch(string[] subStrings, string chain2)
        {
            string result = "";
            foreach(string word in subStrings)
            {
                if(chain2.Contains(word))
                {
                    result = word;
                }
            }
            return result;
        }

        public string[] GetSubStrings(string chain1, int index)
        {
            List<string> chains = new List<string>();

            for(int i = 0; i < chain1.Length; i++)
            {
                string word = "";
                try
                {   
                    word = chain1.Substring(i, index);
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Debug.WriteLine("Exception Message: " + ex.Message);
                    break;
                }
                chains.Add(word);
            }

            return chains.ToArray();
        }
    }
}