using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCarS
{
    public partial class DCarSTest : Form
    {
        public DCarSTest()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            QuestionAnswer frmAnswer = new QuestionAnswer();
            int numberOfQuestions = int.Parse(updTotalQuestions.Value.ToString());

            frmAnswer.TotalNumberOfQuestions = numberOfQuestions;
            frmAnswer.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}