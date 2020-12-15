using StartToEnd;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestLineSegment
    {
        private LineSegment segment = new LineSegment(
            new Point(2, 1),
            new Point(6, 4)
        );

        [Fact]
        public void TestLength()
        {
            Assert.Equal(5, segment.Length(), 3);
        }
    }
}
