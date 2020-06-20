using System.Drawing;

namespace MazeProekt
{
    public class Cell
    {
        public int neighbours { get; set; }
        public bool isVisited { get; set; }
        public Point centerPoint { get; set; }
        // 0:up, 1:left, 2:down, 3:right
        public bool[] directions { get; set; }

        public int x { get; set; }
        public int y { get; set; }


        public Cell(int x,int y, int neighbours, Point centerPoint, bool[] directions)
        {
            this.neighbours = neighbours;
            this.isVisited = false;
            this.centerPoint = centerPoint;
            this.directions = new bool[4];
            this.directions = directions;

            this.x = x;
            this.y = y;
        }

    }
}
