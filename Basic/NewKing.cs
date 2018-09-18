namespace Basic
{
    public class NewKing
    {
        public string[] GetNextKing(string[] kings, string[] newKings)
        {
            int[] kingNumbers = new int[newKings.Length];

            for(int a = 0; a < kingNumbers.Length; a++)
            {
                kingNumbers[a] = 0;
            }

            for(int i = 0; i < newKings.Length; i++)
            {
                for(int x = 0; x < kings.Length; x++)
                {
                    if(newKings[i].Equals(kings[x]))
                    {
                        kingNumbers[i]++;
                    }
                }
            }

            for(int y = newKings.Length-1; y > 0; y--)
            {
                
            }
        }
        
    }
}