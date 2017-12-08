namespace MongoDbApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoad = new System.Windows.Forms.Button();
            this.tabInsert = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnQuickView = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDatePostedInsert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeadlineInsert = new System.Windows.Forms.TextBox();
            this.richTextBoxInsert = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSourceURLInsert = new System.Windows.Forms.TextBox();
            this.txtInstitutionInsert = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxInsert = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJobTitleInsert = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDeadlineSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInstitutionSearch = new System.Windows.Forms.TextBox();
            this.lblSearchInst = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxJobCategorySearch = new System.Windows.Forms.ComboBox();
            this.txtJobTitleSearch = new System.Windows.Forms.TextBox();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInstitutuin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPostingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.tabInsert.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(22, 346);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tabInsert
            // 
            this.tabInsert.Controls.Add(this.tabPage1);
            this.tabInsert.Controls.Add(this.tabPage2);
            this.tabInsert.Controls.Add(this.tabPage3);
            this.tabInsert.Controls.Add(this.tabImport);
            this.tabInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInsert.Location = new System.Drawing.Point(0, 0);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.SelectedIndex = 0;
            this.tabInsert.Size = new System.Drawing.Size(754, 431);
            this.tabInsert.TabIndex = 2;
            this.tabInsert.SelectedIndexChanged += new System.EventHandler(this.tabInsert_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnQuickView);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View/Edit/Delete";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(571, 334);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 23);
            this.button13.TabIndex = 11;
            this.button13.Text = "&Help";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(386, 346);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "&Print";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(467, 346);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "&Export";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(656, 372);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "&Settings";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(571, 372);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "&About";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(656, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuickView
            // 
            this.btnQuickView.Location = new System.Drawing.Point(102, 346);
            this.btnQuickView.Name = "btnQuickView";
            this.btnQuickView.Size = new System.Drawing.Size(75, 23);
            this.btnQuickView.TabIndex = 5;
            this.btnQuickView.Text = "&Quick View";
            this.btnQuickView.UseVisualStyleBackColor = true;
            this.btnQuickView.Click += new System.EventHandler(this.btnQuickInfo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "&Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(723, 304);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.txtDatePostedInsert);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtDeadlineInsert);
            this.tabPage2.Controls.Add(this.richTextBoxInsert);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtSourceURLInsert);
            this.tabPage2.Controls.Add(this.txtInstitutionInsert);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.comboBoxInsert);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtJobTitleInsert);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insert";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtDatePostedInsert
            // 
            this.txtDatePostedInsert.Location = new System.Drawing.Point(472, 64);
            this.txtDatePostedInsert.Name = "txtDatePostedInsert";
            this.txtDatePostedInsert.Size = new System.Drawing.Size(218, 20);
            this.txtDatePostedInsert.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date Posted:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Deadline:";
            // 
            // txtDeadlineInsert
            // 
            this.txtDeadlineInsert.Location = new System.Drawing.Point(472, 104);
            this.txtDeadlineInsert.Name = "txtDeadlineInsert";
            this.txtDeadlineInsert.Size = new System.Drawing.Size(218, 20);
            this.txtDeadlineInsert.TabIndex = 17;
            // 
            // richTextBoxInsert
            // 
            this.richTextBoxInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBoxInsert.Location = new System.Drawing.Point(117, 188);
            this.richTextBoxInsert.Name = "richTextBoxInsert";
            this.richTextBoxInsert.Size = new System.Drawing.Size(573, 163);
            this.richTextBoxInsert.TabIndex = 13;
            this.richTextBoxInsert.Text = "";
            this.richTextBoxInsert.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Notes or Job Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Source URL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Institution:";
            // 
            // txtSourceURLInsert
            // 
            this.txtSourceURLInsert.Location = new System.Drawing.Point(117, 139);
            this.txtSourceURLInsert.Name = "txtSourceURLInsert";
            this.txtSourceURLInsert.Size = new System.Drawing.Size(573, 20);
            this.txtSourceURLInsert.TabIndex = 8;
            // 
            // txtInstitutionInsert
            // 
            this.txtInstitutionInsert.Location = new System.Drawing.Point(472, 29);
            this.txtInstitutionInsert.Name = "txtInstitutionInsert";
            this.txtInstitutionInsert.Size = new System.Drawing.Size(218, 20);
            this.txtInstitutionInsert.TabIndex = 8;
            this.txtInstitutionInsert.TextChanged += new System.EventHandler(this.txtInstitution_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // comboBoxInsert
            // 
            this.comboBoxInsert.FormattingEnabled = true;
            this.comboBoxInsert.Items.AddRange(new object[] {
            "Administrative",
            "Executive",
            "Faculty",
            "Full-time",
            "Part-time",
            "Programming",
            "Staff",
            "Student Assistant",
            "Web Developing"});
            this.comboBoxInsert.Location = new System.Drawing.Point(117, 67);
            this.comboBoxInsert.Name = "comboBoxInsert";
            this.comboBoxInsert.Size = new System.Drawing.Size(226, 21);
            this.comboBoxInsert.TabIndex = 6;
            this.comboBoxInsert.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Entered:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Job Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job Title:";
            // 
            // txtJobTitleInsert
            // 
            this.txtJobTitleInsert.Location = new System.Drawing.Point(117, 29);
            this.txtJobTitleInsert.Name = "txtJobTitleInsert";
            this.txtJobTitleInsert.Size = new System.Drawing.Size(226, 20);
            this.txtJobTitleInsert.TabIndex = 2;
            this.txtJobTitleInsert.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(617, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.txtDeadlineSearch);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtInstitutionSearch);
            this.tabPage3.Controls.Add(this.lblSearchInst);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.comboBoxJobCategorySearch);
            this.tabPage3.Controls.Add(this.txtJobTitleSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(746, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search";
            // 
            // txtDeadlineSearch
            // 
            this.txtDeadlineSearch.Location = new System.Drawing.Point(603, 58);
            this.txtDeadlineSearch.Name = "txtDeadlineSearch";
            this.txtDeadlineSearch.Size = new System.Drawing.Size(121, 20);
            this.txtDeadlineSearch.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Search by Deadline:";
            // 
            // txtInstitutionSearch
            // 
            this.txtInstitutionSearch.Location = new System.Drawing.Point(603, 22);
            this.txtInstitutionSearch.Name = "txtInstitutionSearch";
            this.txtInstitutionSearch.Size = new System.Drawing.Size(121, 20);
            this.txtInstitutionSearch.TabIndex = 16;
            // 
            // lblSearchInst
            // 
            this.lblSearchInst.AutoSize = true;
            this.lblSearchInst.Location = new System.Drawing.Point(476, 25);
            this.lblSearchInst.Name = "lblSearchInst";
            this.lblSearchInst.Size = new System.Drawing.Size(106, 13);
            this.lblSearchInst.TabIndex = 15;
            this.lblSearchInst.Text = "Search by Institution:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(730, 246);
            this.dataGridView2.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(335, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search by Job Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search by Job Title:";
            // 
            // comboBoxJobCategorySearch
            // 
            this.comboBoxJobCategorySearch.FormattingEnabled = true;
            this.comboBoxJobCategorySearch.Items.AddRange(new object[] {
            "Administrative",
            "Executive",
            "Faculty",
            "Full-time",
            "Part-time",
            "Programming",
            "Staff",
            "Student Assistant",
            "Web Developing"});
            this.comboBoxJobCategorySearch.Location = new System.Drawing.Point(161, 25);
            this.comboBoxJobCategorySearch.Name = "comboBoxJobCategorySearch";
            this.comboBoxJobCategorySearch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJobCategorySearch.TabIndex = 8;
            // 
            // txtJobTitleSearch
            // 
            this.txtJobTitleSearch.Location = new System.Drawing.Point(161, 62);
            this.txtJobTitleSearch.Name = "txtJobTitleSearch";
            this.txtJobTitleSearch.Size = new System.Drawing.Size(121, 20);
            this.txtJobTitleSearch.TabIndex = 7;
            this.txtJobTitleSearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabImport
            // 
            this.tabImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabImport.Controls.Add(this.comboBox4);
            this.tabImport.Controls.Add(this.button6);
            this.tabImport.Controls.Add(this.button5);
            this.tabImport.Controls.Add(this.button1);
            this.tabImport.Controls.Add(this.checkBox1);
            this.tabImport.Controls.Add(this.btnImport);
            this.tabImport.Controls.Add(this.label15);
            this.tabImport.Controls.Add(this.label16);
            this.tabImport.Controls.Add(this.comboBox3);
            this.tabImport.Controls.Add(this.dataGridView3);
            this.tabImport.Location = new System.Drawing.Point(4, 22);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImport.Size = new System.Drawing.Size(746, 405);
            this.tabImport.TabIndex = 3;
            this.tabImport.Text = "Import";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(156, 58);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(421, 21);
            this.comboBox4.TabIndex = 31;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(545, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 23);
            this.button6.TabIndex = 30;
            this.button6.Text = "&Remove";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(448, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "&Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "&Queue";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(602, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Add this site in the List";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(359, 14);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(71, 23);
            this.btnImport.TabIndex = 25;
            this.btnImport.Text = "&Find";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Select an Existing Job Site:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Enter a Job Site URL:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Careerbuilder.com",
            "Chronical.com",
            "Dice.com",
            "Higheredjobs.com",
            "Itjobs.com",
            "Mathjobs.org",
            "Monster.com"});
            this.comboBox3.Location = new System.Drawing.Point(156, 16);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPosition,
            this.clmCategory,
            this.clmInstitutuin,
            this.clmPostingDate,
            this.clmDueDate,
            this.clmContactPerson,
            this.clmNotes});
            this.dataGridView3.Location = new System.Drawing.Point(3, 89);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(730, 308);
            this.dataGridView3.TabIndex = 4;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "JobTitle";
            this.clmPosition.Name = "clmPosition";
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "JobCategory";
            this.clmCategory.Name = "clmCategory";
            // 
            // clmInstitutuin
            // 
            this.clmInstitutuin.HeaderText = "Institution";
            this.clmInstitutuin.Name = "clmInstitutuin";
            // 
            // clmPostingDate
            // 
            this.clmPostingDate.HeaderText = "DatePosted";
            this.clmPostingDate.Name = "clmPostingDate";
            // 
            // clmDueDate
            // 
            this.clmDueDate.HeaderText = "Deadline";
            this.clmDueDate.Name = "clmDueDate";
            // 
            // clmContactPerson
            // 
            this.clmContactPerson.HeaderText = "SourceURL";
            this.clmContactPerson.Name = "clmContactPerson";
            // 
            // clmNotes
            // 
            this.clmNotes.HeaderText = "Notes";
            this.clmNotes.Name = "clmNotes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "&Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 431);
            this.Controls.Add(this.tabInsert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyJobS-Manages You Job Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabInsert.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabImport.ResumeLayout(false);
            this.tabImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TabControl tabInsert;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJobTitleInsert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnQuickView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxJobCategorySearch;
        private System.Windows.Forms.TextBox txtJobTitleSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.RichTextBox richTextBoxInsert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSourceURLInsert;
        private System.Windows.Forms.TextBox txtInstitutionInsert;
        private System.Windows.Forms.TextBox txtInstitutionSearch;
        private System.Windows.Forms.Label lblSearchInst;
        private System.Windows.Forms.TextBox txtDeadlineSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeadlineInsert;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInstitutuin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPostingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox txtDatePostedInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

