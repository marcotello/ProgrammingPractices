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
                            new string[] { "NO", "patata", "puerro", "guisantes", "pollo", "FIN" },
                            new string[] { "SI", "tomate", "zanahoria", "puerro", "pollo", "calabacin", "arroz", "FIN" }
                        },  new string[] { "guisantes" }
                    },
                    new object[] { new string[][] 
                        {  
                            new string[] { "SI", "tomate", "zanahoria", "pollo", "calabacin", "arroz", "FIN" },
                            new string[] { "NO", "tomate", "ternera", "puerro", "FIN" }
                        },  new string[] { "puerro", "ternera" }
                    },
                };
        }
    }
}