using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProekt
{
    /**
     * Custom class to represent a cell in a grid similar to an Excel worksheet
     * A cell contains:
     *      - neighbours: how much cells are neighbours to this cell, ex: all four corners in a 
     *      grid have only 2, a cell between two corners have 3 and a cell in the middle have 4
     *      - isVisited: to know if the cell is already visited while generating the maze, for 
     *      more check the function GenerateMaze() in Maze2.cs
     *      - centerPoint: point in the middle of a cell, used to help drawing the of the walls
     *      and start and finish
     *      - directions: array of 4 elements specifiying which side of the cell has a neighbour
     *      the order is this: 0:up, 1:left, 2:down, 3:right
     *      - x,y: id of the cell in a matrix, used to easily find a cell in the matrix,(matrix 
     *      that contains all the cells and have an imaginary representation for a grid)
     *      - constructor: it requires the id of the cell, the central point and the directions 
     *      for the neighbours
     */
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
