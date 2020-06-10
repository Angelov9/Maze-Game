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
    public partial class FormNewGame : Form
    {
        public FormNewGame()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            var game = new Form1();
            game.Show();
            this.Hide();
        }

        private void btnCancelGame_Click(object sender, EventArgs e)
        {
            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Are you sure?", "Cancel Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (cancel == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                errorProvider1.SetError(txtName, "You must enter a name!");
                e.Cancel = true;


            }
        
          


        }
    }
}
