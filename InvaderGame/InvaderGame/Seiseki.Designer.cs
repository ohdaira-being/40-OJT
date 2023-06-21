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
            this.Continue = new System.Windows.Forms.Label();
            this.erabu = new System.Windows.Forms.Label();
            this.SCORE_LOGO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SCORE_Seiseki
            // 
            this.SCORE_Seiseki.AutoSize = true;
            this.SCORE_Seiseki.BackColor = System.Drawing.Color.Black;
            this.SCORE_Seiseki.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SCORE_Seiseki.ForeColor = System.Drawing.Color.White;
            this.SCORE_Seiseki.Location = new System.Drawing.Point(600, 365);
            this.SCORE_Seiseki.Name = "SCORE_Seiseki";
            this.SCORE_Seiseki.Size = new System.Drawing.Size(132, 144);
            this.SCORE_Seiseki.TabIndex = 0;
            this.SCORE_Seiseki.Text = "0";
            // 
            // Continue
            // 
            this.Continue.AutoSize = true;
            this.Continue.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Continue.ForeColor = System.Drawing.Color.White;
            this.Continue.Location = new System.Drawing.Point(544, 570);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(241, 52);
            this.Continue.TabIndex = 1;
            this.Continue.Text = "Continue?";
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // erabu
            // 
            this.erabu.AutoSize = true;
            this.erabu.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.erabu.ForeColor = System.Drawing.Color.White;
            this.erabu.Location = new System.Drawing.Point(617, 654);
            this.erabu.Name = "erabu";
            this.erabu.Size = new System.Drawing.Size(85, 40);
            this.erabu.TabIndex = 2;
            this.erabu.Text = "Y/S";
            this.erabu.Click += new System.EventHandler(this.erabu_Click);
            // 
            // SCORE_LOGO
            // 
            this.SCORE_LOGO.AutoSize = true;
            this.SCORE_LOGO.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SCORE_LOGO.ForeColor = System.Drawing.Color.White;
            this.SCORE_LOGO.Location = new System.Drawing.Point(420, 190);
            this.SCORE_LOGO.Name = "SCORE_LOGO";
            this.SCORE_LOGO.Size = new System.Drawing.Size(517, 144);
            this.SCORE_LOGO.TabIndex = 3;
            this.SCORE_LOGO.Text = "SCORE";
            // 
            // Seiseki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1378, 894);
            this.Controls.Add(this.SCORE_LOGO);
            this.Controls.Add(this.erabu);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.SCORE_Seiseki);
            this.Name = "Seiseki";
            this.Text = "Seiseki";
            this.Load += new System.EventHandler(this.Seiseki_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SCORE_Seiseki;
        private System.Windows.Forms.Label Continue;
        private System.Windows.Forms.Label erabu;
        private System.Windows.Forms.Label SCORE_LOGO;
    }
}