using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _2DTileEditor
{
    public partial class Form1 : Form
    {

        private int pocetLinek;

        public Form1()
        {
            try
            {
                pocetLinek = Convert.ToInt32(Interaction.InputBox("Pocet linek: "));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            InitializeComponent();
        }

        private void canvasPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myP = new Pen(Color.Black);
            float x = 0f;
            float y = 0f;
            try
            {
                float xPlocha = (pictureBox1.Width / pocetLinek) - myP.Width;
                float yPlocha = (pictureBox1.Height / pocetLinek) - myP.Width;
        
                //vertikalne 
                for (int i = 0; i < pocetLinek + 1; i++)
                {
                    g.DrawLine(myP, x, y, x, yPlocha * pocetLinek);
                    x += xPlocha;
                }
                //horizontalne
                x = 0f;
                for (int i = 0; i < pocetLinek + 1; i++)
                {
                    g.DrawLine(myP, x, y, xPlocha * pocetLinek, y);
                    y += xPlocha;
                }

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                Application.Exit();
            }
        }

        private void sizeChangeBtn_Click(object sender, EventArgs e)
        {
            pocetLinek = Convert.ToInt32(Interaction.InputBox("Pocet linek: "));
        }
    }
}
