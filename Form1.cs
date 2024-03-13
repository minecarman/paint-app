using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintApp
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = new Bitmap(1024, 768);
        Pen pen = new Pen(Color.White);
        bool drawing = false;
        private int size = 2;
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
            }
            else
            {
                drawing = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawEllipse(pen, e.X, e.Y, size, size);
                pictureBox1.Image = bitmap;
            }
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }


        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Gray;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }
        
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            size = 2;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            size = 4;
        }


        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            size = 6;
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            size = 9;
        }
        
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg image| *.jpeg";
            saveFileDialog.Title = "Save File As";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fileStream = (System.IO.FileStream)saveFileDialog.OpenFile();
                this.pictureBox1.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}