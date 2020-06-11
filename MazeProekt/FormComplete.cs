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
    [Serializable]
    public partial class FormComplete : Form
    {
        public int level { get; set; }
        public int time { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public FormComplete(int level, int time, string name, int type)
        {
            this.level = level;
            this.time = time;
            this.name = name;
            this.type = type;
            InitializeComponent();
            if (level == 9)
            {
                btnNext.Text = "Finish";
            }
            else
            {
                btnNext.Text = "Next";
            }
        }

        private void FormComplete_Load(object sender, EventArgs e)
        {
            lblTimeScore.Text = time.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (level != 9)
            {
                var game = new Form1(level + 1, time, name, type);
                game.Show();
                this.Hide();
            }
            else
            {
                var formStartMenu = new FormStartMenu();
                formStartMenu.Show();
                this.Hide();
            }
        }

        private void FormComplete_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
