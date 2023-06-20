using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace InvaderGame
{
    public partial class InvaderGame : Form
    {
        public InvaderGame()
        {
            InitializeComponent();
        }

        //クラス共通の変数
        private Bitmap canvas; //描画領域 
        private Enemy[] Enemies; //複数の敵を管理する配列
        private int EnemiesCount = 11; //敵の数
        private Brush[] brushes; //敵を塗る配列
        private double nowTime = 0; //経過時間
        private int positionY; //敵のY座標
        
    


        private void Form1_Load(object sender, EventArgs e)
        {
            DrawEnemyPictureBox();
            Enemies = new Enemy[EnemiesCount];
            for (int i = 0; i < EnemiesCount; i++)
            {
                Enemies[i] = new Enemy(pictureBox1, canvas, brushes[i]);
            }

            for (int i = 0; i < Enemies.Length; i++)
            {
                Enemies[i] = Move();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SCOREBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void DrawEnemyPictureBox()
        {
            //筆の作成
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            //四角（敵）の大きさ
            int x = 10;
            int y = 10;
            int height = pictureBox1.Height; //高さ
            int width = pictureBox1.Width; //幅
            //描画先とするImageオブジェクトを作成する
            if (canvas == null)
            {
                Bitmap canvas = new Bitmap(width, height);
            }
        
         using (Graphics g = Graphics.FromImage(canvas))

            g.FillRectangle(whiteBrush, x, y, 50, 30);
            pictureBox1.Image = canvas;
        }
        //配列の初期化、画面の初期設定を行う
        private void InitGraphics()
        {
            brushes = new Brush[EnemiesCount];
            Enemies = new Enemy[EnemiesCount];

            //ブラシ色の設定
            brushes[0] = Brushes.White;
            brushes[2] = Brushes.White;
            brushes[3] = Brushes.White;
            brushes[4] = Brushes.White;
            brushes[5] = Brushes.White;
            brushes[6] = Brushes.White;
            brushes[7] = Brushes.White;
            brushes[8] = Brushes.White;
            brushes[9] = Brushes.White;
            brushes[10] = Brushes.White;
        }
        //敵のインスタンス作成と列に敵を描く
        private void SetStartPosition()
        {
            //敵のインスタンス作成
            for (int i = 0; i < EnemiesCount; i++)
            {
                Enemies[i] = new Enemy(pictureBox1, canvas, brushes[i]);
            }
            //列に敵を描く

            int MaxY = pictureBox1.Height;
            int MaxX = pictureBox1.Width;

            SetEnemies(MaxX, MaxY);

           //タイマーをスタートさせる
            nowTime = 0;
            timer.Start();
        }
        //引数の位置情報を利用して列に敵を描く
        private void SetEnemies(int x, int y)
        {
            int MaxY = pictureBox1.Height;
            int MaxX = pictureBox1.Width;
            int NextX;
            int NextY;

            for(int i = 0; i < EnemiesCount; i++)
            {
                NextX = 
                NextY = 
            }
        }
    }
}