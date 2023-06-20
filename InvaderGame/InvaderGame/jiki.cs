using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace InvaderGame
{

    class Jiki
    {
        //自機は白色で四角形
        //自機は⇔の入力で動く
        //画面の端までしか動かない



      /*  //クラスに必要な情報の定義
        公開し外部から触ることができる値

        非公開で外部からは変更することができない値
        private PictureBox pictureBox;
        private Bitmap canvas;
        private Brush brushColor;
        private int positionX;
        private int positionY;
        private int previousX;
        private int previousY;
        private int directionX;

        /*jikiコンストラクタ
         3つの引数を指定しクラスの内部に保持する。3つの引数は、描画するPictureBox、
         描画するキャンパス、塗りつぶす色*/
      /*public Jiki(PictureBox pb, Bitmap cv, Brush cl)
      {
          pictureBox = pb;
          canvas = cv;
          brushColor = cl;

          directionX = +1;
      }
      指定した位置に自機を置く
      public void PutRectangle(int x, int y)
      {
          現在の位置を記憶
          positionX = x;
          positionY = y;

          using (Graphics g = Graphics.FromImage(canvas))
          {
              自機をbrushcolorで指定された色で描く
              g.FillRectangle(brushColor, x, y, 200, 150);

              mainPicureBoxに表示する
              pictureBox.Image = canvas;
          }
      }*/
    }
}
