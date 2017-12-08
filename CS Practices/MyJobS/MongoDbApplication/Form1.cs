using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
namespace MongoDbApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

      

        public void LoadTheTasks()
        {
            Dal dal = new Dal();
            List<Task> t = dal.GetAllTasks();

            dataGridView1.DataSource = t;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Dal d = new Dal();
            String x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            d.DeleteTask(x);
            LoadTheTasks();
        }

     

    

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateForm f = new UpdateForm();
            Dal d = new Dal();
            String x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Task t = d.GetTask(x);
            f.task = t;
            f.pform = this;
            f.ShowDialog();
       
        }

      

        private void tabInsert_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabInsert.Selected+=new TabControlEventHandler(tabInsert_Selected);
          
        }

        void tabInsert_Selected(object sender, TabControlEventArgs e)
        {
            LoadTheTasks();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadTheTasks();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void txtInstitution_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dal dal = new Dal();
            Task t = new Task
            {
                JobTitle = txtJobTitleInsert.Text,
                JobCategory = comboBoxInsert.SelectedItem.ToString(),
                Institution = txtInstitutionInsert.Text,
                //DatePosted = dateTimePicker1.Value,
                
                DatePosted = txtDatePostedInsert.Text,
                Deadline = txtDeadlineInsert.Text,

                //DataEntered = DateTime.UtcNow,
                DataEntered = dateTimePicker1.Value,
                                
                SourceURL = txtSourceURLInsert.Text,
                Notes = richTextBoxInsert.Text

            };
            
            dal.CreateTask(t);
            txtJobTitleInsert.Text = "";  // Job Title TextBox
            txtInstitutionInsert.Text = "";   // Institution TextBox
            comboBoxInsert.SelectedItem = null; // Job Category ComboBox
            txtJobTitleInsert.Text = "";  // Job Title TextBox
            txtDatePostedInsert.Text = ""; // Date Posted TextBox
            txtDeadlineInsert.Text = "";   // Deadlien TextBox

            dateTimePicker1.Value = DateTime.UtcNow;  // Data Entered dateTimePicker1  
                        
            txtSourceURLInsert.Text = ""; // SourceURL Textbox
            
            richTextBoxInsert.Text = "";   // Notes ruchTextBox1

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Task t = new Task
            {
               // Id = new Guid(textBox3.Text + "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx".Replace("\"", "")),
                JobTitle = txtJobTitleSearch.Text + "",
          
            JobCategory = comboBoxJobCategorySearch.SelectedItem+"".ToString()
            
            };
            Dal d = new Dal();
            List<Task> list = d.SearchByTask(t);
            dataGridView2.DataSource = list;
        }

        private void btnQuickInfo_Click(object sender, EventArgs e)
        {
        
            Dal d = new Dal();
            String x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           Task t= d.GetTask(x);
           MessageBox.Show("Quick Info about the selected list: " + "\n" + "\n" + "Job Title: " + t.JobTitle + "\n" + "Job Category: " + t.JobCategory + "\n" + "Institution: " + t.Institution + "\n" + "Source URL: " + t.SourceURL + "\n" + "DatePosted: " + t.DatePosted + "Deadline: " + t.Deadline + "DataEntered: " + t.DataEntered + "\n" + "\n" + t.Notes);
         }

        private void btnLoad_Click(object sender, EventArgs e)
        {
        
            LoadTheTasks();
          
        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            About frmabt = new About();
            frmabt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dal d = new Dal();
            String x = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            d.DeleteTask(x);
            LoadTheTasks();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Load : Loads existing records from 'C:\\Data\\DB\\' folder. If this folder does not exist, please create."+"\n\n"+
                "Quick View: Shows all information of the selected record in a single window. " + "\n\n" +
                "Delete: Deletes a selected record from the database."  + "\n\n" +
                "To Edit: Double click a selected item, and make changes.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on a selected record to make changes. If not seen, click on the Load button to refresh database ");
        }

       
   
    }
}
