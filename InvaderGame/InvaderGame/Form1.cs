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
            else if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }
            else if (e.KeyCode == Keys.Space)
            {
            }
            else if (e.KeyCode == Keys.S)
            {
            }
        }

        void MoveLeft()
        {
            Point pt = pictureBoxSpaceship.Location;
            pt.X -= 10;
            pictureBoxSpaceship.Location = pt;
        }

        void MoveRight()
        {
            Point pt = pictureBoxSpaceship.Location;
            pt.X += 10;
            pictureBoxSpaceship.Location = pt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
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
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
              
        }
        private void DrawJikiPictureBox()
        {
            
        }

        private void InvaderGame_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
