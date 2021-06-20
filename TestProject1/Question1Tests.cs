using System;
using System.Collections.Generic;
using System.Linq;
using TDDChallenge;
using Xunit;

namespace TestProject1
{
    public class Question1Tests
    {
        [Fact]
        public void ShouldReturnOddNumberWhenArrayIsEven()
        {
            int[] arr = new int[] { 0, 10, 8, 22, 5, 22 };
            bool x = Question1.ReturnUnevenNumber(arr) == 5;
            Assert.True(x);
        }

        [Fact]
        public void ShouldReturnEvenNumberWhenArrayIsOdd()
        {
            int[] arr = new int[] { 3, 55, 2, 9, 11 };
            bool x = Question1.ReturnUnevenNumber(arr) == 2;
            Assert.True(x);
        }



    }
}
