using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCarS
{
    public partial class StateLaws : Form
    {
        public StateLaws()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LawClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Text=="Nevada")
            {
                Nevada nv = new Nevada();
                nv.ShowDialog();
            }

            if (listBox1.Text == "California")
            {
               California ca = new California();
                ca.ShowDialog();
            }
            if (listBox1.Text == "New_York")
            {
                New_York ny = new New_York();
                ny.ShowDialog();
            }
            if (listBox1.Text == "Texas")
            {
                Texas tx = new Texas();
                tx.ShowDialog();
            }
        }

        
    }
}