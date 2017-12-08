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

        XmlDocument xdoc;   // xdoc is a XmlDocument type global veriable 
        string path;  // path is string type global veriable 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://www.youtube.com/watch?v=3gtS4X2QL1w");
        }

       
      


        private void btnAddWrite_Click_1(object sender, EventArgs e)
        {
            listBoxWrite.Items.Add(textBox1Write.Text);
        }

        private void btnSaveWrite_Click_1(object sender, EventArgs e)
        {
         
            XmlTextWriter writer = new XmlTextWriter("c:\\data\\people.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("people");
            writer.WriteStartElement("Title");
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

        private void btnRead_Click(object sender, EventArgs e)
        {
                  
            XmlTextReader reader = new XmlTextReader("c:\\data\\people.xml");
            XmlNodeType type;
            while (reader.Read())
            {
                type = reader.NodeType;
                if (type == XmlNodeType.Element)
                {
                    if (reader.Name == "Title")
                    {
                        reader.Read();
                        textBox1Read.Text = reader.Value;
                    }
                    if (reader.Name == "person")
                    {
                        reader.Read();
                        //textBox1Read.Text = reader.Value;
                        listBox1Read.Items.Add(reader.Value);
                    }

                }


            }
            reader.Close();

        }

        private void btnBrowseBrowse_Click(object sender, EventArgs e)
        {

        
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".xml|*.xml";

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".xml|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;        // assigning value to global variable
                xdoc = new XmlDocument();   // assigning value to global variable
                
                xdoc.Load(path);
              
                txtNameEdit.Text = xdoc.SelectSingleNode("people/person/name").InnerText;
                numericUpDown1.Value = Convert.ToInt32(xdoc.SelectSingleNode("people/person/age").InnerText);
                // Converting numericUpDown1.Value String to Integer

                                                   
                txtCellEdit.Text = xdoc.SelectSingleNode("people/person/cell").InnerText;
                txtEmailEdit.Text = xdoc.SelectSingleNode("people/person/email").InnerText;


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            xdoc.SelectSingleNode("people/person/name").InnerText = txtNameEdit.Text;

            xdoc.SelectSingleNode("people/person/age").InnerText = numericUpDown1.Value.ToString();
            // Converting  Integer value to fit in numericUpDown1.Value as String 
            xdoc.SelectSingleNode("people/person/cell").InnerText = txtCellEdit.Text;
            xdoc.SelectSingleNode("people/person/email").InnerText = txtEmailEdit.Text;
            xdoc.Save(path);


        }


        
    }
}