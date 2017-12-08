using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MongoDbApplication
{

    public partial class UpdateForm : Form
    {
        public Task task;
        public Form1 pform;
        public UpdateForm()
        {
            InitializeComponent();
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {


            Dal d = new Dal();
            String x = task.Id.ToString();

         
            task.JobTitle = txtJobTitleUpdate.Text;
            task.Institution = txtInstitutionUpdate.Text;

            task.JobCategory = comboJobCategoryUpdate.SelectedItem.ToString();
            task.JobCategory = comboJobCategoryUpdate.Text;
            task.DatePosted = txtDatePostedUpdate.Text;
            task.Deadline = txtDeadlineUpdate.Text;
            task.DataEntered = dateTimePickerUpdate.Value;
            task.SourceURL = txtSourceURLUpdate.Text;
            task.Notes = richTextBoxUpdate.Text;

         
            d.EditTask(task);

            pform.LoadTheTasks();

            this.Visible = false;
            this.Dispose();

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
                     
            txtJobTitleUpdate.Text = task.JobTitle;
            txtInstitutionUpdate.Text = task.Institution;
            comboJobCategoryUpdate.SelectedItem = task.JobCategory;
            txtDatePostedUpdate.Text =task.DatePosted;
            txtDeadlineUpdate.Text = task.Deadline;
            dateTimePickerUpdate.Value = task.DataEntered;
            txtSourceURLUpdate.Text = task.SourceURL;
            richTextBoxUpdate.Text = task.Notes;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}