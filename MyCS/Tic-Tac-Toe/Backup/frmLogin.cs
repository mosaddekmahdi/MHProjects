using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tic_Tac_Toe
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Label lblName;
		public System.Windows.Forms.Button btnStart;
		public System.Windows.Forms.Button btnAbout;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.Container components = null;
		public frmAbout frmA = new frmAbout();
		public frmMain frmM = new frmMain();
		public static frmLogin frmL = new frmLogin();
		public frmSplash frmS = new frmSplash();

		public frmLogin()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLogin));
			this.lblName = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(16, 24);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(96, 23);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Enter your Name:";
			// 
			// btnStart
			// 
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Location = new System.Drawing.Point(120, 54);
			this.btnStart.Name = "btnStart";
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbout.Location = new System.Drawing.Point(120, 87);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.TabIndex = 2;
			this.btnAbout.Text = "About";
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(120, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(152, 20);
			this.txtName.TabIndex = 0;
			this.txtName.Text = "";
			// 
			// frmLogin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 127);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.Text = "Login Screen:";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(frmL);
		}

		private void btnAbout_Click(object sender, System.EventArgs e) {			
			frmA.Show();
		}

		private void btnStart_Click(object sender, System.EventArgs e)
		{
			if (txtName.Text == "") 
			{
				MessageBox.Show("Enter your name ...", "Tic-Tac-Toe");
				txtName.Focus();
			} 
			else 
			{
				frmM.Show();
				frmL.Hide();
			}
		}

		private void frmLogin_Load(object sender, System.EventArgs e) {			
			frmS.ShowDialog();
			this.Show();
		}
	}
}