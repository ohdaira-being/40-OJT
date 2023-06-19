namespace InvaderGame
{
    partial class InvaderGame
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SCORE = new System.Windows.Forms.Label();
            this.SCOREBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SCORE
            // 
            this.SCORE.AutoSize = true;
            this.SCORE.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SCORE.Location = new System.Drawing.Point(1119, 15);
            this.SCORE.Name = "SCORE";
            this.SCORE.Size = new System.Drawing.Size(129, 36);
            this.SCORE.TabIndex = 0;
            this.SCORE.Text = "SCORE";
            this.SCORE.Click += new System.EventHandler(this.label1_Click);
            // 
            // SCOREBox
            // 
            this.SCOREBox.BackColor = System.Drawing.Color.Black;
            this.SCOREBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SCOREBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SCOREBox.ForeColor = System.Drawing.Color.White;
            this.SCOREBox.Location = new System.Drawing.Point(1266, 15);
            this.SCOREBox.Name = "SCOREBox";
            this.SCOREBox.Size = new System.Drawing.Size(100, 36);
            this.SCOREBox.TabIndex = 1;
            this.SCOREBox.Text = "0";
            this.SCOREBox.TextChanged += new System.EventHandler(this.SCOREBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1379, 902);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // InvaderGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1378, 894);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SCOREBox);
            this.Controls.Add(this.SCORE);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "InvaderGame";
            this.Text = "インベーダーゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SCORE;
        private System.Windows.Forms.TextBox SCOREBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

