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

        private int numOfLines;

        public Form1()
        {
            try
            {
                numOfLines = Convert.ToInt32(Interaction.InputBox("Pocet ctvercu: "));
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
                float xPlocha = (pictureBox1.Width / numOfLines) - myP.Width;
                float yPlocha = (pictureBox1.Height / numOfLines) - myP.Width;
        
                //vertikalne 
                for (int i = 0; i < numOfLines + 1; i++)
                {
                    g.DrawLine(myP, x, y, x, yPlocha * numOfLines);
                    x += xPlocha;
                }
                //horizontalne
                x = 0f;
                for (int i = 0; i < numOfLines + 1; i++)
                {
                    g.DrawLine(myP, x, y, xPlocha * numOfLines, y);
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
            numOfLines = Convert.ToInt32(Interaction.InputBox("Pocet ctvercu: "));
        }
    }
}
