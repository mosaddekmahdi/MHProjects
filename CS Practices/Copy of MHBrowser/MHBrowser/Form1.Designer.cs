namespace MHBrowser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabWrite = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveWrite = new System.Windows.Forms.Button();
            this.listBoxWrite = new System.Windows.Forms.ListBox();
            this.btnAddWrite = new System.Windows.Forms.Button();
            this.textBox2Write = new System.Windows.Forms.TextBox();
            this.textBox1Write = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBrowserBrowse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabWrite.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabWrite);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabWrite
            // 
            this.tabWrite.Controls.Add(this.label2);
            this.tabWrite.Controls.Add(this.label1);
            this.tabWrite.Controls.Add(this.btnSaveWrite);
            this.tabWrite.Controls.Add(this.listBoxWrite);
            this.tabWrite.Controls.Add(this.btnAddWrite);
            this.tabWrite.Controls.Add(this.textBox2Write);
            this.tabWrite.Controls.Add(this.textBox1Write);
            this.tabWrite.Location = new System.Drawing.Point(4, 22);
            this.tabWrite.Name = "tabWrite";
            this.tabWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tabWrite.Size = new System.Drawing.Size(600, 409);
            this.tabWrite.TabIndex = 1;
            this.tabWrite.Text = "Write";
            this.tabWrite.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Multiple Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Single Entry";
            // 
            // btnSaveWrite
            // 
            this.btnSaveWrite.Location = new System.Drawing.Point(77, 292);
            this.btnSaveWrite.Name = "btnSaveWrite";
            this.btnSaveWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWrite.TabIndex = 24;
            this.btnSaveWrite.Text = "&Save";
            this.btnSaveWrite.UseVisualStyleBackColor = true;
            this.btnSaveWrite.Click += new System.EventHandler(this.btnSaveWrite_Click);
            // 
            // listBoxWrite
            // 
            this.listBoxWrite.FormattingEnabled = true;
            this.listBoxWrite.Location = new System.Drawing.Point(77, 168);
            this.listBoxWrite.Name = "listBoxWrite";
            this.listBoxWrite.Size = new System.Drawing.Size(120, 95);
            this.listBoxWrite.TabIndex = 23;
            // 
            // btnAddWrite
            // 
            this.btnAddWrite.Location = new System.Drawing.Point(77, 139);
            this.btnAddWrite.Name = "btnAddWrite";
            this.btnAddWrite.Size = new System.Drawing.Size(75, 23);
            this.btnAddWrite.TabIndex = 22;
            this.btnAddWrite.Text = "&Add";
            this.btnAddWrite.UseVisualStyleBackColor = true;
            this.btnAddWrite.Click += new System.EventHandler(this.btnAddWrite_Click);
            // 
            // textBox2Write
            // 
            this.textBox2Write.Location = new System.Drawing.Point(77, 101);
            this.textBox2Write.Name = "textBox2Write";
            this.textBox2Write.Size = new System.Drawing.Size(100, 20);
            this.textBox2Write.TabIndex = 21;
            // 
            // textBox1Write
            // 
            this.textBox1Write.Location = new System.Drawing.Point(77, 60);
            this.textBox1Write.Name = "textBox1Write";
            this.textBox1Write.Size = new System.Drawing.Size(100, 20);
            this.textBox1Write.TabIndex = 20;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBrowserBrowse);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(600, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Browse";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBrowserBrowse
            // 
            this.btnBrowserBrowse.Location = new System.Drawing.Point(481, 360);
            this.btnBrowserBrowse.Name = "btnBrowserBrowse";
            this.btnBrowserBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserBrowse.TabIndex = 1;
            this.btnBrowserBrowse.Text = "&Browse";
            this.btnBrowserBrowse.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Source";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabWrite.ResumeLayout(false);
            this.tabWrite.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabWrite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSaveWrite;
        private System.Windows.Forms.ListBox listBoxWrite;
        private System.Windows.Forms.Button btnAddWrite;
        private System.Windows.Forms.TextBox textBox2Write;
        private System.Windows.Forms.TextBox textBox1Write;
        private System.Windows.Forms.Button btnBrowserBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

