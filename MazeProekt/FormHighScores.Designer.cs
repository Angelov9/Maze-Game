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
            this.SuspendLayout();
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.BackColor = System.Drawing.SystemColors.Control;
            this.lblHighScores.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScores.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHighScores.Location = new System.Drawing.Point(101, 33);
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
            this.lbHighScores.Location = new System.Drawing.Point(264, 178);
            this.lbHighScores.Name = "lbHighScores";
            this.lbHighScores.Size = new System.Drawing.Size(573, 510);
            this.lbHighScores.TabIndex = 1;
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReturnToMenu.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMenu.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReturnToMenu.Location = new System.Drawing.Point(264, 716);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(573, 72);
            this.btnReturnToMenu.TabIndex = 3;
            this.btnReturnToMenu.Text = "Return to Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // FormHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 998);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.lbHighScores);
            this.Controls.Add(this.lblHighScores);
            this.Name = "FormHighScores";
            this.Text = "FormHighScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.ListBox lbHighScores;
        private System.Windows.Forms.Button btnReturnToMenu;
    }
}