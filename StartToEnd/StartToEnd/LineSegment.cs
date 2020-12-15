using System;
using System.Collections.Generic;
using System.Text;

namespace StartToEnd
{
    public class LineSegment
    {
        public LineSegment(Point start, Point end)
        {
            SetStart(start);
            SetEnd(end);
        }

        public void SetStart(Point start)
        {
            this.start = start;
        }

        public Point GetStart()
        {
            return start;
        }

        public void SetEnd(Point end)
        {
            this.end = end;
        }

        public Point GetEnd()
        {
            return end;
        }

        private Point start;
        private Point end;
    }
}
