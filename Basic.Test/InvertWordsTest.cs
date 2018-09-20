using Xunit;

namespace Basic.Test
{
    public class InvertWordsTest
    {
        private readonly InvertWords _invertWords;
        public InvertWordsTest()
        {
            _invertWords = new InvertWords();
        }

        [Theory]
        [InlineData("this is a test", "test a is this")]
        [InlineData("foobar", "foobar")]
        [InlineData("all your base", "base your all")]
        public void InvertTest(string phrase, string expected)
        {
            string result = _invertWords.Invert(phrase);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("this is a test", new string[]{"this", "is", "a", "test"})]
        [InlineData("foobar", new string[]{"foobar"})]
        [InlineData("all your base", new string[]{"all", "your", "base"})]
        public void SplitPhraseTest(string phrase, string[] expected)
        {
            string[] result = _invertWords.SplitPhrase(phrase);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new string[]{"this", "is", "a", "test"}, new string[]{"test", "a", "is", "this"})]
        [InlineData(new string[]{"foobar"}, new string[]{"foobar"})]
        [InlineData(new string[]{"all", "your", "base"}, new string[]{"base", "your", "all"})]
        public void InvertOrderTest(string[] splitted, string[] expected)
        {
            string[] result = _invertWords.InvertOrder(splitted);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new string[]{"test", "a", "is", "this"}, "test a is this")]
        [InlineData(new string[]{"foobar"}, "foobar")]
        [InlineData(new string[]{"base", "your", "all"}, "base your all")]
        public void JoinWordTest(string[] splitted, string expected)
        {
            string result = _invertWords.JoinWord(splitted);
            Assert.Equal(expected, result);
        }

    }
}