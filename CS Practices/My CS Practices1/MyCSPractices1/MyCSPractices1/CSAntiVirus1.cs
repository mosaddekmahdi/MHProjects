using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace MyCSPractices1
{
    public partial class CSAntiVirus1 : Form
    {
      
          int viruses;
          string[] visrusList = new string[] { "virus", "torjon", "hacker", "hack" };

        public CSAntiVirus1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblFolder.Text = folderBrowserDialog1.SelectedPath;
            viruses = 0;
            lblVirus.Text += viruses.ToString();

            progressBar1.Value = 0;
            listBox1.Items.Clear();

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            List<String> search = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*").ToList();
            progressBar1.Maximum = search.Count;
            foreach (string item in search)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string read = stream.ReadToEnd();

                    foreach (string st in visrusList)
                    {
                        if (Regex.IsMatch(read, st))
                        {
                            viruses = viruses + 1;
                            lblVirus.Text += viruses;
                            listBox1.Items.Add(item);

                        }

                    }
                }
                catch (Exception ex)
                {
                    //
                }

            }
        }

        private void Help1_Click(object sender, EventArgs e)
        {
            http://www.youtube.com/watch?v=DQvheZ9_USc&feature=related
        }

        private void CSAntiVirus1_Load(object sender, EventArgs e)
        {

        }
    }
}
