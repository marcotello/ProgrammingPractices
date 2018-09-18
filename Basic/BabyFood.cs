using System;
using System.Collections.Generic;

namespace Basic
{
    public class BabyFood
    {
        public string[] GetFavoriteBabyFood(string[][] food)
        {
            List<KeyValuePair<string, bool>> unlikeFood = GetUnlikedFood(food);
            return GetBadFood(food, unlikeFood);
        }

        public string[] GetBadFood(string[][] food, List<KeyValuePair<string, bool>> unlikeFood)
        {
            List<string> badFood = new List<string>();
            int counter = 0;

            for(int lap = 0; lap < food.Length; lap++)
            {
                if(food[lap][0].Equals("SI"))
                {
                    while(counter < unlikeFood.Count)
                    {
                        for(int ingridient = 0; ingridient < food[lap].Length; ingridient++)
                        {
                            if(unlikeFood[counter].Key.Equals(food[lap][ingridient]))
                            {
                                unlikeFood[counter] = new KeyValuePair<string, bool>(unlikeFood[counter].Key, true);
                            }
                        }

                        counter++;      
                    }
                }
                counter = 0;
            }

            foreach(KeyValuePair<string, bool> ing in unlikeFood)
            {
                if(!ing.Key.Equals("NO"))
                {
                    if(!ing.Value)
                    {
                        badFood.Add(ing.Key);
                    }
                }
            }
            badFood.Sort();
            return badFood.ToArray();
        }

        public List<KeyValuePair<string, bool>> GetUnlikedFood(string[][] food)
        {
            List<KeyValuePair<string, bool>> unlikedFood = new List<KeyValuePair<string, bool>>();
            string[] badTasteFood = new string[0];

            for(int lap = 0; lap < food.Length; lap++)
            {
                foreach(string ingridient in food[lap])
                {
                    if(ingridient.Equals("NO"))
                    {
                        badTasteFood = food[lap];
                    }
                }
            }

            foreach(string ingridient in badTasteFood)
            {
                unlikedFood.Add(new KeyValuePair<string, bool>(ingridient, false));
            }

            return unlikedFood;
        }
    }
}