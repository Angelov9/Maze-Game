namespace MazeProekt
{
    partial class FormNewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewGame));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.newGameRbHard = new System.Windows.Forms.RadioButton();
            this.newGameRbMedium = new System.Windows.Forms.RadioButton();
            this.newGameRbEasy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(69, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(208, 71);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtName.Location = new System.Drawing.Point(83, 128);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(460, 46);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStartGame.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnStartGame.Location = new System.Drawing.Point(227, 276);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(371, 71);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelGame.CausesValidation = false;
            this.btnCancelGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelGame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelGame.Location = new System.Drawing.Point(43, 276);
            this.btnCancelGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(151, 71);
            this.btnCancelGame.TabIndex = 3;
            this.btnCancelGame.Text = "Cancel";
            this.btnCancelGame.UseVisualStyleBackColor = false;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // newGameRbHard
            // 
            this.newGameRbHard.AutoSize = true;
            this.newGameRbHard.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold);
            this.newGameRbHard.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newGameRbHard.Location = new System.Drawing.Point(388, 209);
            this.newGameRbHard.Margin = new System.Windows.Forms.Padding(4);
            this.newGameRbHard.Name = "newGameRbHard";
            this.newGameRbHard.Size = new System.Drawing.Size(104, 33);
            this.newGameRbHard.TabIndex = 31;
            this.newGameRbHard.Text = "Hard";
            this.newGameRbHard.UseVisualStyleBackColor = true;
            // 
            // newGameRbMedium
            // 
            this.newGameRbMedium.AutoSize = true;
            this.newGameRbMedium.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold);
            this.newGameRbMedium.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newGameRbMedium.Location = new System.Drawing.Point(227, 209);
            this.newGameRbMedium.Margin = new System.Windows.Forms.Padding(4);
            this.newGameRbMedium.Name = "newGameRbMedium";
            this.newGameRbMedium.Size = new System.Drawing.Size(134, 33);
            this.newGameRbMedium.TabIndex = 30;
            this.newGameRbMedium.Text = "Medium";
            this.newGameRbMedium.UseVisualStyleBackColor = true;
            // 
            // newGameRbEasy
            // 
            this.newGameRbEasy.AutoSize = true;
            this.newGameRbEasy.Checked = true;
            this.newGameRbEasy.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold);
            this.newGameRbEasy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newGameRbEasy.Location = new System.Drawing.Point(104, 209);
            this.newGameRbEasy.Margin = new System.Windows.Forms.Padding(4);
            this.newGameRbEasy.Name = "newGameRbEasy";
            this.newGameRbEasy.Size = new System.Drawing.Size(94, 33);
            this.newGameRbEasy.TabIndex = 29;
            this.newGameRbEasy.TabStop = true;
            this.newGameRbEasy.Text = "Easy";
            this.newGameRbEasy.UseVisualStyleBackColor = true;
            // 
            // FormNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 383);
            this.Controls.Add(this.newGameRbHard);
            this.Controls.Add(this.newGameRbMedium);
            this.Controls.Add(this.newGameRbEasy);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewGame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnCancelGame;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton newGameRbHard;
        private System.Windows.Forms.RadioButton newGameRbMedium;
        private System.Windows.Forms.RadioButton newGameRbEasy;
    }
}