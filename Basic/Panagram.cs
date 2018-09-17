using System;
using System.Collections.Generic;

namespace Basic
{
    public class Panagram
    {
        public string IsPanagram(string word)
        {
            string result = "SI";

            List<KeyValuePair<string, bool>> alphabet = InitializeAlphabet();

            alphabet = ComparePanagram(word, alphabet);

            foreach(KeyValuePair<string, bool> character in alphabet)
            {
                if(character.Value == false)
                {
                    return "NO";
                }
            }

            return result; 
        }

        public string GetResult(List<KeyValuePair<string, bool>> alphabet)
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<string, bool>> InitializeAlphabet()
        {
            int aUnicode = 65;
            char character;
            List<KeyValuePair<string, bool>> alphabet = new List<KeyValuePair<string, bool>>();

            for(int i = aUnicode; i < (aUnicode + 26); i++)
            {
                character = (char) i;
                alphabet.Add( new KeyValuePair<string, bool>(character.ToString(), false) );
            }

            return alphabet;
        }

        public List<KeyValuePair<string, bool>> ComparePanagram(string word, List<KeyValuePair<string, bool>> alphabet)
        {
            char[] wordArray = word.ToUpper().ToCharArray();
            
            for(int i = 0; i < wordArray.Length; i++ )
            {
                for(int a = 0; a < alphabet.Count; a++)
                {
                    if(alphabet[a].Key.Equals(wordArray[i].ToString()))
                    {
                        alphabet[a] = new KeyValuePair<string, bool>(alphabet[a].Key, true);
                    }
                }
            }

            return alphabet;
        }
    }
}