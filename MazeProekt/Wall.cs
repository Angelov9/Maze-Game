using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProekt
{
    public class Wall
    {
        public Point start { get; set; }
        public Point end { get; set; }
        // 0:up, 1:left, 2:down, 3:right
        public bool[] typeOfWall { get; set; }

        public Wall(Point start, Point end)
        {
            this.start = start;
            this.end = end;
            this.typeOfWall = new bool[4];
        }
        
        public double DistanceBetweenTwoPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public double DistanceBetweenPointAndLineX(int x, int y)
        {
            if ((start.X < x && x < end.X) || (end.X < x && x < start.X))
            {
                return DistanceBetweenTwoPoints(x, start.Y, x, y);
            }
            return Int32.MaxValue;
        }

        public double DistanceBetweenPointAndLineY(int x, int y)
        {
            if ((start.Y < y && y < end.Y) || (end.Y < y && y < start.Y))
            {
                return DistanceBetweenTwoPoints(start.X, y, x, y);
            }
            return Int32.MaxValue;
        }

        public override string ToString()
        {
            return string.Format("X1:{0} Y1:{1}, X2:{2} Y2:{3}", start.X, start.Y, end.X, end.Y);
        }

        public override bool Equals(object obj)
        {
            Wall w = (Wall)obj;
            if (w.start.Equals(start) && w.end.Equals(end))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 1075529825;
            hashCode = hashCode * -1521134295 + start.GetHashCode();
            hashCode = hashCode * -1521134295 + end.GetHashCode();
            return hashCode;
        }
    }
}
