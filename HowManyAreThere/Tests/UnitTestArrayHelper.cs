using HowManyAreThere;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestArrayHelper
    {
        private ArrayHelper helper = new ArrayHelper();

        [Fact]
        public void TestOccurence()
        {
            Assert.Equal(2, helper.Count(new int[] { 8, 12, 23, 0, -1, 12 }, 12));
            Assert.Equal(0, helper.Count(new int[] { 12, 44, 2, 9, -93, 11 }, 101));
            Assert.Equal(6, helper.Count(new int[] { 5, 5, 5, 5, 5, 5 }, 5));
            Assert.Equal(1, helper.Count(new int[] { 5, 35, -7, 4, 51, -9 }, -7));
        }

        [Fact]
        public void TestOccurencesEmptyArray()
        {
            Assert.Equal(0, helper.Count(new int[] { }, 12));
        }

        [Fact]
        public void TestMinimum()
        {
            Assert.Equal(-1, helper.Minimum(new int[] { 8, 12, 23, 0, -1, 12 }));
            Assert.Equal(-93, helper.Minimum(new int[] { 12, -93, 93, 9, -93, 11 }));
            Assert.Equal(5, helper.Minimum(new int[] { 5, 5, 5, 5, 5, 5 }));
            Assert.Equal(0, helper.Minimum(new int[] { 5, 35, 0, 4, 51, 9 }));
        }

        [Fact]
        public void TestMinimumEmptyArray()
        {
            Assert.Equal(0, helper.Minimum(new int[] { }));
        }
    }
}
