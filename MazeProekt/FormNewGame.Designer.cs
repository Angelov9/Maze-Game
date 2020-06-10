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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(315, 282);
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
            this.txtName.Location = new System.Drawing.Point(328, 362);
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
            this.btnStartGame.Location = new System.Drawing.Point(703, 772);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(370, 72);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelGame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelGame.Location = new System.Drawing.Point(30, 772);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(151, 72);
            this.btnCancelGame.TabIndex = 3;
            this.btnCancelGame.Text = "Cancel";
            this.btnCancelGame.UseVisualStyleBackColor = false;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 998);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FormNewGame";
            this.Text = "FormNewGame";
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
    }
}