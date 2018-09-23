using Xunit;

namespace Basic.Test
{
    public class BiologyTest
    {
        private readonly Biology _biology;
        public BiologyTest()
        {
            _biology = new Biology();
        }

        [Theory]
        [InlineData("ctgactga", "actgagc", "actga")]
        [InlineData("cgtaattgcgat", "cgtacagtagc", "cgta")]
        [InlineData("ctgggccttgaggaaaactg", "gtaccagtactgatagt", "actg")]
        public void GetDNAMatchTest(string chain1, string chain2, string expected)
        {
            string result = _biology.GetDNAMatch(chain1, chain2);
            Assert.Equal(expected, result);            
        }

        [Theory]
        [InlineData(new string[]{"ctgac", "tgact", "gactg", "actga"}, "actgagc", "actga")]
        [InlineData(new string[]{"cgta", "gtaa", "taat", "aatt", "attg", "ttgc", "tgcg", "gcga", "cgat"}, "cgtacagtagc", "cgta")]
        [InlineData(new string[]{"ctgac", "tgact", "gactg", "actga"}, "BBBFFFAAA", "")]
        [InlineData(new string[]{}, "BBBFFFAAA", "")]
        public void GetMatchTest(string[] subStrings, string chain2, string expected)
        {
            string result = _biology.GetMatch(subStrings, chain2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("ctgactga", 8, new string[]{"ctgactga"})]
        [InlineData("ctgactga", 7, new string[]{"ctgactg", "tgactga"})]
        [InlineData("ctgactga", 6, new string[]{"ctgact", "tgactg", "gactga"})]
        [InlineData("ctgactga", 5, new string[]{"ctgac", "tgact", "gactg", "actga"})]
        [InlineData("ctgactga", 4, new string[]{"ctga", "tgac", "gact", "actg", "ctga"})]
        public void GetSubStringsTest(string word, int index, string[] expected)
        {
            string[] result = _biology.GetSubStrings(word, index);
            Assert.Equal(expected, result);
        }
    }
}