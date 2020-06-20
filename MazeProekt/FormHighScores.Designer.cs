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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHighScores));
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
            this.lblHighScores.Location = new System.Drawing.Point(3, 43);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(858, 142);
            this.lblHighScores.TabIndex = 0;
            this.lblHighScores.Text = "High  Scores";
            // 
            // lbHighScores
            // 
            this.lbHighScores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbHighScores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighScores.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbHighScores.FormattingEnabled = true;
            this.lbHighScores.ItemHeight = 46;
            this.lbHighScores.Items.AddRange(new object[] {
            ""});
            this.lbHighScores.Location = new System.Drawing.Point(159, 245);
            this.lbHighScores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbHighScores.Name = "lbHighScores";
            this.lbHighScores.Size = new System.Drawing.Size(573, 188);
            this.lbHighScores.TabIndex = 1;
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturnToMenu.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMenu.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReturnToMenu.Location = new System.Drawing.Point(159, 508);
            this.btnReturnToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(573, 71);
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
            this.highScoreRbHard.Location = new System.Drawing.Point(533, 187);
            this.highScoreRbHard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highScoreRbHard.Name = "highScoreRbHard";
            this.highScoreRbHard.Size = new System.Drawing.Size(104, 33);
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
            this.highScoreRbMedium.Location = new System.Drawing.Point(372, 187);
            this.highScoreRbMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highScoreRbMedium.Name = "highScoreRbMedium";
            this.highScoreRbMedium.Size = new System.Drawing.Size(134, 33);
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
            this.highScoreRbEasy.Location = new System.Drawing.Point(249, 187);
            this.highScoreRbEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highScoreRbEasy.Name = "highScoreRbEasy";
            this.highScoreRbEasy.Size = new System.Drawing.Size(94, 33);
            this.highScoreRbEasy.TabIndex = 29;
            this.highScoreRbEasy.TabStop = true;
            this.highScoreRbEasy.Text = "Easy";
            this.highScoreRbEasy.UseVisualStyleBackColor = true;
            this.highScoreRbEasy.CheckedChanged += new System.EventHandler(this.highScoreRbEasy_CheckedChanged);
            // 
            // FormHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 617);
            this.Controls.Add(this.highScoreRbHard);
            this.Controls.Add(this.highScoreRbMedium);
            this.Controls.Add(this.highScoreRbEasy);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.lbHighScores);
            this.Controls.Add(this.lblHighScores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze Game";
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