using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace MHBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://www.youtube.com/watch?v=3gtS4X2QL1w");
        }

        private void btnAddWrite_Click(object sender, EventArgs e)
        {
            listBoxWrite.Items.Add(textBox1Write.Text);
        }

        private void btnSaveWrite_Click(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter("c:\\data\\people.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("people");
            writer.WriteStartElement("person");
            writer.WriteString(textBox2Write.Text); //single entry
            writer.WriteEndElement(); // Title

            foreach (string item in listBoxWrite.Items)   // repeated entry
            {
                writer.WriteStartElement("person");
                writer.WriteString(item);
                writer.WriteEndElement(); // Item
            }
            writer.WriteEndElement(); // Saved
            writer.WriteEndDocument();
            writer.Close();

        }

        

    }
}
