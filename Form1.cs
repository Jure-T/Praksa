using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematika
{
    public partial class Form1 : Form
    {

        bool again = false;
        Random Location = new Random();
        /*
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        */
        List<Point> points = new List<Point>();
        PictureBox PendingImage1;
        PictureBox PendingImage2;
        /*
        List<int> IDS = new List<int>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            foreach (PictureBox picture in panel1.Controls)    // ne pokazuju se karte nakon kila 
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in panel1.Controls)
            {
                int next = Location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            */
            

            pictureBox1.Image = Properties.Resources.p1;
            pictureBox2.Image = Properties.Resources.o3;
            pictureBox3.Image = Properties.Resources.p4;
            pictureBox4.Image = Properties.Resources.p2;
            pictureBox5.Image = Properties.Resources.o2;
            pictureBox6.Image = Properties.Resources.o1;
            pictureBox7.Image = Properties.Resources.p3;
            pictureBox8.Image = Properties.Resources.p4;
            
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.upitnik1;
            }
        }
        #region karte
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.p1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.o3;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.o4;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.p2;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.o2;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.o1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.p4;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.p3;           
        }
        #endregion

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zatvoriSveKarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

    }
}
