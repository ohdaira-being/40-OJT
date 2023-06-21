﻿using System;
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
        private int EnemiesCount = 55; //敵の数
        private Brush brushes = Brushes.White; //敵を塗る配列
        private double nowTime = 0; //経過時間
        


        private void Form1_Load(object sender, EventArgs e)
        {
            InitGraphics();
            SetStartPosition();

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
            for (int i = 0; i < Enemies.Length; i++)
            {
                Enemies[i]. Move();
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
            }

            nowTime = nowTime + 1;
        }
    }
}