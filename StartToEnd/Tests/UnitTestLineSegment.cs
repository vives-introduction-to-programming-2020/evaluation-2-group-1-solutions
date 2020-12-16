using StartToEnd;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestLineSegment
    {
        [Fact]
        public void TestLength()
        {
            Assert.Equal(5, new LineSegment(new Point(2, 1), new Point(6, 4)).Length(), 3);
            Assert.Equal(5.099, new LineSegment(new Point(4, 3), new Point(3, -2)).Length(), 3);
            Assert.Equal(7.2111, new LineSegment(new Point(1, 2), new Point(7, 6)).Length(), 3);
            Assert.Equal(2.8284, new LineSegment(new Point(1, 2), new Point(3, 4)).Length(), 3);
        }
    }
}
