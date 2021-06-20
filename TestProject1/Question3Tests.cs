using TDDChallenge;
using Xunit;

namespace TestProject1
{
    public class Question3Tests
    {
        [Fact]
        public void ShouldIgnoreEmptyAndWhiteSpace()
        {
            var array = new string[] { "ninja", "", "ronin" };
            var expected = "ninja and ronin";
            var actual = Kata.FormatWords(array);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnSingleWord()
        {
            var array = new string[] { "ninja" };
            var expected = "ninja";
            var actual = Kata.FormatWords(array);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldSepareLastWord()
        {
            var array = new string[] { "ninja", "samurai", "ronin" };
            var expected = "ninja, samurai and ronin";
            var actual = Kata.FormatWords(array);

            Assert.Equal(expected, actual);
        }
    }
}