using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDChallenge;
using Xunit;

namespace TestProject1
{
    public class Question2Tests
    {
        [Fact]
        public void ShouldReturnAllIntegersWhenGivenOnlyIntegers()
        {
            var elements = new List<object> { 0, 1, 2, 3, 4 };
            var intElements = new List<int> { 0, 1, 2, 3, 4 };
            bool x = Question2.GetIntegersFomList(elements).All(intElements.Contains);
            Assert.True(x);
        }

        [Fact]
        public void ShouldBeEmptyWhenGivenOnlyStrings()
        {
            var elements = new List<object> { "0", "1", "2", "3", "4" };
            var x = Question2.GetIntegersFomList(elements);
            Assert.Empty(x);
        }

        [Fact]
        public void ShouldReturnAllIntegersAndIgnoringAllStrings()
        {
            var elements = new List<object> { 0, 1, "a", "3", 9 };
            var intElements = new List<int> { 0, 1, 9 };
            bool x = Question2.GetIntegersFomList(elements).All(intElements.Contains);
            Assert.True(x);
        }
    }
}
