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
            _str = str;
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
        }

        private void SCORE_Seiseki_Click(object sender, EventArgs e)
        {

        }
    }
}
