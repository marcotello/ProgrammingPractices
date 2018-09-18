using System.Collections.Generic;
using Xunit;

namespace Basic.Test
{
    public class BabyFoodTest
    {
        private readonly BabyFood _babyFood;

        public BabyFoodTest()
        {
            _babyFood = new BabyFood();
        }

        [Theory]
        [MemberData(nameof(GetFavoriteBabyFoodTestData))]
        public void GetFavoriteBabyFoodTest(string[][] food, string[] expected)
        {
            string[] result = _babyFood.GetFavoriteBabyFood(food);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetFavoriteBabyFoodTestData()
        {

            return new List<object[]>
                {
                    new object[] { new string[][] 
                        {  
                            new string[] { "SI", "patata", "maiz", "tomate", "FIN" },
                            new string[] { "NO", "patata", "puerco", "guisantes", "pollo", "FIN" },
                            new string[] { "SI", "tomate", "zanahoria", "puerco", "pollo", "calabacin", "arroz", "FIN" }
                        },  new string[] { "guisantes" }
                    },
                    new object[] { new string[][] 
                        {  
                            new string[] { "SI", "tomate", "zanahoria", "pollo", "calabacin", "arroz", "FIN" },
                            new string[] { "NO", "tomate", "ternera", "puerco", "FIN" }
                        },  new string[] { "puerco", "ternera" }
                    },
                };
        }

        [Theory]
        [MemberData(nameof(GetBadFoodTestData))]
        public void GetBadFoodTest(string[][] food, List<KeyValuePair<string, bool>> unlikedFood, string[] expected)
        {
            string[] result = _babyFood.GetBadFood(food, unlikedFood);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetBadFoodTestData()
        {

            return new List<object[]>
                {
                    new object[] { new string[][] 
                        {  
                            new string[] { "SI", "patata", "maiz", "tomate", "FIN" },
                            new string[] { "NO", "patata", "puerco", "guisantes", "pollo", "FIN" },
                            new string[] { "SI", "tomate", "zanahoria", "puerco", "pollo", "calabacin", "arroz", "FIN" }
                        },  
                        new List<KeyValuePair<string, bool>> { new KeyValuePair<string, bool>("NO", false), new KeyValuePair<string, bool>("patata", false),
                            new KeyValuePair<string, bool>("puerco", false), new KeyValuePair<string, bool>("guisantes", false), 
                            new KeyValuePair<string, bool>("pollo", false), new KeyValuePair<string, bool>("FIN", false) },
                        new string[] { "guisantes" }

                    },
                    new object[] { new string[][] 
                        {  
                            new string[] { "SI", "tomate", "zanahoria", "pollo", "calabacin", "arroz", "FIN" },
                            new string[] { "NO", "tomate", "ternera", "puerco", "FIN" }
                        },  
                        new List<KeyValuePair<string, bool>> { new KeyValuePair<string, bool>("NO", false), new KeyValuePair<string, bool>("tomate", false), 
                            new KeyValuePair<string, bool>("ternera", false), new KeyValuePair<string, bool>("puerco", false), 
                            new KeyValuePair<string, bool>("FIN", false) },
                        new string[] { "puerco", "ternera" }
                    },
                };
        }

        [Theory]
        [MemberData(nameof(GetUnlikedFoodTestData))]
        public void GetUnlikedFoodTest(string[][] food, KeyValuePair<string, bool> expected)
        {
            List<KeyValuePair<string, bool>> result = _babyFood.GetUnlikedFood(food);
            Assert.Equal(expected, result[0]);
        }

        public static IEnumerable<object[]> GetUnlikedFoodTestData()
        {

            return new List<object[]>
                {
                    new object[] { new string[][] 
                        {  
                            new string[] { "SI", "patata", "maiz", "tomate", "FIN" },
                            new string[] { "NO", "patata", "puerco", "guisantes", "pollo", "FIN" },
                            new string[] { "SI", "tomate", "zanahoria", "puerco", "pollo", "calabacin", "arroz", "FIN" }
                        },  new KeyValuePair<string, bool>("NO", false)
                    },
                    new object[] { new string[][] 
                        {  
                            new string[] { "SI", "tomate", "zanahoria", "pollo", "calabacin", "arroz", "FIN" },
                            new string[] { "NO", "tomate", "ternera", "puerco", "FIN" }
                        },  new KeyValuePair<string, bool>("NO", false)
                    },
                };
        }
    }
}