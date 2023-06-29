using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvaderGame
{
    public partial class Seiseki : Form
    {
        private string _str;
        public Seiseki(string str)
        {
            InitializeComponent();
            KeyDown += Form_KeyDown;
            _str = str;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\kurosu\Desktop\OJTインベーダーゲーム\InvaderGame\InvaderGame\Image\スコア.png");

        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y)
            {
                //次画面を非表示
                this.Visible = false;

                //スタート画面を表示
                StartForm f1 = new StartForm();
                f1.Show();
            }
            if (e.KeyCode == Keys.N)
            {
                //画面を閉じる
                this.Close();

            }
        }
            private void Continue_Click(object sender, EventArgs e)
        {

        }

        private void erabu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
 
        private void Seiseki_Load(object sender, EventArgs e)
        {
            SCORE_Seiseki.Text = $@"{_str}";

            if(SCORE_Seiseki.Text == "550")
            {
                label1.Text = "Congratulation!!";
            }
        }

        private void SCORE_Seiseki_Click(object sender, EventArgs e)
        {

        }

        private void SCORE_LOGO_Click(object sender, EventArgs e)
        {

        }
    }
}
