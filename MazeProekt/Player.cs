using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProekt
{
    [Serializable]
    public class Player: IComparable<Player>
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

        public override string ToString()
        {
            return string.Format("{0} - {1}:{2:00}", name, time/60, time%60);
        }

        public int CompareTo(Player p)
        {
            if (p == null)
                return 1;
            if(p.time > this.time)
            {
                return -1;
            }else if (p.time < this.time)
            {
                return 1;
            }else
            {
                return 0;
            }
        }
    }
}
