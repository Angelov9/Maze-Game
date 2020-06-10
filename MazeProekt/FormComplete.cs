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
    public partial class FormComplete : Form
    {
        public FormComplete()
        {
            InitializeComponent();
        }

        private void FormComplete_Load(object sender, EventArgs e)
        {
            lblTimeScore.Text = Form1.time.ToString();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            Form1.time = 0;
            var game = new Form1();
            game.Show();
            this.Hide();
      

        }
    }
}
