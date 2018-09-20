using System;
using System.Text;

namespace Basic
{
    public class InvertWords
    {
        public string Invert(string phrase)
        {
            string[] splitted = SplitPhrase(phrase);
            string[] inverted = InvertOrder(splitted);
            return JoinWord(inverted);
        }

        public string JoinWord(string[] inverted)
        {
            StringBuilder word = new StringBuilder();

            foreach(string item in inverted)
            {
                word.Append(item + " ");
            }

            return word.ToString().Trim();
        }

        public string[] InvertOrder(string[] splitted)
        {
            string[] inverted = new string[splitted.Length];
            int counter = 0;

            for(int i = splitted.Length-1; i >= 0; i--)
            {
                inverted[counter] = splitted[i];
                counter++;
            }
            return inverted;
        }

        public string[] SplitPhrase(string phrase)
        {
            return phrase.Split(" ");
        }
    }
}