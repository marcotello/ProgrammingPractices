using System.Collections.Generic;
using Basic.Entities;
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
                        new string[] { "Felipe", "Leonor", "Felipe" },
                        new string[] { "Felipe 6", "Leonor 1", "Felipe 7" }
                    },
                    new object[] { new string[] { "Carlos", "Isabel", "Carlos", "Jorge", "Jorge", "Jorge", "Jorge", "Guillermo", 
                        "Victoria", "Jorge", "Jorge", "Isabel" }, 
                        new string[] { "Carlos", "Guillermo", "Jorge" },
                        new string[] { "Carlos 3", "Guillermo 2", "Jorge 7" }
                    }
                };
        }

        [Theory]
        [MemberData(nameof(GetFormatedKingListTestData))]
        public void GetFormatedKingListTest(string[] kings, int[] numbers, string[] expected)
        {
            List<King> kingsList = new List<King>();
            string[] finalKings;

            for(int i = 0; i < kings.Length; i++)
            {
                kingsList.Add(new King(kings[i], numbers[i]));
            }

            finalKings = _newKing.GetFormatedKingList(kingsList);
            Assert.Equal(expected, finalKings);
        }

        public static IEnumerable<object[]> GetFormatedKingListTestData()
        {

            return new List<object[]>
                {
                    new object[] { new string[] { "Felipe", "Leonor", "Felipe" }, 
                        new int[] { 6, 1, 7 },
                        new string[] { "Felipe 6", "Leonor 1", "Felipe 7" }
                    },
                    new object[] { new string[] { "Carlos", "Guillermo", "Jorge" }, 
                        new int[] { 3, 2, 7 },
                        new string[] { "Carlos 3", "Guillermo 2", "Jorge 7" }
                    }
                };
        }

        [Theory]
        [InlineData( new string[] { "Felipe", "Leonor", "Felipe" }, "Felipe", 0)]
        [InlineData( new string[] { "Felipe", "Leonor", "Felipe" }, "Leonor", 1)]
        [InlineData( new string[] { "Carlos", "Guillermo", "Jorge" }, "Carlos", 0)]
        public void GetKingsListTest(string[] kings, string expectedName, int position)
        {
            List<King> kingsList = _newKing.GetKingsList(kings);
            Assert.Equal(expectedName, kingsList[position].Name);
        }

        [Theory]
        [MemberData(nameof(GetKingsNumberTestData))]
        public void GetKingsNumberTest(string[] kings, string[] newKings, int expected, int position)
        {
            List<King> kingsList = _newKing.GetKingsList(newKings);
            kingsList = _newKing.GetKingsNumber(kingsList, kings);
            Assert.Equal(expected, kingsList[position].Number);
        }

        public static IEnumerable<object[]> GetKingsNumberTestData()
        {

            return new List<object[]>
                {
                    new object[] { new string[] { "Felipe", "Carlos", "Felipe", "Felipe", "Felipe", "Carlos", "Felipe", "Carlos",
                        "Alfonso", "Alfonso", "JuanCarlos" }, 
                        new string[] { "Felipe", "Leonor", "Felipe" },
                        6, 
                        0
                    },
                    new object[] { new string[] { "Carlos", "Isabel", "Carlos", "Jorge", "Jorge", "Jorge", "Jorge", "Guillermo", 
                        "Victoria", "Jorge", "Jorge", "Isabel" }, 
                        new string[] { "Carlos", "Guillermo", "Jorge" },
                        7,
                        2
                    }
                };
        }

        [Theory]
        [InlineData( new string[] { "Felipe", "Leonor", "Felipe" }, 2, 2)]
        [InlineData( new string[] { "Carlos", "Isabel", "Carlos", "Jorge", "Jorge", "Jorge", "Jorge", "Guillermo", 
                        "Victoria", "Jorge", "Jorge", "Isabel" }, 6, 10)]
        public void InspectListToGetKingsNumberTest(string[] kings, int expected, int position)
        {
            List<King> kingsList = _newKing.GetKingsList(kings);
            kingsList = _newKing.InspectListToGetKingsNumber(kingsList);
            Assert.Equal(expected, kingsList[position].Number);
        }

    }
}