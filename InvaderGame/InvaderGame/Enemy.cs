using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//図形を書くコードを見やすくするためのusing
using System.Drawing;
using System.Windows.Forms;

namespace InvaderGame
{
    class Enemy
    {
        //クラスに必要な情報の定義
        public int pitch; //移動簿割合
        public int positionsX; //横位置
        public int positionsY; //縦位置
        public int previousX; //以前の横位置
        public int previousY; //以前の縦位置
        public int directionX_R; //移動方向（ｘ座標、+1 or -1)   右
        public int directionY_R; //移動方向（y座標、+1 or -1)　　右
        public int directionX_L; //移動方向（ｘ座標、+1 or -1)　 左
        public int directionY_L; //移動方向（y座標、+1 or -1)　  左
        public int directionX_D; //移動方向（ｘ座標、+1 or -1)　 下
        public int directionY_D; //移動方向（y座標、+1 or -1)　  下


        private PictureBox pictureBox; //描画するPictureBox
        private Bitmap canvas; //描画するキャンバス
        private Brush brushColor; //塗りつぶす色
        
  

        //敵コンストラクタ
        //3つの引数を指定し、クラス内部に保持する。3つの引数は描画するPictureBox、描画するキャンバス、塗りつぶす色
        public Enemy(PictureBox pb, Bitmap cv, Brush cl)
        {
            pictureBox = pb; //描画するPictureBox
            canvas = cv;　//描画するキャンバス
            brushColor = cl; //塗りつぶす色

            pitch = 2; //移動の割合
            directionX_R = +1; //移動方向を+1で初期設定
            directionY_R = 0; //移動方向を0で初期設定
            directionX_L = -1; //移動方向を-1で初期設定
            directionY_L = 0; //移動方向を0で初期設定
            directionX_D = 0; //移動方向を0で初期設定
            directionY_D = +1; //移動方向を+1で初期設定
        }
        //指定した位置に敵を描く
        public void PutEnemy(int x, int y)
        {
            //現在の位置を記憶
            positionsX = x;
            positionsY = y;

            using (Graphics g = Graphics.FromImage(canvas))
            {
                //敵をbrushColorで指定された色で描く
                g.FillRectangle(brushColor, x, y, 50, 30);

                //pictureBox1に表示する
                pictureBox.Image = canvas;
            }

        }

        //指定した位置の敵を消す（黒で書く）
        public void DeleteEnemy()
        {
            //初めて呼ばれて以前の値が無い場合
            if (previousX == 0)
            {
                previousX = positionsX;
            }
            if (previousY == 0)
            {
                previousY = positionsY;
            }

            using (Graphics g = Graphics.FromImage(canvas))
            {
                //敵を黒で描く
                g.FillRectangle(Brushes.Black, previousX, previousY, 50, 30);

                //pictureBox1に表示
                pictureBox.Image = canvas;
            }
        }

        //指定した位置に敵を動かす

        public void Move_RIGHT()
        {
            //以前の表示を削除
            DeleteEnemy();

            //新しい移動先の計算
            int x = positionsX + pitch * directionX_R;
            int y = positionsY + pitch * directionY_R;

            //新しい位置の計算
            positionsX = x + directionX_R;
            positionsY = y + directionY_R;

            //新しい位置に描画
            PutEnemy(positionsX, positionsY);

            //新しい位置を以前の値として記憶
            previousX = positionsX;
            previousY = positionsY;
        }
        public void Move_LEFT()
        {
            //以前の表示を削除
            DeleteEnemy();

            //新しい移動先の計算
            int x = positionsX + pitch * directionX_L;
            int y = positionsY + pitch * directionY_L;

            //新しい位置の計算
            positionsX = x + directionX_L;
            positionsY = y + directionY_L;

            //新しい位置に描画
            PutEnemy(positionsX, positionsY);

            //新しい位置を以前の値として記憶
            previousX = positionsX;
            previousY = positionsY;
        }
        public void Move_DOWN()
        {
            //以前の表示を削除
            DeleteEnemy();

            //新しい移動先の計算
            int x = positionsX + pitch * directionX_D;
            int y = positionsY + pitch * directionY_D;

            //新しい位置の計算
            positionsX = x + directionX_D;
            positionsY = y + directionY_D;

            //新しい位置に描画
            PutEnemy(positionsX, positionsY);

            //新しい位置を以前の値として記憶
            previousX = positionsX;
            previousY = positionsY;
        }
    }
}
