using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProekt
{
    public class Player
    {
        public Point currentPoint { get; set; }
        public string name { get; set; }
        public int time { get; set; }
        public bool drawPlayer { get; set; }
        public int radius { get; set; }

        public Player(string name, Point point)
        {
            this.name = name;
            this.currentPoint = point;
            this.time = 0;
            drawPlayer = true;
            radius = 4;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Black);
            g.FillEllipse(b, currentPoint.X - 5, currentPoint.Y - 5, radius * 2, radius * 2);
            b.Dispose();
        }

        public void move(int v1, int v2)
        {
            currentPoint = new Point(currentPoint.X + v1, currentPoint.Y + v2);
        }
    }
}
