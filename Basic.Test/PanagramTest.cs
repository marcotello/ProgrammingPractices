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
    }
}