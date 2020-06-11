using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeProekt
{
    [Serializable]
    public partial class FormStartMenu : Form
    {
        public static List<Player> topPlayersEasy = new List<Player>();
        public static List<Player> topPlayersMedium = new List<Player>();
        public static List<Player> topPlayersHard = new List<Player>();
        public string fileName = "Maze2";
        public FormStartMenu()
        {
            InitializeComponent();
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

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                IFormatter f = new BinaryFormatter();
                f.Serialize(fs, topPlayersEasy);
                f.Serialize(fs, topPlayersMedium);
                f.Serialize(fs, topPlayersHard);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            var formNewGame = new FormNewGame();
            formNewGame.Show();
            this.Hide();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            var formHighScores = new FormHighScores(topPlayersEasy);
            formHighScores.Show();
            this.Hide();
        }

        private void FormStartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
