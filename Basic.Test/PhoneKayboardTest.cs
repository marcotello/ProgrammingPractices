using Xunit;

namespace Basic.Test
{
    public class PhoneKayboardTest
    {
        private readonly PhoneKayboard _phoneKayboard;

        public PhoneKayboardTest()
        {
            _phoneKayboard = new PhoneKayboard();
        }

        [Theory]
        [InlineData("hi", "44 444")]
        [InlineData("yes", "999 33 7777")]
        [InlineData("foo bar", "333 666 666 1 22 2 777")]
        [InlineData("hello world", "44 33 555 555 666 1 9 666 777 555 3")]
        public void GetEncodedTextTest(string words, string expected)
        {
            string result = _phoneKayboard.GetEncodedText(words);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new string[]{"44 444"}, "44 444")]
        [InlineData(new string[]{"999 33 7777"}, "999 33 7777")]
        [InlineData(new string[]{"333 666 666", "22 2 777"}, "333 666 666 1 22 2 777")]
        [InlineData(new string[]{"44 33 555 555 666", "9 666 777 555 3"}, "44 33 555 555 666 1 9 666 777 555 3")]
        public void FormatFinalWordTest(string[] words, string expected)
        {
            string result = _phoneKayboard.FormatFinalWord(words);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new string[]{"hi"}, new string[]{"44 444"})]
        [InlineData(new string[]{"yes"}, new string[]{"999 33 7777"})]
        [InlineData(new string[]{"foo", "bar"}, new string[]{"333 666 666", "22 2 777"})]
        [InlineData(new string[]{"hello", "world"}, new string[]{"44 33 555 555 666", "9 666 777 555 3"})]
        public void ParseWordsTest(string[] words, string[] expected)
        {
            string[] result = _phoneKayboard.ParseWords(words);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData('h', "44")]
        [InlineData('i', "444")]
        [InlineData('y', "999")]
        [InlineData('a', "2")]
        [InlineData('f', "333")]
        [InlineData('b', "22")]
        public void GetEncodedCharTest(char v, string expected)
        {
            string result = _phoneKayboard.GetEncodedChar(v);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("hi", new string[]{"hi"})]
        [InlineData("foo bar", new string[]{"foo", "bar"})]
        [InlineData("hello world", new string[]{"hello", "world"})]
        public void GetWordsTest(string phase, string[] expected)
        {
            string[] result = _phoneKayboard.SplitWords(phase);
            Assert.Equal(expected, result);
        }
    }
}