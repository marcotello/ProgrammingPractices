using System.Collections.Generic;
using Xunit;

namespace Basic.Test
{
    public class PanagramTest
    {
        private readonly Panagram _panagram;
        public PanagramTest()
        {
            _panagram = new Panagram();
        }

        [Theory]
        [InlineData("abcdefGHIJKLMNopqrstuvwxyz", "SI")]
        [InlineData("abcdefghijklwnopqrstuvwxyz", "NO")]
        [InlineData("Este es un texto de ejemplo", "NO")]
        [InlineData("The quick brown fox jumps over the lazy dog", "SI")]
        [InlineData("El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja", "SI")]
        [InlineData("El viejo Señor Gómez pedía queso, kiwi y habas, pero le ha tocado un saxo.", "NO")]
        [InlineData("Quiere la boca exhausta vid, kiwi, piña y fugaz jamón.", "SI")]
        public void IsPanagramTest(string word, string expected)
        {
            string result = _panagram.IsPanagram(word);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(ComparePanagramTestData))]
        public void ComparePanagramTest(KeyValuePair<string, bool> expected, int expecterPosition, string word)
        {
            List<KeyValuePair<string, bool>> alphabet = _panagram.InitializeAlphabet();
            alphabet = _panagram.ComparePanagram(word, alphabet);
            Assert.Equal(expected, alphabet[expecterPosition]);
        }

        public static IEnumerable<object[]> ComparePanagramTestData()
        {

            return new List<object[]>
                {
                    new object[] { new KeyValuePair<string, bool>("A", true), 0, "abcdefghijklwnopqrstuvwxyz" },
                    new object[] { new KeyValuePair<string, bool>("C", true), 2, "abcdefghijklwnopqrstuvwxyz" },
                    new object[] { new KeyValuePair<string, bool>("Z", true), 25, "abcdefghijklwnopqrstuvwxyz" },
                    new object[] { new KeyValuePair<string, bool>("M", false), 12, "abcdefghijklwnopqrstuvwxyz" },
                    new object[] { new KeyValuePair<string, bool>("U", true), 20, "abcdefghijklwnopqrstuvwxyz" }
                };
        }

        [Theory]
        [MemberData(nameof(InitializeAlphabetTest))]
        public void InitializeAphabetTest(KeyValuePair<string, bool> expected, int expecterPosition)
        {
            List<KeyValuePair<string, bool>> result = _panagram.InitializeAlphabet();
            Assert.Equal(expected, result[expecterPosition]);
        }

        public static IEnumerable<object[]> InitializeAlphabetTest()
        {

            return new List<object[]>
                {
                    new object[] { new KeyValuePair<string, bool>("A", false), 0 },
                    new object[] { new KeyValuePair<string, bool>("C", false), 2 },
                    new object[] { new KeyValuePair<string, bool>("Z", false), 25 },
                    new object[] { new KeyValuePair<string, bool>("M", false), 12 },
                    new object[] { new KeyValuePair<string, bool>("U", false), 20 },
                };
        }
    }
}