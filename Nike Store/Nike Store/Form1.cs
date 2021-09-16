using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Nike_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlNav.Width = btnMen.Width;
            pnlNav.Top = btnMen.Top;
            pnlNav.Left = btnMen.Left;
            
        }

        private void btnMen_Click(object sender, EventArgs e)
        {
            pnlNav.Width = btnMen.Width;
            pnlNav.Top = btnMen.Top;
            pnlNav.Left = btnMen.Left;
        }

        private void btnWomen_Click(object sender, EventArgs e)
        {
            pnlNav.Width = btnWomen.Width;
            pnlNav.Top = btnWomen.Top;
            pnlNav.Left = btnWomen.Left;
        }

        private void btnBoys_Click(object sender, EventArgs e)
        {
            pnlNav.Width = btnBoys.Width;
            pnlNav.Top = btnBoys.Top;
            pnlNav.Left = btnBoys.Left;
        }

        private void btnGirls_Click(object sender, EventArgs e)
        {
            pnlNav.Width = btnGirls.Width;
            pnlNav.Top = btnGirls.Top;
            pnlNav.Left = btnGirls.Left;
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            pnlNav.Width = btnCollection.Width;
            pnlNav.Top = btnCollection.Top;
            pnlNav.Left = btnCollection.Left;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Width = button2.Width;
            pnlNav.Top = button2.Top;
            pnlNav.Left = button2.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Width = button1.Width;
            pnlNav.Top = button1.Top;
            pnlNav.Left = button1.Left;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2Button7.BorderColor = Color.Black;
            guna2Button8.BorderColor = Color.LightGray;
            guna2Button9.BorderColor = Color.LightGray;
            guna2Transition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.ImageRotate = 330;
            guna2PictureBox1.Image = ((Guna2Button)sender).Image;
            guna2Transition1.ShowSync(guna2PictureBox1);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            guna2Button7.BorderColor = Color.LightGray;
            guna2Button8.BorderColor = Color.Black;
            guna2Button9.BorderColor = Color.LightGray;
            guna2Transition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.ImageRotate = 0;
            guna2PictureBox1.Image = ((Guna2Button)sender).Image;
            guna2Transition1.ShowSync(guna2PictureBox1);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            guna2Button7.BorderColor = Color.LightGray;
            guna2Button8.BorderColor = Color.LightGray;
            guna2Button9.BorderColor = Color.Black;
            guna2Transition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.ImageRotate = 0;
            guna2PictureBox1.Image = ((Guna2Button)sender).Image;
            guna2Transition1.ShowSync(guna2PictureBox1);
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.ImageRotate = 330;
            guna2PictureBox1.Image = ((Guna2PictureBox)sender).Image;
            guna2Transition1.ShowSync(guna2PictureBox1);
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.ImageRotate = 330;
            guna2PictureBox1.Image = ((Guna2PictureBox)sender).Image;
            guna2Transition1.ShowSync(guna2PictureBox1);
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.ImageRotate = 330;
            guna2PictureBox1.Image = ((Guna2PictureBox)sender).Image;
            guna2Transition1.ShowSync(guna2PictureBox1);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.ImageRotate = 330;
            guna2PictureBox1.Image = ((Guna2PictureBox)sender).Image;
            guna2Transition1.ShowSync(guna2PictureBox1);
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
