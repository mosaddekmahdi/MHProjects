using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCarS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Thank you for using DCars"+
            "\nWish you to be a safe Driver"+
             "\n Have a nice day!");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rules CallRules = new Rules();
            CallRules.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StateLaws CallLaws = new StateLaws();
            CallLaws.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DCarSTest CallQuiz = new DCarSTest();
            CallQuiz.ShowDialog();
        }
    }
}