using System;
using System.IO;
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
        private int pocetCtvercu;
        private int[,] grid = new int[0, 0];
        private PictureBox pictureBox2;
        private int selectedImage = 1;

        private Image grass = Image.FromFile("Sources/grass20.png");
        private Image road = Image.FromFile("Sources/road.png");
        private string filePath;

        private Errors ers; 

        public Form1()
        {
            //make code so if on messagebox ok btn cliced app will close
            ers = new Errors();
            try
            {
                pocetCtvercu = int.Parse(Interaction.InputBox("Pocet ctvercu a * a: "));
                grid = new int[pocetCtvercu, pocetCtvercu];
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                ers.genrateBox("Zadej číslo...", this);
            }

            InitializeComponent();

            grassBox.Image = grass;
            roadBox.Image = road;

            grassBox.Update();
            roadBox.Update();
        }

        private void canvasPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myP = new Pen(Color.Black);
            float x = 0f;
            float y = 0f;
            if (pocetCtvercu != 0)
            {
                float xPlocha = (pictureBox1.Width / pocetCtvercu) - myP.Width;
                float yPlocha = (pictureBox1.Height / pocetCtvercu) - myP.Width;

                //vertikalne 
                for (int i = 0; i < pocetCtvercu + 1; i++)
                {
                    g.DrawLine(myP, x, y, x, yPlocha * pocetCtvercu);
                    x += xPlocha;
                }
                //horizontalne
                x = 0f;
                for (int i = 0; i < pocetCtvercu + 1; i++)
                {
                    g.DrawLine(myP, x, y, xPlocha * pocetCtvercu, y);
                    y += yPlocha;
                }

                for (int i = 0; i < pocetCtvercu; i++)
                {
                    for (int j = 0; j < pocetCtvercu; j++)
                    {
                        switch (grid[i, j])
                        {
                            case 1:
                                g.DrawImage(grass, new Rectangle(i * (int)xPlocha, j * (int)yPlocha, (int)xPlocha, (int)yPlocha));
                                break;
                            case 2:
                                g.DrawImage(road, new Rectangle(i * (int)xPlocha, j * (int)yPlocha, (int)xPlocha, (int)yPlocha));
                                break;
                        }
                    }
                }
            }
        }

        private void sizeChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                pocetCtvercu = int.Parse(Interaction.InputBox("Pocet ctvercu a * a: "));
                grid = new int[pocetCtvercu, pocetCtvercu];
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                ers.genrateBox("Zadej číslo...", this);
            }
            Refresh();
        }

        private void grassBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox2 == null)
            {
                pictureBox2 = new PictureBox();
                pictureBox2.Image = grassBox.Image;
                pictureBox2.Width = 100;
                pictureBox2.Height = 100;
                Controls.Add(pictureBox2);
                selectedImage = 1;
                pictureBox2.BringToFront();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox2 != null)
            {
                Point p1 = MousePosition;
                Point p2 = PointToClient(p1);
                pictureBox2.Location = new Point(p2.X - pictureBox2.Width / 2, p2.Y +50);
            }
        }

        private void roadBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox2 == null)
            {
                pictureBox2 = new PictureBox();
                pictureBox2.Image = roadBox.Image;
                pictureBox2.Width = 100;
                pictureBox2.Height = 100;
                Controls.Add(pictureBox2);
                selectedImage = 2;
                pictureBox2.BringToFront();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox2 == null)
                return;
            if (e.Button == MouseButtons.Right)
            {
                Controls.Remove(pictureBox2);
                pictureBox2 = null;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox2 == null)
                return;
            if (e.Button == MouseButtons.Right)
            {
                Controls.Remove(pictureBox2);
                pictureBox2 = null;
                
            }
            if (e.Button == MouseButtons.Left)
            {
                Point p1 = pictureBox1.PointToClient(MousePosition);

                float xPlocha = pictureBox1.Width / pocetCtvercu;
                float yPlocha = pictureBox1.Height / pocetCtvercu;

                int x = p1.X / (int)xPlocha;
                int y = p1.Y / (int)xPlocha;

                grid[x, y] = selectedImage;

                Controls.Remove(pictureBox2);
                pictureBox2 = null;

                pictureBox1.Refresh();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            for(int i = 0; i < grid.GetLength(0); i++)
            {
                string line = "";
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    line += grid[i, j];
                }
                list.Add(line);
            }

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {                    
                    myStream.Close();
                    File.WriteAllLines(saveFileDialog1.FileName, list);
                }
            }
        }


        private void importButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            
            MessageBox.Show("Cesta k souboru: " + filePath);
            try
            {
                List<string> list = File.ReadAllLines(filePath).ToList();
                pocetCtvercu = list.Count;
                grid = new int[pocetCtvercu, pocetCtvercu];
                for (int i = 0; i < pocetCtvercu; i++)
                {
                    for (int j = 0; j < pocetCtvercu; j++)
                    {
                        grid[i, j] = int.Parse(list[i][j].ToString());
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
                ers.genrateBox("Zadej platnou cestu k souboru...", this);
            }                     

            pictureBox1.Refresh();
        }
    }
}