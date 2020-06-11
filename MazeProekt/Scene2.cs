using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProekt
{
    public class Scene2
    {
        public Maze2 m { get; set; }
        public int size { get; set; }
        public int wall { get; set; }

        public Scene2(int size, int wall = 10)
        {
            m = new Maze2(size, wall);
            this.size = size;
            this.wall = wall;
        }

        public void NewMaze(int size, int wall = 10)
        {
            m = new Maze2(size, wall);
            this.size = size;
            this.wall = wall;
        }

        public void Draw(Graphics g)
        {
            if (m.gotPath)
            {
                m.DrawMaze(g);
            }
            else
            {
                m = new Maze2(size, wall);
                Draw(g);
            }
        }
    }
}
