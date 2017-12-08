using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; /// Needed to use Directory Method
using System.Text.RegularExpressions;


namespace MHAntivirus
{
    public partial class MHAntivirus : Form
    {

        int viruses;
        string[] visrusList = new string[] { "virus", "trojan", "hack", "hacker" };

        public MHAntivirus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblFolder.Text = "Scanned: " + folderBrowserDialog1.SelectedPath;
            viruses = 0;
            lblViruses.Text = "Found: " + viruses.ToString() + " Viruses";

            progressBar1.Value = 0;
            listBox1.Items.Clear();

        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" http://www.youtube.com/watch?v=DQvheZ9_USc&feature=related");

        }

        private void Help1_Click(object sender, EventArgs e)
        {
          MessageBox.Show(" http://www.youtube.com/watch?v=jjN2VNY5w8g ");

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            List<String> search = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.*").ToList();
            
            progressBar1.Maximum = search.Count;
            
            foreach (string item in search)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string read = stream.ReadToEnd();

                    foreach(string st in visrusList)
                        if (Regex.IsMatch(read, st))
                        {
                            viruses = viruses + 1;
                            lblViruses.Text = "Found: " + viruses.ToString() + " Viruses";
                            
                            listBox1.Items.Add(item);

                        }
                    progressBar1.Increment(1);

                    }
                
                catch (Exception ex)
                {
                    //
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
