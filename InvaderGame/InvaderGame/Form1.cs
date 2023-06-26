using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace InvaderGame
{
    public partial class InvaderGame : Form
    {



        public InvaderGame()
        {
            InitializeComponent();

            KeyDown += Form1_KeyDown;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }
            else if (e.KeyCode == Keys.A)
            {
                MoveLeft();
            }
            else if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }
            else if (e.KeyCode == Keys.S)
            {
                MoveRight();
            }
            else if (e.KeyCode == Keys.Space && bullets.trueFlag)
            {
                bullets.trueFlag = false;

                Bulletlaunch();
            }
        }


        //クラス共通の変数
        public int EnemiesCount = 55; //敵の数
        private Bitmap canvas; //描画領域 
        private Enemy[] Enemies; //複数の敵を管理する配列
        private Brush brushes = Brushes.White; //敵を塗る配列
        private double nowTime = 0; //経過時間

        private Bullet bullets;//弾
        private double nowTimeB = 0; //弾の経過時間



        public void MoveLeft()
        {
            Point pt = pictureBoxSpaceship.Location;
            pt.X -= 10;
            if (pt.X <= -10)  //左端に来た時の判定
            {
                pt.X += 10;
            }
            pictureBoxSpaceship.Location = pt;


        }

        public void MoveRight()
        {
            Point pt = pictureBoxSpaceship.Location;
            pt.X += 10;
            if (pt.X >= 760)  //右端に来た時の判定
            {
                pt.X -= 10;
            }
            pictureBoxSpaceship.Location = pt;



        }

        private void Bulletlaunch()  //弾の発射処理
        {
            Point pt = pictureBoxSpaceship.Location;   //自機の位置に伴わせる
            bullets.PutBullet(pt.X + 40, pt.Y + 6);
            nowTimeB = 0;
            timerB.Start();
        }
        private void DrawBulletPictureBox()
        {

            //筆の作成
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            //四角（弾）の座標
            int x = 10;
            int y = 500;
            int height = pictureBox1.Height; //高さ
            int width = pictureBox1.Width; //幅
                                           //描画先とするImageオブジェクトを作成する
            if (canvas == null)
            {
                canvas = new Bitmap(width, height);
            }

            using (Graphics g = Graphics.FromImage(canvas))

                g.FillRectangle(whiteBrush, x, y, 10, 50);
            pictureBox1.Image = canvas;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var form = new Seiseki(label1.Text);

            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //Penオブジェクトの作成(幅5の白色)
            Pen whitePen = new Pen(Color.White, 5);

            //ダッシュ
            whitePen.DashStyle = DashStyle.Dash;
            //線を描画
            g.DrawLine(whitePen, 10, 500, 1300, 500);

            //ペンを解放する
            whitePen.Dispose();
            g.Dispose();

            //pictureBox1に表示する
            pictureBox1.Image = canvas;

            InitGraphics();
            SetStartPosition();
            //敵を描画
            DrawEnemyPictureBox();

            Enemies = new Enemy[EnemiesCount];
            for (int i = 0; i < EnemiesCount; i++)
            {
                Enemies[i] = new Enemy(pictureBox1, canvas, brushes);
            }
            Enemies[0].positionsX = 10;
            Enemies[0].positionsY = 10;

            for (int i = 0; i < 10; i++)
            {
                Enemies[i + 1].positionsX = Enemies[i].positionsX + 60;
                Enemies[i + 1].positionsY = Enemies[0].positionsY;
            }
            Enemies[11].positionsX = 10;
            Enemies[11].positionsY = 50;

            for (int i = 11; i < 21; i++)
            {
                Enemies[i + 1].positionsX = Enemies[i].positionsX + 60;
                Enemies[i + 1].positionsY = Enemies[11].positionsY;
            }

            Enemies[22].positionsX = 10;
            Enemies[22].positionsY = 90;

            for (int i = 22; i < 32; i++)
            {
                Enemies[i + 1].positionsX = Enemies[i].positionsX + 60;
                Enemies[i + 1].positionsY = Enemies[22].positionsY;
            }

            Enemies[33].positionsX = 10;
            Enemies[33].positionsY = 130;

            for (int i = 33; i < 43; i++)
            {
                Enemies[i + 1].positionsX = Enemies[i].positionsX + 60;
                Enemies[i + 1].positionsY = Enemies[33].positionsY;
            }

            Enemies[44].positionsX = 10;
            Enemies[44].positionsY = 170;

            for (int i = 44; i < 54; i++)
            {
                Enemies[i + 1].positionsX = Enemies[i].positionsX + 60;
                Enemies[i + 1].positionsY = Enemies[44].positionsY;
            }

            //for (int i = 0; i < Enemies.Length; i++)
            //{
            //    Enemies[i]. Move();
            //}




            bullets = new Bullet(pictureBox1, canvas, Brushes.White);
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
                canvas = new Bitmap(width, height);
            }

            using (Graphics g = Graphics.FromImage(canvas))

                g.FillRectangle(whiteBrush, x, y, 50, 30);
            pictureBox1.Image = canvas;
        }
        //配列の初期化、画面の初期設定を行う
        private void InitGraphics()
        {

            Enemies = new Enemy[EnemiesCount];

            //ブラシ色の設定
            brushes = Brushes.White;

        }
        //敵のインスタンス作成と列に敵を描く
        private void SetStartPosition()
        {
            //敵のインスタンス作成
            for (int i = 0; i < EnemiesCount; i++)
            {
                Enemies[i] = new Enemy(pictureBox1, canvas, brushes);
            }

            //タイマーをスタートさせる
            nowTime = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < EnemiesCount; i++)
            {
                Enemies[i].Move();

                if (Enemies[i].positionsY >= 475)
                {
                    //タイマーを停止
                    timer.Stop();
                    //次画面を非表示
                    this.Visible = false;

                    //成績画面2を表示
                    Seiseki f2 = new Seiseki(label1.Text);
                    f2.Show();
                    break;
                }

            }

            nowTime = nowTime + 1;

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void timerB_Tick(object sender, EventArgs e)
        {
            if (bullets.positionsY < 0)
            {
                bullets.trueFlag = true;
            }
            
                bullets.Move();
            
            nowTimeB = nowTimeB + 1;
            //if(HitJudge(Enemies[50], bullets))
            //{
            //    label1.Text = (int.Parse(label1.Text) + 1).ToString();
            //}


        }

        private bool HitJudge(Enemy enemy, Bullet bullets)
        {
            double c1 = (50) * (bullets.positionsY - enemy.positionsY) - (30) * (bullets.positionsX - enemy.positionsX);
            double c2 = (50) * (bullets.positionsY + 25 - enemy.positionsY) - (30) * (bullets.positionsX + 5 - enemy.positionsX);
            double c3 = (5) * (enemy.positionsY - bullets.positionsY) - (25) * (enemy.positionsX - bullets.positionsX);
            double c4 = (5) * (enemy.positionsY + 30 - bullets.positionsY) - (25) * (enemy.positionsX + 50 - bullets.positionsX);

            if (c1 * c2 < 0 && c3 * c4 < 0)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}