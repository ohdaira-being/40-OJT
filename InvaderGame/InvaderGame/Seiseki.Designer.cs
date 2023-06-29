namespace InvaderGame
{
    partial class Seiseki
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
            this.SCORE_Seiseki = new System.Windows.Forms.Label();
            this.SCORE_LOGO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SCORE_Seiseki
            // 
            this.SCORE_Seiseki.AutoSize = true;
            this.SCORE_Seiseki.BackColor = System.Drawing.Color.Black;
            this.SCORE_Seiseki.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SCORE_Seiseki.ForeColor = System.Drawing.Color.White;
            this.SCORE_Seiseki.Location = new System.Drawing.Point(570, 365);
            this.SCORE_Seiseki.Name = "SCORE_Seiseki";
            this.SCORE_Seiseki.Size = new System.Drawing.Size(132, 144);
            this.SCORE_Seiseki.TabIndex = 0;
            this.SCORE_Seiseki.Text = "0";
            this.SCORE_Seiseki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SCORE_Seiseki.Click += new System.EventHandler(this.SCORE_Seiseki_Click);
            // 
            // SCORE_LOGO
            // 
            this.SCORE_LOGO.AutoSize = true;
            this.SCORE_LOGO.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SCORE_LOGO.ForeColor = System.Drawing.Color.White;
            this.SCORE_LOGO.Location = new System.Drawing.Point(373, 190);
            this.SCORE_LOGO.Name = "SCORE_LOGO";
            this.SCORE_LOGO.Size = new System.Drawing.Size(517, 144);
            this.SCORE_LOGO.TabIndex = 3;
            this.SCORE_LOGO.Text = "SCORE";
            this.SCORE_LOGO.Click += new System.EventHandler(this.SCORE_LOGO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(470, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "\r\n";
            // 
            // Seiseki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1378, 894);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SCORE_LOGO);
            this.Controls.Add(this.SCORE_Seiseki);
            this.Name = "Seiseki";
            this.Text = "Seiseki";
            this.Load += new System.EventHandler(this.Seiseki_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SCORE_Seiseki;
        private System.Windows.Forms.Label SCORE_LOGO;
        private System.Windows.Forms.Label label1;
    }
}