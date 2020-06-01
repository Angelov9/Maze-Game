using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProekt
{
    /**
     *  Class that looks like a graph
     *  A maze contains:
     *      - cells: matrix for all the cells in a grid
     *      - size: dimesions of the matrix
     *      - wallLength: half lenght of a wall, used to help draw straight and equal lines
     *      - start: a cell that will store the starting position for the player
     *      - end: a cell that shows the finish of the maze
     *      - outerCells: list of all cells that make the outer walls
     *      - gotPath: if this is true, the maze has a path from start to end
     *      - constructor: requires the size of the matrix and the wall which is predefined
     *      other parameters are set to defaults or initialized;
     *      - functions: GenerateGrid(), CheckPath(), GenerateMaze(), DrawMaze(Graphics g),
     *      DFS(int x1, int y1, int x2, int y2)
     */
    public class Maze2
    {
        public Cell[,] cells { get; set; }
        public int size { get; set; }
        public int wallLength { get; set; }
        public Cell start { get; set; }
        public Cell end { get; set; }
        public List<Cell> leftOuterCells { get; set; }
        public List<Cell> rightOuterCells { get; set; }
        public bool gotPath { get; set; }
        public List<Wall> wallsToDraw { get; set; }
        public List<Wall> leftWalls { get; set; }
        public List<Wall> rightWalls { get; set; }
        public List<Wall> topWalls { get; set; }
        public List<Wall> bottomWalls { get; set; }

        public Maze2(int size, int wall = 10)
        {
            cells = new Cell[size, size];
            this.size = size;
            wallLength = wall;
            start = null;
            end = null;
            leftOuterCells = new List<Cell>();
            rightOuterCells = new List<Cell>();
            gotPath = false;
            wallsToDraw = new List<Wall>();
            leftWalls = new List<Wall>();
            rightWalls = new List<Wall>();
            topWalls = new List<Wall>();
            bottomWalls = new List<Wall>();
            // to calculate all outer cells: 
            //            outerCells = new Cell[2 * size + 2*(size - 2)];
            GenerateGrid();
        }

        // TODO: not finished...
        private void AllWalls()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // 0:up, 1:left, 2:down, 3:right
                    // correct
                    if (!cells[i, j].directions[0])
                    {
                        Wall w = new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength));
                        if (!wallsToDraw.Contains(w))
                        {
                            w.typeOfWall = new bool[4] { true, false, false, false };
                            wallsToDraw.Add(w);
                        }
                        else if (wallsToDraw.Contains(w))
                        {
                            int index = wallsToDraw.IndexOf(w);
                            wallsToDraw.ElementAt(index).typeOfWall[0] = true;
                        }
                    }
                    if (!cells[i, j].directions[1])
                    {
                        Wall w = new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength));
                        if (!wallsToDraw.Contains(w))
                        {
                            w.typeOfWall = new bool[4] { false, true, false, false };
                            wallsToDraw.Add(w);
                        }
                        else if (wallsToDraw.Contains(w))
                        {
                            int index = wallsToDraw.IndexOf(w);
                            wallsToDraw.ElementAt(index).typeOfWall[1] = true;
                        }
                    }
                    if (!cells[i, j].directions[2])
                    {
                        Wall w = new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength));
                        if (!wallsToDraw.Contains(w))
                        {
                            w.typeOfWall = new bool[4] { false, false, true, false };
                            wallsToDraw.Add(w);
                        }
                        else if (wallsToDraw.Contains(w))
                        {
                            int index = wallsToDraw.IndexOf(w);
                            wallsToDraw.ElementAt(index).typeOfWall[2] = true;
                        }
                    }
                    if (!cells[i, j].directions[3])
                    {
                        Wall w = new Wall(new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength));
                        if (!wallsToDraw.Contains(w))
                        {
                            w.typeOfWall = new bool[4] { false, false, false, true };
                            wallsToDraw.Add(w);
                        }
                        else if (wallsToDraw.Contains(w))
                        {
                            int index = wallsToDraw.IndexOf(w);
                            wallsToDraw.ElementAt(index).typeOfWall[3] = true;
                        }
                    }
                }
            }

            foreach(Wall w in wallsToDraw)
            {
                if (w.typeOfWall[0])
                {
                    topWalls.Add(w);
                }
                if (w.typeOfWall[1])
                {
                    leftWalls.Add(w);
                }
                if (w.typeOfWall[2])
                {
                    bottomWalls.Add(w);
                }
                if (w.typeOfWall[3])
                {
                    rightWalls.Add(w);
                }
            }

            /*
             * if (!cells[i, j].directions[0])
                    {
                        if (!wallsToDraw.Contains(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength))))
                        {
                            wallsToDraw.Add(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength)));
                        }
                        if (!bottomWalls.Contains(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength))))
                        {
                            topWalls.Add(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), 
                                new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength)));
                        }
                    }
                    if (!cells[i, j].directions[1])
                    {
                        if (!wallsToDraw.Contains(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength))))
                        {
                            wallsToDraw.Add(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength)));
                        }
                        if (!rightWalls.Contains(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength))))
                        {
                            leftWalls.Add(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength)));
                        }
                    }
                    if (!cells[i, j].directions[2])
                    {
                        if (!wallsToDraw.Contains(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength))))
                        {
                            wallsToDraw.Add(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength)));
                        }
                        if (!topWalls.Contains(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength))))
                        {
                            bottomWalls.Add(new Wall(new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength)));
                        }
                    }
                    if (!cells[i, j].directions[3])
                    {
                        if (!wallsToDraw.Contains(new Wall(new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength))))
                        {
                            wallsToDraw.Add(new Wall(new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength)));
                        }
                        if (!leftWalls.Contains(new Wall(new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength))))
                        {
                            rightWalls.Add(new Wall(new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength)));
                        }
                    }
             */
        }


        public void GenerateGrid()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int x = i * 2 * wallLength;
                    int y = j * 2 * wallLength;
                    // left top corner
                    if (i == 0 && j == 0)
                    {                                                                           // 0:up, 1:left, 2:down, 3:right
                        cells[i, j] = new Cell(i, j, 2, new Point(x + 75, y + 100), new bool[4] { false, false, true, true });
                        leftOuterCells.Add(cells[i, j]);
                    }
                    // left bottom corner
                    else if (i == 0 && j == size - 1)
                    {
                        cells[i, j] = new Cell(i, j, 2, new Point(x + 75, y + 100), new bool[4] { true, false, false, true });
                        leftOuterCells.Add(cells[i, j]);
                    }
                    // right top corner
                    else if (i == size - 1 && j == 0)
                    {
                        cells[i, j] = new Cell(i, j, 2, new Point(x + 75, y + 100), new bool[4] { false, true, true, false });
                        rightOuterCells.Add(cells[i, j]);
                    }
                    // right bottom corner
                    else if (i == size - 1 && j == size - 1)
                    {
                        cells[i, j] = new Cell(i, j, 2, new Point(x + 75, y + 100), new bool[4] { true, true, false, false });
                        rightOuterCells.Add(cells[i, j]);
                    }

                    // most left side
                    else if (i == 0 && j > 0 && j < size - 1)
                    {                                                                           // 0:up, 1:left, 2:down, 3:right
                        cells[i, j] = new Cell(i, j, 3, new Point(x + 75, y + 100), new bool[4] { true, false, true, true });
                        leftOuterCells.Add(cells[i, j]);
                    }
                    // most top side
                    else if (i > 0 && i < size - 1 && j == 0)
                    {
                        cells[i, j] = new Cell(i, j, 3, new Point(x + 75, y + 100), new bool[4] { false, true, true, true });
                        //outerCells.Add(cells[i, j]);
                    }
                    // most right side
                    else if (i == size - 1 && j > 0 && j < size - 1)
                    {
                        cells[i, j] = new Cell(i, j, 3, new Point(x + 75, y + 100), new bool[4] { true, true, true, false });
                        rightOuterCells.Add(cells[i, j]);
                    }
                    // most down side
                    else if (i > 0 && i < size - 1 && j == size - 1)
                    {
                        cells[i, j] = new Cell(i, j, 3, new Point(x + 75, y + 100), new bool[4] { true, true, false, true });
                        //outerCells.Add(cells[i, j]);
                    }

                    // anywhere in middle
                    else
                    {
                        cells[i, j] = new Cell(i, j, 4, new Point(x + 75, y + 100), new bool[4] { true, true, true, true });
                    }
                }
            }

            GenerateMaze(); // might need to be used only once...
            CheckPath();
            AllWalls();
        }

        private void CheckPath()
        {
            Random random = new Random();
            int xStart, yStart, xEnd, yEnd;
            for (int i = 0; i < 2 * size; i++)
            {
                int x = -1;
                int y = -1;
                do
                {
                    x = random.Next(leftOuterCells.Count());
                    y = random.Next(rightOuterCells.Count());

                    start = leftOuterCells.ElementAt(x);
                    end = rightOuterCells.ElementAt(y);


                } while (Math.Abs(start.y - end.y) < size / 2);
                xStart = start.x;
                yStart = start.y;
                xEnd = end.x;
                yEnd = end.y;
                if (DFS(xStart, yStart, xEnd, yEnd))
                {
                    gotPath = true;
                    break;
                }
            }

        }

        public double DistanceBetweenTwoPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public void GenerateMaze()
        {
            Random random = new Random();
            int i = random.Next(size);
            int j = random.Next(size);

            Stack<Cell> stack = new Stack<Cell>();

            stack.Push(cells[i, j]);
            //cells[i, j].isVisited = true;
            int visited = 0;
            while (visited != size * size)
            {
                Cell cell = null;
                if (stack.Count == 0)
                {
                    cell = stack.Peek();
                }
                else
                {
                    i = random.Next(size);
                    j = random.Next(size);
                    cell = cells[i, j];
                    stack.Push(cell);
                }
                // 0:up, 1:left, 2:down, 3:right
                if (!cell.isVisited)
                {
                    cells[cell.x, cell.y].isVisited = true;
                    visited++;
                    int nextNexighbor = random.Next(cell.neighbours);
                    //Cell neighbourCell = null;
                    if (nextNexighbor == 0 && cells[cell.x, cell.y].directions[nextNexighbor])
                    {
                        stack.Push(cells[cell.x, cell.y - 1]);
                        cells[cell.x, cell.y].directions[0] = false;
                        cells[cell.x, cell.y - 1].directions[2] = false;
                    }
                    else if (nextNexighbor == 1 && cells[cell.x, cell.y].directions[nextNexighbor])
                    {
                        stack.Push(cells[cell.x - 1, cell.y]);
                        cells[cell.x, cell.y].directions[1] = false;
                        cells[cell.x - 1, cell.y].directions[3] = false;
                    }
                    else if (nextNexighbor == 2 && cells[cell.x, cell.y].directions[nextNexighbor])
                    {
                        stack.Push(cells[cell.x, cell.y + 1]);
                        cells[cell.x, cell.y].directions[2] = false;
                        cells[cell.x, cell.y + 1].directions[0] = false;
                    }
                    else if (nextNexighbor == 3 && cells[cell.x, cell.y].directions[nextNexighbor])
                    {
                        stack.Push(cells[cell.x + 1, cell.y]);
                        cells[cell.x, cell.y].directions[3] = false;
                        cells[cell.x + 1, cell.y].directions[1] = false;
                    }
                }
                else
                {
                    stack.Pop();
                }
            }

        }

        public void DrawMaze(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Red, 2);
            Pen pen3 = new Pen(Color.Green, 2);
            Pen pen4 = new Pen(Color.Blue, 2);

            /*
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // correct
                    if (!cells[i, j].directions[0])
                    {
                        g.DrawLine(pen, new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength));
                    }
                    if (!cells[i, j].directions[1])
                    {
                        g.DrawLine(pen, new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength));
                    }
                    if (!cells[i, j].directions[2])
                    {
                        g.DrawLine(pen, new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength));
                    }
                    if (!cells[i, j].directions[3])
                    {
                        g.DrawLine(pen, new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y - wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength));
                    }
                }
            }
            */
            foreach (Wall w in wallsToDraw)
            {
                //                g.DrawLine(pen, new Point(cells[i, j].centerPoint.X - wallLength, cells[i, j].centerPoint.Y + wallLength), new Point(cells[i, j].centerPoint.X + wallLength, cells[i, j].centerPoint.Y + wallLength));

                g.DrawLine(pen, w.start, w.end);
            }
            /*
            foreach (Wall w in topWalls)
            {
                g.DrawLine(pen, w.start, w.end);
            }
            foreach (Wall w in leftWalls)
            {
                g.DrawLine(pen2, w.start, w.end);
            }
            foreach (Wall w in rightWalls)
            {
                g.DrawLine(pen3, w.start, w.end);
            }
            foreach (Wall w in bottomWalls)
            {
                g.DrawLine(pen4, w.start, w.end);
            }
            */

            pen.Dispose();
            pen2.Dispose();
            pen3.Dispose();
            pen4.Dispose();

            // designating the start and end, with colors respectively
            Brush b1 = new SolidBrush(Color.Green);
            Brush b2 = new SolidBrush(Color.Red);
            Point[] points1 = {
                new Point(start.centerPoint.X - wallLength + 1, start.centerPoint.Y - wallLength + 1),
                new Point(start.centerPoint.X - wallLength + 1, start.centerPoint.Y + wallLength - 1),
                new Point(start.centerPoint.X + wallLength - 1, start.centerPoint.Y + wallLength - 1),
                new Point(start.centerPoint.X + wallLength - 1, start.centerPoint.Y - wallLength + 1) };
            Point[] points2 = {
                new Point(end.centerPoint.X - wallLength + 1, end.centerPoint.Y - wallLength + 1),
                new Point(end.centerPoint.X - wallLength + 1, end.centerPoint.Y + wallLength - 1),
                new Point(end.centerPoint.X + wallLength - 1, end.centerPoint.Y + wallLength - 1),
                new Point(end.centerPoint.X + wallLength - 1, end.centerPoint.Y - wallLength + 1) };
            g.FillPolygon(b1, points1);
            g.FillPolygon(b2, points2);
            b1.Dispose();
            b2.Dispose();
        }

        public bool DFS(int x1, int y1, int x2, int y2)
        {

            Cell s = cells[x1, y1];
            Cell e = cells[x2, y2];

            int lenght = 0;
            bool[,] visited = new bool[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    visited[i, j] = false;
                }
            }
            visited[x1, y1] = true;
            Stack<Cell> stack = new Stack<Cell>();
            stack.Push(s);

            while (stack.Count() != 0)
            {
                Cell tmp = stack.Peek();
                Cell tmp2 = tmp;
                int direction = 4;
                for (int i = 0; i < 4; i++)
                {
                    if (tmp.directions[i])
                    {
                        direction = i;
                        if (direction == 0)
                        {
                            tmp2 = cells[tmp.x, tmp.y - 1];
                            if (!visited[tmp2.x, tmp2.y])
                            {
                                break;
                            }
                        }
                        else if (direction == 1)
                        {
                            tmp2 = cells[tmp.x - 1, tmp.y];
                            if (!visited[tmp2.x, tmp2.y])
                            {
                                break;
                            }
                        }
                        else if (direction == 2)
                        {
                            tmp2 = cells[tmp.x, tmp.y + 1];
                            if (!visited[tmp2.x, tmp2.y])
                            {
                                break;
                            }
                        }
                        else if (direction == 3)
                        {
                            tmp2 = cells[tmp.x + 1, tmp.y];
                            if (!visited[tmp2.x, tmp2.y])
                            {
                                break;
                            }
                        }

                    }
                }
                if (!visited[tmp2.x, tmp2.y])
                {
                    lenght++;
                    visited[tmp2.x, tmp2.y] = true;
                    stack.Push(tmp2);
                }
                else
                {
                    lenght--;
                    stack.Pop();
                }
                if (visited[e.x, e.y] && lenght > 5 * size)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
