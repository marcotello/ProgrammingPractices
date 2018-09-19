using System;
using System.Collections.Generic;
using Basic.Entities;

namespace Basic
{
    public class NewKing
    {
        public string[] GetNextKing(string[] kings, string[] newKings)
        {
            List<King> newKingsList = GetKingsList(newKings);

            newKingsList = GetKingsNumber(newKingsList, kings);

            newKingsList = InspectListToGetKingsNumber(newKingsList);
           
            return GetFormatedKingList(newKingsList);
        }

        public string[] GetFormatedKingList(List<King> newKingsList)
        {
            string[] kings = new string[newKingsList.Count];
            
            for(int i = 0; i < newKingsList.Count; i++)
            {
                kings[i] = newKingsList[i].Name + " " + newKingsList[i].Number.ToString();
            }

            return kings;
        }

        public List<King> GetKingsList(string[] kings)
        {
            List<King> newKingsList = new List<King>();

            for(int i = 0; i < kings.Length; i++)
            {
                newKingsList.Add(new King(kings[i], 1));
            }

            return newKingsList;
        }

        public List<King> GetKingsNumber(List<King> kingsList, string[] kings)
        {
            foreach(King king in kingsList)
            {
                for(int i = 0; i < kings.Length; i++)
                {
                    if(king.Name.Equals(kings[i]))
                    {
                        king.Number++;
                    }
                }
            }

            return kingsList;
        }

        public List<King> InspectListToGetKingsNumber(List<King> kingsList)
        {
            string name = "";
            int counter = kingsList.Count-1;
            while(counter != 0)
            {
                name = kingsList[counter].Name;
                for(int i = kingsList.Count-1; i >= 0; i--)
                {
                    if(counter!=i)
                    {
                        if(kingsList[i].Name.Equals(name))
                        {
                            kingsList[counter].Number++;
                        }
                    }
                }
                counter--;
            }
            return kingsList;
        }
    }
}