namespace MazeProekt
{
    partial class FormComplete
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
            this.lblComplete = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.lblTimeScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.ForeColor = System.Drawing.Color.Yellow;
            this.lblComplete.Location = new System.Drawing.Point(301, 134);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(445, 95);
            this.lblComplete.TabIndex = 0;
            this.lblComplete.Text = "Complete";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblScore.Location = new System.Drawing.Point(309, 294);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(268, 47);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Your Score:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNext.Location = new System.Drawing.Point(561, 513);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(196, 51);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReplay.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReplay.Location = new System.Drawing.Point(317, 513);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(196, 51);
            this.btnReplay.TabIndex = 4;
            this.btnReplay.Text = "Replay";
            this.btnReplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // lblTimeScore
            // 
            this.lblTimeScore.AutoSize = true;
            this.lblTimeScore.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeScore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTimeScore.Location = new System.Drawing.Point(612, 294);
            this.lblTimeScore.Name = "lblTimeScore";
            this.lblTimeScore.Size = new System.Drawing.Size(0, 52);
            this.lblTimeScore.TabIndex = 5;
            // 
            // FormComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 998);
            this.Controls.Add(this.lblTimeScore);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblComplete);
            this.Name = "FormComplete";
            this.Text = "FormComplete";
            this.Load += new System.EventHandler(this.FormComplete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label lblTimeScore;
    }
}