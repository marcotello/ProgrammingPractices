using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    public class PhoneKayboard
    {
        public string GetEncodedText(string phrase)
        {
            string[] words = SplitWords(phrase);
            words = ParseWords(words);
            return FormatFinalWord(words);
        }

        public string FormatFinalWord(string[] words)
        {
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < words.Length; i++)
            {
                builder.Append(words[i] +  " ");
                if(i != (words.Length - 1))
                {
                    builder.Append("1 ");
                }
            }
            return builder.ToString().Trim();
        }

        public string[] ParseWords(string[] words)
        {
            List<string> parsedWords = new List<string>();
            char[] characters = null;

            foreach(string word in words)
            {
                StringBuilder builder = new StringBuilder();
                characters = word.ToCharArray();
                for(int i = 0;i < characters.Length; i++)
                {
                    builder.Append(GetEncodedChar(characters[i]));
                    builder.Append(" ");
                }
                parsedWords.Add(builder.ToString().Trim());
            }

            return parsedWords.ToArray();
        }

        public string GetEncodedChar(char v)
        {
            string encoded = "";
            switch (v)
            {
                case 'a':
                    encoded = "2";
                    break;
                case 'b':
                    encoded = "22";
                    break;
                case 'c':
                    encoded = "222";
                    break;
                case 'd':
                    encoded = "3";
                    break;
                case 'e':
                    encoded = "33";
                    break;
                case 'f':
                    encoded = "333";
                    break;
                case 'g':
                    encoded = "4";
                    break;
                case 'h':
                    encoded = "44";
                    break;
                case 'i':
                    encoded = "444";
                    break;
                case 'j':
                    encoded = "5";
                    break;
                case 'k':
                    encoded = "55";
                    break;
                case 'l':
                    encoded = "555";
                    break;
                case 'm':
                    encoded = "6";
                    break;
                case 'n':
                    encoded = "66";
                    break;
                case 'o':
                    encoded = "666";
                    break;
                case 'p':
                    encoded = "7";
                    break;
                case 'q':
                    encoded = "77";
                    break;
                case 'r':
                    encoded = "777";
                    break;
                case 's':
                    encoded = "7777";
                    break;
                case 't':
                    encoded = "8";
                    break;
                case 'u':
                    encoded = "88";
                    break;
                case 'v':
                    encoded = "888";
                    break;
                case 'w':
                    encoded = "9";
                    break;
                case 'x':
                    encoded = "99";
                    break;
                case 'y':
                    encoded = "999";
                    break;
                case 'z':
                    encoded = "9999";
                    break;
            }
            return encoded;
        }

        public string[] SplitWords(string phrase)
        {
            return phrase.Split(" ");
        }
    }
}