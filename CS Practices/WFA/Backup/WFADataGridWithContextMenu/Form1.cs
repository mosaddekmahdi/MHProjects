using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFADataGridWithContextMenu
{
    public partial class Form1 : Form
    {
        private DataGridView myDataGridView = new DataGridView();
        private DataTable dtData = new DataTable();
        private ContextMenu contextMenuSingleRow = new ContextMenu();
        private ContextMenu contextMenuMultiRow = new ContextMenu();
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads form.
        /// </summary>
        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            InitializeDataTableProperties();
            AddDataToDataTable();
            PopulateGridViewWithData();
            PopulateContextMenuItems();
        }

        /// <summary>
        /// Populates the context menu items.
        /// </summary>
        private void PopulateContextMenuItems()
        {
            // Single Row
            contextMenuSingleRow.MenuItems.Add("Edit", SelectedItem_Click);
            contextMenuSingleRow.MenuItems.Add("Email", SelectedItem_Click);

            // Multi Row
            contextMenuMultiRow.MenuItems.Add("Email", SelectedItem_Click);
        }


        /// <summary>
        /// Handles the Click event of the SelectedItem(s).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void SelectedItem_Click(object sender, EventArgs e)
        {
            if (myDataGridView.SelectedRows.Count > 1)
            {
                StringBuilder needToSendEmailsTo = new StringBuilder();
                foreach (DataGridViewRow dataGridViewSelectedRow in myDataGridView.SelectedRows)
                {
                    needToSendEmailsTo.Append(dataGridViewSelectedRow.Cells["Email"].Value.ToString() + ",");
                }
                MessageBox.Show("Need to send emails to : " + needToSendEmailsTo);
            }
            else if (myDataGridView.SelectedRows.Count == 1)
            {
                MenuItem thisMenu = (MenuItem)Convert.ChangeType(sender, typeof(MenuItem));
                switch (thisMenu.Text)
                {
                    case "Edit":
                        {
                            MessageBox.Show("Edit option selected.");
                            break;
                        }
                    case "Email":
                        {
                            MessageBox.Show("Email option selected.");
                            break;
                        }
                }
            }
        }


        /// <summary>
        /// Initializes the data table properties.
        /// </summary>
        private void InitializeDataTableProperties()
        {
            dtData.Columns.Add("ID", typeof(int));
            dtData.Columns.Add("Name", typeof(string));
            dtData.Columns.Add("Email", typeof(string));
        }

        /// <summary>
        /// Adds the data to data table.
        /// </summary>
        private void AddDataToDataTable()
        {
            if (dtData == null)
            {
                MessageBox.Show("Data table has not been initialized.");
            }
            else
            {
                dtData.Rows.Add(new object[] { 1, "Suname, ALFKI", "alfki@contoso.com" });
                dtData.Rows.Add(new object[] { 2, "Suname, FABRIKAM", "fabrikam@contoso.com" });
                dtData.Rows.Add(new object[] { 3, "Suname, IAMTHEMAN", "iamtheman@contoso.com" });
            }
        }
        /// <summary>
        /// Populates the grid view with data.
        /// </summary>
        private void PopulateGridViewWithData()
        {
            this.Controls.Add(myDataGridView);
            this.myDataGridView.DataSource = dtData;
            this.myDataGridView.AutoGenerateColumns = true;
            this.myDataGridView.MultiSelect = true;
            this.myDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.myDataGridView.AutoSize = true;
            this.myDataGridView.MouseUp += new MouseEventHandler(myDataGridView_MouseUp);
        }

        /// <summary>
        /// Handles the MouseUp event of the myDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void myDataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTestInfo;
            DataGridView resultGrid = (DataGridView)Convert.ChangeType(sender, typeof(DataGridView));
            if (e.Button == MouseButtons.Right)
            {
                if (resultGrid.SelectedRows.Count > 1)
                {
                    hitTestInfo = resultGrid.HitTest(e.X, e.Y);
                    contextMenuMultiRow.Show(resultGrid, new Point(e.X, e.Y));
                }
                else
                {
                    hitTestInfo = resultGrid.HitTest(e.X, e.Y);
                    contextMenuSingleRow.Show(resultGrid, new Point(e.X, e.Y));
                }
            }
        }
    }
}
