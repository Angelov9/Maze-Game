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
    public partial class FormNewGame : Form
    {
        public int[] type { get; set; } = new int[3]{
            0,1,2
        };
        public FormNewGame()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            var game = new Form1(0, 0, txtName.Text, type[0]);
            if (newGameRbEasy.Checked)
            {
                game = new Form1(0, 0, txtName.Text, type[0]);
            }
            else if (newGameRbMedium.Checked)
            {
                game = new Form1(0, 0, txtName.Text, type[1]);
            }
            else if (newGameRbHard.Checked)
            {
                game = new Form1(0, 0, txtName.Text, type[2]);
            }
            game.Show();
            this.Hide();
        }

        private void btnCancelGame_Click(object sender, EventArgs e)
        {
            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Are you sure?", "Cancel Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (cancel == DialogResult.OK)
            {
                this.Hide();
                var startMenu = new FormStartMenu();
                startMenu.Show();
            }
           
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
         

            if (txtName.Text.Length == 0)
            {
                errorProvider1.SetError(txtName, "You must enter a name!");
                e.Cancel = true;
            }
            else
            {
               
               
                e.Cancel = false;
                txtName.Focus();
                errorProvider1.SetError(txtName, "");

            }

        }

        private void FormNewGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
