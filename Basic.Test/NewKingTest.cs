using System.Collections.Generic;
using Xunit;

namespace Basic.Test
{
    public class NewKingTest
    {
        private readonly NewKing _newKing;

        public NewKingTest()
        {
            _newKing = new NewKing();
        }

        [Theory]
        [MemberData(nameof(GetNextKingTestData))]
        public void GetNextKingTest(string[] kings, string[] newKings, string[] expected)
        {
            string[] result = _newKing.GetNextKing(kings, newKings);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetNextKingTestData()
        {

            return new List<object[]>
                {
                    new object[] { new string[] { "Felipe", "Carlos", "Felipe", "Felipe", "Felipe", "Carlos", "Felipe", "Carlos",
                        "Alfonso", "Alfonso", "JuanCarlos" }, 
                        new object[] { new string[] { "Felipe", "Leonor", "Felipe" } },
                        new object[] { new string[] { "Felipe 6", "Leonor 1", "Felipe 7" } }
                    },
                    new object[] { new string[] { "Carlos", "Isabel", "Carlos", "Jorge", "Jorge", "Jorge", "Jorge", "Guillermo", 
                        "Victoria", "Jorge", "Jorge", "Isabel" }, 
                        new object[] { new string[] { "Carlos", "Guillermo", "Jorge" } },
                        new object[] { new string[] { "Carlos 3", "Guillermo 2", "Jorge 7" } }
                    }
                };
        }
    }
}