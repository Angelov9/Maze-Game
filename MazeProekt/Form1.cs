using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MazeProekt
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Scene2 scena { get; set; }
        public Player player { get; set; }
        public int level { get; set; }
        public int time { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public bool first { get; set; }
        

        public string fileName = "Maze2";

        // levels for the game
        public int[] levelEasy = new int[]
        {
            11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };
        public int[] levelMedium = new int[]
        {
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30
        };
        public int[] levelHard = new int[]
        {
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40
        };



        public Form1(int level, int time, string name, int type)
        {
            first = true;
            this.level = level;
            this.time = time;
            this.name = name;
            this.type = type;
            if (this.type == 0)
            {
                scena = new Scene2(levelEasy[level], 10);
            }
            else if (this.type == 1)
            {
                scena = new Scene2(levelMedium[level], 10);
            }
            else if (this.type == 2)
            {
                scena = new Scene2(levelHard[level], 10);
            }
            DoubleBuffered = true;

            InitializeComponent();
           

            if (this.type == 0)
            {
                gameLblType.Text = "Easy";
            }
            else if (this.type == 1)
            {
                gameLblType.Text = "Medium";
            }
            else if (this.type == 2)
            {
                gameLblType.Text = "Hard";
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            gameLblLevel.Text = "Level: " + (level + 1);


            int w = 75 + (scena.size * 2 * scena.wall) + 75;
            int h = 100 + (scena.size * 2 * scena.wall) + 75;
            this.Width = w;
            this.Height = h;
            scena.Draw(e.Graphics);
            if (first)
            {
                player = new Player(name, scena.m.start.centerPoint);
                first = false;
            }
            player.Draw(e.Graphics);


        }

        bool finish = false;


        public double DistanceBetweenTwoPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >= 0)
            {
                time = time + 1;
                gameLblTime.Text = time + " Seconds";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            gameLblLevel.Text = "Level: " + (level + 1);
            gameLblTime.Text = time + " Seconds";

        }

        private void lblBtnBack_Click(object sender, EventArgs e)
        {
            var formStartMenu = new FormStartMenu();
            formStartMenu.Show();
            this.Hide();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
                bool touched = false;

                if (e.KeyCode == Keys.Left)
                {
                    foreach (Wall w in scena.m.leftWalls)
                    {
                        if (w.DistanceBetweenPointAndLineY(player.currentPoint.X - 5, player.currentPoint.Y) < player.radius && w.typeOfWall[1])
                        {
                            touched = true;
                        }
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    foreach (Wall w in scena.m.topWalls)
                    {
                        if (w.DistanceBetweenPointAndLineX(player.currentPoint.X, player.currentPoint.Y - 5) < player.radius && w.typeOfWall[0])
                        {
                            touched = true;
                        }
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    foreach (Wall w in scena.m.rightWalls)
                    {
                        if (w.DistanceBetweenPointAndLineY(player.currentPoint.X + 5, player.currentPoint.Y) < player.radius && w.typeOfWall[3])
                        {
                            touched = true;
                        }
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    foreach (Wall w in scena.m.bottomWalls)
                    {
                        if (w.DistanceBetweenPointAndLineX(player.currentPoint.X, player.currentPoint.Y + 5) < player.radius && w.typeOfWall[2])
                        {
                            touched = true;
                        }
                    }
                }

                if (!touched)
                {
                if (e.KeyCode == Keys.Left)
                  {
                      player.move(-4, 0);
                  }
                  else if (e.KeyCode == Keys.Up)
                  {
                      player.move(0, -4);
                  }
                  else if (e.KeyCode == Keys.Right)
                  {
                      player.move(4, 0);
                  }
                  else if (e.KeyCode == Keys.Down)
                  {
                      player.move(0, 4);
                  }
            }

            if (DistanceBetweenTwoPoints(player.currentPoint.X, player.currentPoint.Y, scena.m.end.centerPoint.X, scena.m.end.centerPoint.Y) < scena.wall)
                {
                    finish = true;
                }

                if (finish)
                {
                    if (level == 9)
                    {
                        player.time = this.time;
                        if (type == 0)
                        {
                            FormStartMenu.topPlayersEasy.Add(player);
                        }
                        else if (type == 1)
                        {
                            FormStartMenu.topPlayersMedium.Add(player);
                        }
                        else if (type == 2)
                        {
                            FormStartMenu.topPlayersHard.Add(player);
                        }
                        using (FileStream fs = new FileStream(fileName, FileMode.Create))
                        {
                            IFormatter f = new BinaryFormatter();
                            f.Serialize(fs, FormStartMenu.topPlayersEasy);
                            f.Serialize(fs, FormStartMenu.topPlayersMedium);
                            f.Serialize(fs, FormStartMenu.topPlayersHard);
                        }
                    }

                    var formCompelte = new FormComplete(level, time, name, type);
                    formCompelte.Show();
                    this.Hide();
                }

                Invalidate();
            }
        }
    }
    
    
