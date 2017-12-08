using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCSPractices1
{
    public partial class XMLBrowse1 : Form
    {
        public XMLBrowse1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter=".xml|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            { 
            XmlDocument xdoc = new XmlDocument();
                xdoc.Load(ofd.FileName);
                MessageBox.Show(xdoc.SelectSingleNode("people/person/name").InnerText);
                MessageBox.Show(xdoc.SelectSingleNode("people/person/age").InnerText);
                MessageBox.Show(xdoc.SelectSingleNode("people/person/cell").InnerText);
                MessageBox.Show(xdoc.SelectSingleNode("people/person/email").InnerText);
                      
        }

        }
    }
}
