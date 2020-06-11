namespace MazeProekt
{
    partial class FormHighScores
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
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lbHighScores = new System.Windows.Forms.ListBox();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.highScoreRbHard = new System.Windows.Forms.RadioButton();
            this.highScoreRbMedium = new System.Windows.Forms.RadioButton();
            this.highScoreRbEasy = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.BackColor = System.Drawing.SystemColors.Control;
            this.lblHighScores.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScores.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHighScores.Location = new System.Drawing.Point(2, 35);
            this.lblHighScores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(686, 114);
            this.lblHighScores.TabIndex = 0;
            this.lblHighScores.Text = "High  Scores";
            // 
            // lbHighScores
            // 
            this.lbHighScores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbHighScores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighScores.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbHighScores.FormattingEnabled = true;
            this.lbHighScores.ItemHeight = 37;
            this.lbHighScores.Items.AddRange(new object[] {
            ""});
            this.lbHighScores.Location = new System.Drawing.Point(119, 199);
            this.lbHighScores.Margin = new System.Windows.Forms.Padding(2);
            this.lbHighScores.Name = "lbHighScores";
            this.lbHighScores.Size = new System.Drawing.Size(431, 189);
            this.lbHighScores.TabIndex = 1;
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturnToMenu.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMenu.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReturnToMenu.Location = new System.Drawing.Point(119, 413);
            this.btnReturnToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(430, 58);
            this.btnReturnToMenu.TabIndex = 3;
            this.btnReturnToMenu.Text = "Return to Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // highScoreRbHard
            // 
            this.highScoreRbHard.AutoSize = true;
            this.highScoreRbHard.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold);
            this.highScoreRbHard.ForeColor = System.Drawing.SystemColors.Highlight;
            this.highScoreRbHard.Location = new System.Drawing.Point(400, 152);
            this.highScoreRbHard.Name = "highScoreRbHard";
            this.highScoreRbHard.Size = new System.Drawing.Size(83, 26);
            this.highScoreRbHard.TabIndex = 31;
            this.highScoreRbHard.Text = "Hard";
            this.highScoreRbHard.UseVisualStyleBackColor = true;
            this.highScoreRbHard.CheckedChanged += new System.EventHandler(this.highScoreRbHard_CheckedChanged);
            // 
            // highScoreRbMedium
            // 
            this.highScoreRbMedium.AutoSize = true;
            this.highScoreRbMedium.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold);
            this.highScoreRbMedium.ForeColor = System.Drawing.SystemColors.Highlight;
            this.highScoreRbMedium.Location = new System.Drawing.Point(279, 152);
            this.highScoreRbMedium.Name = "highScoreRbMedium";
            this.highScoreRbMedium.Size = new System.Drawing.Size(108, 26);
            this.highScoreRbMedium.TabIndex = 30;
            this.highScoreRbMedium.Text = "Medium";
            this.highScoreRbMedium.UseVisualStyleBackColor = true;
            this.highScoreRbMedium.CheckedChanged += new System.EventHandler(this.highScoreRbMedium_CheckedChanged);
            // 
            // highScoreRbEasy
            // 
            this.highScoreRbEasy.AutoSize = true;
            this.highScoreRbEasy.Checked = true;
            this.highScoreRbEasy.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold);
            this.highScoreRbEasy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.highScoreRbEasy.Location = new System.Drawing.Point(187, 152);
            this.highScoreRbEasy.Name = "highScoreRbEasy";
            this.highScoreRbEasy.Size = new System.Drawing.Size(77, 26);
            this.highScoreRbEasy.TabIndex = 29;
            this.highScoreRbEasy.TabStop = true;
            this.highScoreRbEasy.Text = "Easy";
            this.highScoreRbEasy.UseVisualStyleBackColor = true;
            this.highScoreRbEasy.CheckedChanged += new System.EventHandler(this.highScoreRbEasy_CheckedChanged);
            // 
            // FormHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 501);
            this.Controls.Add(this.highScoreRbHard);
            this.Controls.Add(this.highScoreRbMedium);
            this.Controls.Add(this.highScoreRbEasy);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.lbHighScores);
            this.Controls.Add(this.lblHighScores);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High Scores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHighScores_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.ListBox lbHighScores;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.RadioButton highScoreRbHard;
        private System.Windows.Forms.RadioButton highScoreRbMedium;
        private System.Windows.Forms.RadioButton highScoreRbEasy;
    }
}