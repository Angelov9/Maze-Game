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
    public partial class FormHighScores : Form
    {
        public FormHighScores()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            var startMenu = new FormStartMenu();
            startMenu.Show();
            this.Hide();
        }
    }
}
