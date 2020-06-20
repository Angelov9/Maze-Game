namespace MazeProekt
{
    partial class FormStartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartMenu));
            this.lblMazeLogo = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMazeLogo
            // 
            this.lblMazeLogo.AutoSize = true;
            this.lblMazeLogo.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMazeLogo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMazeLogo.Location = new System.Drawing.Point(97, 39);
            this.lblMazeLogo.Name = "lblMazeLogo";
            this.lblMazeLogo.Size = new System.Drawing.Size(361, 142);
            this.lblMazeLogo.TabIndex = 0;
            this.lblMazeLogo.Text = "MAZE";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNewGame.Location = new System.Drawing.Point(151, 240);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(229, 50);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHighScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHighScore.Location = new System.Drawing.Point(151, 327);
            this.btnHighScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(229, 50);
            this.btnHighScore.TabIndex = 2;
            this.btnHighScore.Text = "High Scores";
            this.btnHighScore.UseVisualStyleBackColor = false;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuit.Location = new System.Drawing.Point(151, 417);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(229, 50);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FormStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 506);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblMazeLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStartMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMazeLogo;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnQuit;
    }
}