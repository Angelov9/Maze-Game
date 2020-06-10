using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeProekt
{
    public partial class Form1 : Form
    {
        public Scene2 scena { get; set; }
        public Player player { get; set; }
        public int[] levelSize = new int[]
        {
            27,28,29,30,31,32,33,34,35,36
        };
        public int level { get; set; }
        public bool first { get; set; }

        public Form1()
        {
            // best maze is from 25 to 36
            // every size could be as a level...
            level = 1;
            scena = new Scene2(10, 20);// levelSize[level]);
            DoubleBuffered = true;
            player = new Player("Filip", scena.m.start.centerPoint);
            first = true;
       
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lblLevel.Text = "Level: " + level;
            //lblTimer.Text = "30 Seconds";
            //btnRefresh.Visible = false;
            int w = 75 + (scena.size * 2 * scena.wall) + 75;
            int h = 100 + (scena.size * 2 * scena.wall) + 75;
            //this.Width = w;
            //this.Height = h;
            scena.Draw(e.Graphics);
            if (first)
            {
                player = new Player("Filip", scena.m.start.centerPoint);
                first = false;
                /*
                foreach (Wall wa in scena.m.leftWalls)
                {
                    listBox1.Items.Add(wa.ToString());
                }
                foreach (Wall wa in scena.m.topWalls)
                {
                    listBox1.Items.Add(wa.ToString());
                }
                foreach (Wall wa in scena.m.rightWalls)
                {
                    listBox1.Items.Add(wa.ToString());
                }
                foreach (Wall wa in scena.m.bottomWalls)
                {
                    listBox1.Items.Add(wa.ToString());
                }
                */
                foreach (Wall wa in scena.m.wallsToDraw)
                {
                    listBox1.Items.Add(wa.ToString());
                }
                listBox1.Enabled = false;
                label2.Text = listBox1.Items.Count.ToString();
            }
            player.Draw(e.Graphics);
        }

        bool finish = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool touched = false;
            
            if (e.KeyCode == Keys.Left)
            {
                foreach (Wall w in scena.m.leftWalls)
                {
                    //                    if (w.DistanceBetweenPointAndLineY(player.currentPoint.X - 5, player.currentPoint.Y) <= player.radius)
                    if (w.DistanceBetweenPointAndLineY(player.currentPoint.X - 5, player.currentPoint.Y) < player.radius && w.typeOfWall[1])
                    {
                        touched = true;
                    }
                }
                //player.move(-5, 0);
            }
            else if (e.KeyCode == Keys.Up)
            {
                foreach (Wall w in scena.m.topWalls)
                {
                    //                    if (w.DistanceBetweenPointAndLineX(player.currentPoint.X, player.currentPoint.Y - 5) <= player.radius)
                    if (w.DistanceBetweenPointAndLineX(player.currentPoint.X, player.currentPoint.Y - 5) < player.radius && w.typeOfWall[0])
                    {
                        touched = true;
                    }
                }

                //player.move(0, -5);
            }
            else if (e.KeyCode == Keys.Right)
            {
                foreach (Wall w in scena.m.rightWalls)
                {
                    //                    if (w.DistanceBetweenPointAndLineY(player.currentPoint.X + 5, player.currentPoint.Y) <= player.radius)
                    if (w.DistanceBetweenPointAndLineY(player.currentPoint.X + 5, player.currentPoint.Y) < player.radius && w.typeOfWall[3])
                    {
                        touched = true;
                    }
                }

                //player.move(5, 0);
            }
            else if (e.KeyCode == Keys.Down)
            {
                foreach (Wall w in scena.m.bottomWalls)
                {
                    //                    if (w.DistanceBetweenPointAndLineX(player.currentPoint.X, player.currentPoint.Y + 5) <= player.radius)
                    if (w.DistanceBetweenPointAndLineX(player.currentPoint.X, player.currentPoint.Y + 5) < player.radius && w.typeOfWall[2])
                    {
                        touched = true;
                    }
                }

                //player.move(0, 5);
            }
            /*
            bool touched = false;
            foreach (Wall w in scena.m.walls)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (w.DistanceBetweenPointAndLine(player.currentPoint.X - 5, player.currentPoint.Y) <= player.radius * 2)
                    {
                        touched = true;
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (w.DistanceBetweenPointAndLine(player.currentPoint.X - 5, player.currentPoint.Y) <= player.radius * 2)
                    {
                        touched = true;
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (w.DistanceBetweenPointAndLine(player.currentPoint.X - 5, player.currentPoint.Y) <= player.radius * 2)
                    {
                        touched = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (w.DistanceBetweenPointAndLine(player.currentPoint.X - 5, player.currentPoint.Y) <= player.radius * 2)
                    {
                        touched = true;
                    }
                }
            }
            */
            if (!touched)
            {
                if (e.KeyCode == Keys.Left)
                {
                    player.move(-5, 0);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    player.move(0, -5);
                }
                else if (e.KeyCode == Keys.Right)
                {
                    player.move(5, 0);
                }
                else if (e.KeyCode == Keys.Down)
                {
                    player.move(0, 5);
                }
            }

           if(player.currentPoint == scena.m.end.centerPoint)
            {
                finish = true;
            }

            if (finish)
            {
                var formCompelte = new FormComplete();
                formCompelte.Show();
                this.Hide();
            }



            label1.Text = string.Format("{0} {1}", player.currentPoint.X, player.currentPoint.Y);
            Invalidate();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Enabled)
            {
                listBox1.Enabled = false;

            }
            else
            {
                listBox1.Enabled = true;
            }
        }
       public static int time= 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >= 0 )
            {
                time= time + 1;
                lblTimer.Text = time + " Seconds";


            }
       

        }


      
    }
}
