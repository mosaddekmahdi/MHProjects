using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sql_DB_example_cs
{
    public partial class Form1 : Form
    {

        //form level variables
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize the SqlConnection
            conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\testDB2.mdf;Integrated Security=True;User Instance=True");
            //comboBox used to filter datasource
            comboBox1.DataSource = new string[] { "Even ID", "Odd ID" };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filter datasource
            changeDataSource(comboBox1.SelectedIndex);
            testTableDataGridView.DataSource = dt;
        }

        private void changeDataSource(int x)
        {
            //sql select command
            SqlCommand cmd = new SqlCommand("SELECT * FROM testTable WHERE ID % 2 = @odd", conn);
            cmd.Parameters.AddWithValue("@odd", x);

            //SqlCommandBuilder builds update, inser, delete commands used in .Update
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            //reassign + refill dt
            dt = new DataTable();
            da.Fill(dt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save changes
            da.Update(dt);
        }

    }
}
