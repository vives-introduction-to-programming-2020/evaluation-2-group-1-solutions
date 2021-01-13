using System;

namespace StartToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Start to End\n");

            LineSegment segment = new LineSegment(
                new Point(0, 1),
                new Point(5, 7)
            );

            // TODO - Uncomment this so the LineSegment length is outputted
            Console.WriteLine($"The length of the segment is {segment.Length()}");
        }
    }
}
