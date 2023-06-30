using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;



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
        public int score;  //スコア
        private Bitmap canvas; //描画領域 
        private Enemy[] Enemies; //複数の敵を管理する配列
        private Brush brushes = Brushes.White; //敵を塗る配列
        private double nowTime = 0; //経過時間
        private List<Enemy> EnemyList;
        private string jikipath = @"..\..\Image\Jiki.png";
        private string enemypath = @"..\..\Image\InvaderM.png";




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
            if (pt.X >= 780)  //右端に来た時の判定
            {
                pt.X -= 10;
            }
            pictureBoxSpaceship.Location = pt;



        }

        private void Bulletlaunch()  //弾の発射処理
        {
            Point pt = pictureBoxSpaceship.Location;   //自機の位置に伴わせる
            bullets.PutBullet(pt.X + 35, pt.Y + 10);
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
            ////描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            ////ImageオブジェクトのGraphicsオブジェクトを作成する
            //Graphics g = Graphics.FromImage(canvas);

            ////Penオブジェクトの作成(幅5の白色)
            //Pen whitePen = new Pen(Color.White, 5);

            ////ダッシュ
            //whitePen.DashStyle = DashStyle.Dash;
            ////線を描画
            //g.DrawLine(whitePen, 10, 500, 1300, 500);

            ////ペンを解放する
            //whitePen.Dispose();
            //g.Dispose();

            ////pictureBox1に表示する
            //pictureBox1.Image = canvas;

            InitGraphics();
            SetStartPosition();
            //敵を描画
            DrawEnemyPictureBox();

            Enemies = new Enemy[EnemiesCount];
            

            for (int i = 0; i < EnemiesCount; i++)
            {
                Enemies[i] = new Enemy(pictureBox1, canvas, brushes,enemypath);
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
            EnemyList = new List<Enemy>();
            EnemyList = Enemies.ToList();





            bullets = new Bullet(pictureBox1, canvas, Brushes.Red);
            pictureBoxSpaceship.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSpaceship.Image = Image.FromFile(jikipath);
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
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //画像ファイルを読み込んで、Imageオブジェクトとして取得する
            Image img = Image.FromFile(@"C:\Users\kurosu\Desktop\OJTインベーダーゲーム\InvaderGame\InvaderGame\Image\InvaderM.png");

            
            g.DrawImage(img, x, y, 50, 30);
            //Imageオブジェクトのリソースを解放する
            img.Dispose();

            //Graphicsオブジェクトのリソースを解放する
            g.Dispose();
            //PictureBox1に表示する
            pictureBox1.Image = canvas;
        }
        //配列の初期化、画面の初期設定を行う
        private void InitGraphics()
        {

            Enemies = new Enemy[EnemiesCount];
            EnemyList = new List<Enemy>();
            EnemyList = Enemies.ToList();

            //ブラシ色の設定
            brushes = Brushes.White;

        }
        //敵のインスタンス作成と列に敵を描く
        private void SetStartPosition()
        {
            //敵のインスタンス作成
            //for (int i = 0; i < EnemiesCount; i++)
            //{
                //Enemies[i] = new Enemy(pictureBox1, canvas, brushes);
            //}
            EnemyList = new List<Enemy>();
            EnemyList = Enemies.ToList();

            //タイマーをスタートさせる
            nowTime = 0;
            timer.Start();
        }

        private void InvaderGame_KeyDown(object sender, KeyEventArgs e)
        {

        }
        //private void AtariEnemy()
        //{
        //    var EnemyList = new List<Enemy>();
        //    EnemyList = Enemies.ToList();

        //    for (int i = 0; i < EnemiesCount; i++)
        //    {
        //        if (hit = true)
        //        {
        //            var EnemyList = new List<Enemy>();
        //            EnemyList = Enemies.ToList();
        //            trueFlag = false;
        //            EnemyList.RemoveAt(i);
        //            score = score + 10;
        //            label1.Text = score.ToString();
        //        }
        //    }
        //}
        private void timer_Tick(object sender, EventArgs e)
        {
          
            
                if (nowTime >= 0 && nowTime <= 55)
                {
                    foreach (Enemy ListItem in EnemyList)
                    {
                        ListItem.Move_RIGHT();
                    }
                }
                if (nowTime >= 55  && nowTime <= 75)
                {
                    foreach (Enemy ListItem in EnemyList)
                    {
                        ListItem.Move_DOWN();
                    }
                }
                if (nowTime > 75 && nowTime <= 130)
                {
                    foreach (Enemy ListItem in EnemyList)
                    {
                        ListItem.Move_LEFT();
                    }
                }
            if (nowTime > 130 && nowTime <= 150)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 150 && nowTime <= 205)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_RIGHT();
                }
            }
            if (nowTime > 205 && nowTime <= 225)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 225 && nowTime <= 280)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_LEFT();
                }
            }
            if (nowTime > 280 && nowTime <= 300)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 300 && nowTime <= 355)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_RIGHT();
                }
            }
            if (nowTime > 355 && nowTime <= 375)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 375 && nowTime <= 430)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_LEFT();
                }
            }
            if (nowTime > 430 && nowTime <= 450)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 450 && nowTime <= 505)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_RIGHT();
                }
            }
            if (nowTime > 505 && nowTime <= 525)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 525 && nowTime <= 580)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_LEFT();
                }
            }
            if (nowTime > 580 && nowTime <= 600)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 655 && nowTime <= 710)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_RIGHT();
                }
            }
            if (nowTime > 710 && nowTime <=730)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 730 && nowTime <= 785)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_LEFT();
                }
            }
            if (nowTime > 785 && nowTime <= 805)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 805 && nowTime <= 860)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_RIGHT();
                }
            }
            if (nowTime > 860 && nowTime <= 880)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }


            if (nowTime > 870 && nowTime <= 925)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_LEFT();
                }
            }
            if (nowTime > 925 && nowTime <= 945)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 945 && nowTime <= 1000)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_RIGHT();
                }
            }
            if (nowTime > 1000 && nowTime <= 1020)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }
            if (nowTime > 1020 && nowTime <= 1075)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_LEFT();
                }
            }
            if (nowTime > 1075 && nowTime <= 1095)
            {
                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_DOWN();
                }
            }

            //if (nowTime > 910 && nowTime <= 965)
            //{
            //    foreach (Enemy ListItem in EnemyList)
            //    {
            //        ListItem.Move_RIGHT();
            //    }
            //}
            //if (nowTime > 965 && nowTime <= 975)
            //{
            //    foreach (Enemy ListItem in EnemyList)
            //    {
            //        ListItem.Move_DOWN();
            //    }
            //}
            //if (nowTime > 975 && nowTime <= 1030)
            //{
            //    foreach (Enemy ListItem in EnemyList)
            //    {
            //        ListItem.Move_LEFT();
            //    }
            //}
            //if (nowTime > 1030 && nowTime <= 1040)
            //{
            //    foreach (Enemy ListItem in EnemyList)
            //    {
            //        ListItem.Move_DOWN();
            //    }
            //}

            for (int i = EnemiesCount - 1; i >= 0; i--)
            {
                if (HitJudge(EnemyList[i], bullets))
                {
                    EnemyList[i].DeleteEnemy();
                    bullets.DeleteBullet();
                    EnemyList.RemoveAt(i);
                    bullets.PutBullet(-10, -10);
                    score = score + 10;
                    label1.Text = score.ToString();
                    EnemiesCount = EnemiesCount - 1;
                    break;
                }
            

            }
            if (EnemiesCount == 0)
            {
                Enemies = new Enemy[EnemiesCount];
                for (int j = 0; j < EnemiesCount; j++)
                {
                    Enemies[j] = new Enemy(pictureBox1, canvas, brushes, enemypath);
                }


                EnemyList = new List<Enemy>();
                EnemyList = Enemies.ToList();

                foreach (Enemy ListItem in EnemyList)
                {
                    ListItem.Move_RIGHT();
                }
                //タイマーを停止
                timer.Stop();
                //次画面を非表示
                this.Visible = false;

                //成績画面2を表示
                Seiseki f2 = new Seiseki(label1.Text);
                f2.Show();
            }



            for (int i = 0; i < EnemiesCount; i++)
            {
                if (EnemyList[i].positionsY >= 475)
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
            bool c1 = false;
            if (enemy.positionsX < bullets.positionsX + 5)
            {
                c1 = true;
            }

            bool c2 = false;
            if(enemy.positionsX + 50 > bullets.positionsX)
            {
                c2 = true;
            }

            bool c3 = false;
            if(enemy.positionsY + 30 > bullets.positionsY)
            {
                c3 = true;
            }

           
            if(c1 == true && c2 == true && c3 == true )
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