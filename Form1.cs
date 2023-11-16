using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rodrigobraun_valle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void Estrella3_Click(object sender, EventArgs e)
        {
            panel4.Show();
    }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel6.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel7.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel8.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel9.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            panel10.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            panel12.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            panel13.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            panel14.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            panel15.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
