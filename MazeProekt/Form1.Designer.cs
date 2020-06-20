namespace MazeProekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameLblTime = new System.Windows.Forms.Label();
            this.gameLblLevel = new System.Windows.Forms.Label();
            this.gameLblType = new System.Windows.Forms.Label();
            this.lblBackToStartManu = new System.Windows.Forms.Label();
            this.lblBtnBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameLblTime
            // 
            this.gameLblTime.AutoSize = true;
            this.gameLblTime.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLblTime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gameLblTime.Location = new System.Drawing.Point(241, 64);
            this.gameLblTime.Name = "gameLblTime";
            this.gameLblTime.Size = new System.Drawing.Size(168, 35);
            this.gameLblTime.TabIndex = 24;
            this.gameLblTime.Text = "0 Seconds";
            // 
            // gameLblLevel
            // 
            this.gameLblLevel.AutoSize = true;
            this.gameLblLevel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLblLevel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gameLblLevel.Location = new System.Drawing.Point(31, 64);
            this.gameLblLevel.Name = "gameLblLevel";
            this.gameLblLevel.Size = new System.Drawing.Size(111, 35);
            this.gameLblLevel.TabIndex = 23;
            this.gameLblLevel.Text = "Level:";
            // 
            // gameLblType
            // 
            this.gameLblType.AutoSize = true;
            this.gameLblType.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLblType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gameLblType.Location = new System.Drawing.Point(12, 32);
            this.gameLblType.Name = "gameLblType";
            this.gameLblType.Size = new System.Drawing.Size(130, 35);
            this.gameLblType.TabIndex = 25;
            this.gameLblType.Text = "Medium";
            // 
            // lblBackToStartManu
            // 
            this.lblBackToStartManu.AutoSize = true;
            this.lblBackToStartManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBackToStartManu.Image = ((System.Drawing.Image)(resources.GetObject("lblBackToStartManu.Image")));
            this.lblBackToStartManu.Location = new System.Drawing.Point(238, 8);
            this.lblBackToStartManu.Name = "lblBackToStartManu";
            this.lblBackToStartManu.Size = new System.Drawing.Size(0, 51);
            this.lblBackToStartManu.TabIndex = 26;
            // 
            // lblBtnBack
            // 
            this.lblBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("lblBtnBack.Image")));
            this.lblBtnBack.Location = new System.Drawing.Point(305, 32);
            this.lblBtnBack.Name = "lblBtnBack";
            this.lblBtnBack.Size = new System.Drawing.Size(25, 27);
            this.lblBtnBack.TabIndex = 27;
            this.lblBtnBack.Text = "              ";
            this.lblBtnBack.Click += new System.EventHandler(this.lblBtnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 998);
            this.Controls.Add(this.lblBtnBack);
            this.Controls.Add(this.lblBackToStartManu);
            this.Controls.Add(this.gameLblType);
            this.Controls.Add(this.gameLblTime);
            this.Controls.Add(this.gameLblLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameLblTime;
        private System.Windows.Forms.Label gameLblLevel;
        private System.Windows.Forms.Label gameLblType;
        private System.Windows.Forms.Label lblBackToStartManu;
        private System.Windows.Forms.Label lblBtnBack;
    }
}