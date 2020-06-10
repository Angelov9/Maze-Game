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
    public partial class FormStartMenu : Form
    {
        public FormStartMenu()
        {
            InitializeComponent();
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
            var formHighScores = new FormHighScores();
            formHighScores.Show();
            this.Hide();
        }

   
    }
}
