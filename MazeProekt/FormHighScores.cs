using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MazeProekt
{
    [Serializable]
    public partial class FormHighScores : Form
    {
        public List<Player> topPlayersEasy = new List<Player>();
        public List<Player> topPlayersMedium = new List<Player>();
        public List<Player> topPlayersHard = new List<Player>();
        public string fileName = "Maze2";
        public List<Player> topPlayers { get; set; }


        public FormHighScores()
        {
            this.topPlayers = new List<Player>();
            InitializeComponent();
            lbHighScores.Items.Clear();
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    IFormatter f = new BinaryFormatter();
                    topPlayersEasy = (List<Player>)f.Deserialize(fs);
                    topPlayersMedium = (List<Player>)f.Deserialize(fs);
                    topPlayersHard = (List<Player>)f.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                e.ToString();
                fileName = "Maze2";
            }

            Level();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            var startMenu = new FormStartMenu();
            startMenu.Show();
            this.Hide();
        }

        private void FormHighScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Level()
        {
            lbHighScores.Items.Clear();
            if (highScoreRbEasy.Checked)
            {
                this.topPlayers = FormStartMenu.topPlayersEasy;
            }
            else if (highScoreRbMedium.Checked)
            {
                this.topPlayers = FormStartMenu.topPlayersMedium;
            }
            else if (highScoreRbHard.Checked)
            {
                this.topPlayers = FormStartMenu.topPlayersHard;
            }

            this.topPlayers.Sort();
            if (this.topPlayers.Count < 5)
            {
                foreach (Player p in this.topPlayers)
                {
                    lbHighScores.Items.Add(p);
                }
            }
            else
            {
                for(int i = 0; i < 5; i++)
                {
                    lbHighScores.Items.Add(topPlayers.ElementAt(i));
                }
            }
        }

        private void highScoreRbEasy_CheckedChanged(object sender, EventArgs e)
        {
            Level();
        }

        private void highScoreRbMedium_CheckedChanged(object sender, EventArgs e)
        {
            Level();
        }

        private void highScoreRbHard_CheckedChanged(object sender, EventArgs e)
        {
            Level();
        }
    }
}
