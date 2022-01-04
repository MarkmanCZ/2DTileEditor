using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DTileEditor
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void canvasPaint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.Size.Width;
            int h = pictureBox1.Size.Height;
            int cellSize = 64; //64x64 square
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
