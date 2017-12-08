using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace XMLPeople
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
