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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            KeyDown += Form_KeyDown;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\kurosu\Desktop\OJTインベーダーゲーム\InvaderGame\InvaderGame\Image\タイトルロゴ(黒背景).png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //次画面を非表示
                this.Visible = false;

                //成績画面2を表示
                InvaderGame f1 = new InvaderGame();
                f1.Show();
            }
         
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
