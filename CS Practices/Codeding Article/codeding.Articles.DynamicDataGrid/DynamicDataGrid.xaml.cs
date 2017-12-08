//DynamicDataGrid.xaml.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace codeding.Articles.DynamicDataGrid
{
    public partial class DynamicDataGrid : UserControl
    {
        #region Properties

        private StringTable StringTable { get; set; }

        #endregion

        #region Constructors

        public DynamicDataGrid()
        {
            InitializeComponent();
            this.StringTable = new StringTable();
            ResetTable();
        }

        #endregion

        #region Control-Events

        private void AddRowButton_Click(object sender, RoutedEventArgs e)
        {
            //build new-row with empty values
            StringRow newRowValues = new StringRow();
            foreach (string columnName in this.StringTable.ColumnNames)
            {
                string cellValue = "r" + this.StringTable.Count + "c" + this.StringTable.ColumnNames.IndexOf(columnName);
                newRowValues.Add(columnName, cellValue);
            }

            //add new row to StringTable
            this.StringTable.Add(this.StringTable.Count, newRowValues);
            RefreshDataGrid();
        }

        private void AddColumnButton_Click(object sender, RoutedEventArgs e)
        {
            string columnName = ColumnNameTextBox.Text.Trim();

            //dont allow empty column-name
            if (columnName.Equals(string.Empty))
            {
                MessageBox.Show("Please enter a name for the Column.");
                ColumnNameTextBox.Focus();
                return;
            }

            //check duplicate column-name
            if (this.StringTable.ColumnNames.Contains(columnName))
            {
                MessageBox.Show("Duplicate Column.");
                return;
            }

            this.StringTable.ColumnNames.Add(columnName);
            RefreshDataGrid();
        }

        #endregion

        #region Private-Methods

        private void ResetTable()
        {
            //create sample table
            StringTable sampleTable = new StringTable();
            sampleTable.ColumnNames.Add("name");
            sampleTable.ColumnNames.Add("age");
            sampleTable.ColumnNames.Add("gender");

            //add sample rows
            sampleTable.Add(0, new StringRow() { { "name", "person1" }, { "age", 20.ToString() }, { "gender", "male" } });
            sampleTable.Add(1, new StringRow() { { "name", "person2" }, { "age", 18.ToString() }, { "gender", "female" } });
            sampleTable.Add(2, new StringRow() { { "name", "person3" }, { "age", 22.ToString() }, { "gender", "male" } });
            sampleTable.Add(3, new StringRow() { { "name", "person4" }, { "age", 17.ToString() }, { "gender", "female" } });

            this.StringTable = sampleTable;
            RefreshDataGrid();
        }

        private void AdjustAllRowValues()
        {
            //make sure all rows contain values for all columns
            foreach (int rowIndex in this.StringTable.Keys)
            {
                StringRow row = this.StringTable[rowIndex];
                if (row.Count < this.StringTable.ColumnNames.Count)
                {
                    for (int columnIndex = row.Count; columnIndex < this.StringTable.ColumnNames.Count; columnIndex++)
                    {
                        string cellValue = "r" + rowIndex + "c" + columnIndex;
                        row.Add(this.StringTable.ColumnNames[columnIndex], cellValue);
                    }
                }
            }
        }

        private void RefreshDataGrid()
        {
            AdjustAllRowValues();
            this.DataGridContainer.Children.Clear();
            this.DataGridContainer.Children.Add(CreateDataGrid(this.StringTable));
        }

        private DataGrid CreateDataGrid(StringTable table)
        {
            DataGrid dataGrid = new DataGrid();
            dataGrid.ItemsSource = table.Values;
            dataGrid.AutoGenerateColumns = false;
            dataGrid.IsReadOnly = true;

            dataGrid.Columns.Clear();
            foreach (string columnName in table.ColumnNames)
            {
                DataGridTextColumn textColumn = new DataGridTextColumn();
                textColumn.Header = columnName;
                textColumn.Binding = new Binding();
                textColumn.Binding.Converter = new ColumnValueSelector();
                textColumn.Binding.ConverterParameter = columnName;
                dataGrid.Columns.Add(textColumn);
            }

            return (dataGrid);
        }

        #endregion
    }
}
