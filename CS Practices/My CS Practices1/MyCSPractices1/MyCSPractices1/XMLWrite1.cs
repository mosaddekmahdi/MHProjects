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
    public partial class XMLWrite1 : Form
    {
        public XMLWrite1()
        {
            InitializeComponent();
        }

        private void btnXmlWriter1Save_Click(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter("c:\\C#Data\\people.xml", Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteStartElement("name");
            writer.WriteStartElement("age");
            writer.WriteStartElement("cell");
            writer.WriteStartElement("email");
            
            writer.WriteString(textBox3.Text);
            writer.WriteEndElement();//Title

            foreach (string item in listBox1.Items)
            {
                writer.WriteStartElement("Item");
                writer.WriteString(item);
                writer.WriteEndElement(); // Item

            }
            writer.WriteEndElement(); // Saved
            writer.WriteEndDocument(); // Item
            writer.Close();

        }

       
    }
}
