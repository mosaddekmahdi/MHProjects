using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.Container components = null;
		public bool ply;
		public bool disp;
		public string last;
		public frmMain frmM;
		public frmLogin frmL;
		public frmAbout frmA;
		public System.Windows.Forms.Label lblMessage;
		public System.Windows.Forms.Button btn1;
		public System.Windows.Forms.Button btn2;
		public System.Windows.Forms.Button btn3;
		public System.Windows.Forms.Button btn4;
		public System.Windows.Forms.Button btn5;
		public System.Windows.Forms.Button btn6;
		public System.Windows.Forms.Button btn7;
		public System.Windows.Forms.Button btn8;
		public System.Windows.Forms.Button btn9;
		public System.Windows.Forms.Button btnMain;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuClose;
		private System.Windows.Forms.MenuItem mnuHelp;
		private System.Windows.Forms.MenuItem mnuAbout;
		public System.Windows.Forms.Button btnReset;
		

		public frmMain() {
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
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btnMain = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuClose = new System.Windows.Forms.MenuItem();
			this.mnuHelp = new System.Windows.Forms.MenuItem();
			this.mnuAbout = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn1.Location = new System.Drawing.Point(24, 80);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(70, 70);
			this.btn1.TabIndex = 0;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn2
			// 
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn2.Location = new System.Drawing.Point(104, 80);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(70, 70);
			this.btn2.TabIndex = 1;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn3
			// 
			this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn3.Location = new System.Drawing.Point(184, 80);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(70, 70);
			this.btn3.TabIndex = 2;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn4
			// 
			this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn4.Location = new System.Drawing.Point(24, 160);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(70, 70);
			this.btn4.TabIndex = 3;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// btn5
			// 
			this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn5.Location = new System.Drawing.Point(104, 160);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(70, 70);
			this.btn5.TabIndex = 4;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			// 
			// btn6
			// 
			this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn6.Location = new System.Drawing.Point(184, 160);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(70, 70);
			this.btn6.TabIndex = 5;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			// 
			// btn7
			// 
			this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn7.Location = new System.Drawing.Point(24, 240);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(70, 70);
			this.btn7.TabIndex = 6;
			this.btn7.Click += new System.EventHandler(this.btn7_Click);
			// 
			// btn8
			// 
			this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn8.Location = new System.Drawing.Point(104, 240);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(70, 70);
			this.btn8.TabIndex = 7;
			this.btn8.Click += new System.EventHandler(this.btn8_Click);
			// 
			// btn9
			// 
			this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn9.Location = new System.Drawing.Point(184, 240);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(70, 70);
			this.btn9.TabIndex = 8;
			this.btn9.Click += new System.EventHandler(this.btn9_Click);
			// 
			// btnMain
			// 
			this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMain.Location = new System.Drawing.Point(88, 328);
			this.btnMain.Name = "btnMain";
			this.btnMain.TabIndex = 9;
			this.btnMain.Text = "Main";
			this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
			// 
			// btnReset
			// 
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Location = new System.Drawing.Point(176, 328);
			this.btnReset.Name = "btnReset";
			this.btnReset.TabIndex = 10;
			this.btnReset.Text = "Reset";
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblMessage.Location = new System.Drawing.Point(8, 40);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(256, 23);
			this.lblMessage.TabIndex = 11;
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnuFile,
																					 this.mnuHelp});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuClose});
			this.mnuFile.Text = "&File";
			// 
			// mnuClose
			// 
			this.mnuClose.Index = 0;
			this.mnuClose.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.mnuClose.Text = "Close";
			this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.Index = 1;
			this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuAbout});
			this.mnuHelp.Text = "&Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Index = 0;
			this.mnuAbout.Text = "About the Author";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 365);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnMain);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.Text = "Tic-Tac-Toe by Jacob Soo Lead Re";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}
		#endregion

		#region Reset
		/// <summary>
		/// This function is to reset the game to the default settings .
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnReset_Click(object sender, System.EventArgs e) 
		{
			btn1.Enabled = true;
			btn2.Enabled = true;
			btn3.Enabled = true;
			btn4.Enabled = true;
			btn5.Enabled = true;
			btn6.Enabled = true;
			btn7.Enabled = true;
			btn8.Enabled = true;
			btn9.Enabled = true;
			btn1.Text = "";
			btn2.Text = "";
			btn3.Text = "";
			btn4.Text = "";
			btn5.Text = "";
			btn6.Text = "";
			btn7.Text = "";
			btn8.Text = "";
			btn9.Text = "";
			// true is player one.
			ply = true;
			lblMessage.Text = Tic_Tac_Toe.frmLogin.frmL.txtName.Text + "'s chance";
			// true is x.
			disp = true;
		}
		#endregion

		#region Form Load
		/// <summary>
		/// This is the starting values when you start the game.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmMain_Load(object sender, System.EventArgs e) 
		{
			lblMessage.Text = Tic_Tac_Toe.frmLogin.frmL.txtName.Text + "'s chance";
			// true is player one.
			ply = true;
			// true is x.
			disp = true;
		}
		#endregion

		#region Login Screen
		/// <summary>
		/// This function will return you to the login screen.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnMain_Click(object sender, System.EventArgs e) 
		{
			this.Hide();
			Tic_Tac_Toe.frmLogin.frmL.Show();
		}
		#endregion

		#region Dsiable Buttons
		/// <summary>
		/// This function is to disable the buttons.
		/// </summary>
		public void clsr() 
		{
			btn1.Enabled = false;
			btn2.Enabled = false;
			btn3.Enabled = false;
			btn4.Enabled = false;
			btn5.Enabled = false;
			btn6.Enabled = false;
			btn7.Enabled = false;
			btn8.Enabled = false;
			btn9.Enabled = false;
		}
		#endregion

		#region Check
		/// <summary>
		/// This function is is used to check wether the user or computer has won!!!.
		/// </summary> 
		public void check() {
			if (btn3.Text == "X") {
				if (btn5.Text == "X") {
					if (btn7.Text == "X") {
						clsr();
						MessageBox.Show(Tic_Tac_Toe.frmLogin.frmL.txtName.Text + " wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
			
			if (btn4.Text == "X") {
				if (btn5.Text == "X") {
					if (btn6.Text == "X") {
						clsr();
						MessageBox.Show(Tic_Tac_Toe.frmLogin.frmL.txtName.Text + " wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
			
			if (btn7.Text == "X") {
				if (btn8.Text == "X") {
					if (btn9.Text == "X") {
						clsr();
						MessageBox.Show(Tic_Tac_Toe.frmLogin.frmL.txtName.Text + " wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn2.Text == "X") {
				if (btn5.Text == "X") {
					if (btn8.Text == "X") {
						clsr();
						MessageBox.Show(Tic_Tac_Toe.frmLogin.frmL.txtName.Text + " wins", "Tic-Tac-Toe");
						return;
					}
				}
			}
			
			if (btn3.Text == "X") {
				if (btn6.Text == "X") {
					if (btn9.Text == "X") {
						clsr();
						MessageBox.Show(Tic_Tac_Toe.frmLogin.frmL.txtName.Text + " wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn1.Text == "X") {
				if (btn2.Text == "X") {
					if (btn3.Text == "X") {
						clsr();
						MessageBox.Show(Tic_Tac_Toe.frmLogin.frmL.txtName.Text + " wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn1.Text == "X") {
				if (btn5.Text == "X") {
					if (btn9.Text == "X") {
						clsr();
						MessageBox.Show(Tic_Tac_Toe.frmLogin.frmL.txtName.Text + " wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn1.Text == "X") {
				if (btn4.Text == "X") {
					if (btn7.Text == "X") {
						clsr();
						MessageBox.Show(Tic_Tac_Toe.frmLogin.frmL.txtName.Text + " wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn1.Text == "0") {
				if (btn2.Text == "0") {
					if (btn3.Text == "0") {
						clsr();
						MessageBox.Show("Computer wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn1.Text == "0") {
				if (btn5.Text == "0") {
					if (btn9.Text == "0") {
						clsr();
						MessageBox.Show("Computer wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn1.Text == "0") {
				if (btn4.Text == "0") {
					if (btn7.Text == "0") {
						clsr();
						MessageBox.Show("Computer wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn3.Text == "0") {
				if (btn5.Text == "0") {
					if (btn7.Text == "0") {
						clsr();
						MessageBox.Show("Computer wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn4.Text == "0") {
				if (btn5.Text == "0") {
					if (btn6.Text == "0") {
						clsr();
						MessageBox.Show("Computer wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn7.Text == "0") {
				if (btn8.Text == "0") {
					if (btn9.Text == "0") {
						clsr();
						MessageBox.Show("Computer wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn2.Text == "0") {
				if (btn5.Text == "0") {
					if (btn8.Text == "0") {
						clsr();
						MessageBox.Show("Computer wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn3.Text == "0") {
				if (btn6.Text == "0") {
					if (btn9.Text == "0") {
						clsr();
						MessageBox.Show("Computer wins", "Tic-Tac-Toe");
						return;
					}
				}  
			}
            
			if (btn1.Enabled == false && btn2.Enabled == false && btn3.Enabled == false && btn4.Enabled == false && btn5.Enabled == false && btn6.Enabled == false && btn7.Enabled == false && btn8.Enabled == false && btn9.Enabled == false) {
				MessageBox.Show("Draw!!!", "Tic-Tac-Toe");
				return;
			}
		}

		#endregion

		public void auto(string last){
			if (btn1.Text == "0" && btn2.Text == "0") {
				if (btn3.Enabled == true) {
					btn3.Text = "0";
					btn3.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn2.Text == "0" && btn3.Text == "0") {
				if (btn1.Enabled == true) {
					btn1.Text = "0";
					btn1.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn1.Text == "0" && btn3.Text == "0") {
				if (btn2.Enabled == true) {
					btn2.Text = "0";
					btn2.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn1.Text == "0" && btn7.Text == "0") {
				if (btn4.Enabled == true) {
					btn4.Text = "0";
					btn4.Enabled = false;
					check();
					return;
				}
			}
			
			if (btn1.Text == "0" && btn4.Text == "0") {
				if (btn7.Enabled == true) {
					btn7.Text = "0";
					btn7.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn4.Text == "0" && btn7.Text == "0") {
				if (btn1.Enabled == true) {
					btn1.Text = "0";
					btn1.Enabled = false;
					check();
					return;
				}
			}
		    
			if (btn1.Text == "0" && btn5.Text == "0") {
				if (btn9.Enabled == true) {
					btn9.Text = "0";
					btn9.Enabled = false;
					check();
					return;
				}
			}
			
			if (btn5.Text == "0" && btn9.Text == "0") {
				if (btn1.Enabled == true) {
					btn1.Text = "0";
					btn1.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn1.Text == "0" && btn9.Text == "0") {
				if (btn5.Enabled == true) {
					btn5.Text = "0";
					btn5.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn2.Text == "0" && btn5.Text == "0") {
				if (btn8.Enabled == true) {
					btn8.Text = "0";
					btn8.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn2.Text == "0" && btn8.Text == "0") {
				if (btn5.Enabled == true) {
					btn5.Text = "0";
					btn5.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn5.Text == "0" && btn8.Text == "0") {
				if (btn2.Enabled == true) {
					btn2.Text = "0";
					btn2.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn3.Text == "0" && btn6.Text == "0") {
				if (btn9.Enabled == true) {
					btn9.Text = "0";
					btn9.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn5.Text == "0" && btn8.Text == "0") {
				if (btn2.Enabled == true) {
					btn2.Text = "0";
					btn2.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn3.Text == "0" && btn9.Text == "0") {
				if (btn6.Enabled == true) {
					btn6.Text = "0";
					btn6.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn6.Text == "0" && btn9.Text == "0") {
				if (btn3.Enabled == true) {
					btn3.Text = "0";
					btn3.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn4.Text == "0" && btn5.Text == "0") {
				if (btn4.Enabled == true) {
					btn6.Text = "0";
					btn6.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn4.Text == "0" && btn6.Text == "0") {
				if (btn5.Enabled == true) {
					btn5.Text = "0";
					btn5.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn5.Text == "0" && btn6.Text == "0") {
				if (btn4.Enabled == true) {
					btn4.Text = "0";
					btn4.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn7.Text == "0" && btn9.Text == "0" ) {
				if (btn8.Enabled == true) {
					btn8.Text = "0";
					btn8.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn8.Text == "0" && btn9.Text == "0") {
				if (btn7.Enabled == true) {
					btn7.Text = "0";
					btn7.Enabled = false;
					check();
					return;
				}
			}
			
			if (btn7.Text == "0" && btn8.Text == "0") {
				if (btn9.Enabled == true) {
					btn9.Text = "0";
					btn9.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn3.Text == "0" && btn5.Text == "0") {
				if (btn7.Enabled == true) {
					btn7.Text = "0";
					btn7.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn5.Text == "0" && btn7.Text == "0") {
				if (btn3.Enabled == true) {
					btn3.Text = "0";
					btn3.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn3.Text == "0" && btn7.Text == "0") {
				if (btn5.Enabled == true) {
					btn5.Text = "0";
					btn5.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn1.Text == "X" && btn2.Text == "X" ) {
				if (btn3.Enabled == true) {
					btn3.Text = "0";
					btn3.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn2.Text == "X" && btn3.Text == "X") {
				if (btn1.Enabled == true) {
					btn1.Text = "0";
					btn1.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn1.Text == "X" && btn3.Text == "X") {
				if (btn2.Enabled == true) {
					btn2.Text = "0";
					btn2.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn1.Text == "X" && btn4.Text == "X") {
				if (btn7.Enabled == true) {
					btn7.Text = "0";
					btn7.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn1.Text == "X" && btn7.Text == "X") {
				if (btn4.Enabled == true) {
					btn4.Text = "0";
					btn4.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn4.Text == "X" && btn7.Text == "X") {
				if (btn1.Enabled == true) {
					btn1.Text = "0";
					btn1.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn1.Text == "X" && btn9.Text == "X") {
				if (btn5.Enabled == true) {
					btn5.Text = "0";
					btn5.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn1.Text == "X" && btn5.Text == "X") {
				if (btn9.Enabled == true) {
					btn9.Text = "0";
					btn9.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn5.Text == "X" && btn9.Text == "X") 
			{
				if (btn5.Enabled == true) 
				{
					btn1.Text = "0";
					btn1.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn4.Text == "X" && btn5.Text == "X") {
				if (btn6.Enabled == true) {
					btn6.Text = "0";
					btn6.Enabled = false;
					check();
					return;
				}
			}
            
            if (btn4.Text == "X" && btn6.Text == "X") {
				if (btn5.Enabled == true) {
					btn5.Text = "0";
					btn5.Enabled = false;
					check();
					return;
				}
			}
 
            if (btn5.Text == "X" && btn6.Text == "X") {
				if (btn4.Enabled == true) {
					btn4.Text = "0";
					btn4.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn7.Text == "X" && btn9.Text == "X") {
				if (btn8.Enabled == true) {
					btn8.Text = "0";
					btn8.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn7.Text == "X" && btn8.Text == "X") {
				if (btn9.Enabled == true) {
					btn9.Text = "0";
					btn9.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn8.Text == "X" && btn9.Text == "X") {
				if (btn7.Enabled == true) {
					btn7.Text = "0";
					btn7.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn2.Text == "X" && btn5.Text == "X") {
				if (btn8.Enabled == true) {
					btn8.Text = "0";
					btn8.Enabled = false;
					check();
					return;
				}
			}
            
            if (btn3.Text == "X" && btn6.Text == "X") {
				if (btn9.Enabled == true) {
					btn9.Text = "0";
					btn9.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn5.Text == "X" && btn7.Text == "X") {
				if (btn3.Enabled == true) {
					btn3.Text = "0";
					btn3.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn2.Text == "X" && btn7.Text == "X") 
			{
				if (btn5.Enabled == true) 
				{
					btn5.Text = "0";
					btn5.Enabled = false;
					check();
					return;
				}
			}
   
			if (btn3.Text == "X" && btn9.Text == "X")
			{
				if (btn6.Enabled == true)
				{
					btn6.Text = "0";
					btn6.Enabled = false;
					check();
					return;
				}
			}
			
			if (btn6.Text == "X" && btn9.Text == "X") 
			{
				if (btn3.Enabled == true) 
				{
					btn3.Text = "0";
					btn3.Enabled = false;
					check();
					return;
				}
			}
			
			if (btn3.Text == "X" && btn9.Text == "X") 
			{
				if (btn6.Enabled == true) 
				{
					btn6.Text = "0";
					btn6.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn5.Text == "X" && btn8.Text == "X") 
			{
				if (btn2.Enabled == true) 
				{
					btn2.Text = "0";
					btn2.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn3.Text =="X" && btn5.Text == "X") 
			{
				if (btn7.Enabled == true) 
				{
					btn7.Text = "0";
					btn7.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn5.Text == "X" && btn7.Text == "X") 
			{
				if (btn3.Enabled == true) 
				{
					btn3.Text = "0";
					btn3.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn3.Text == "X" && btn7.Text == "X") 
			{
				if (btn5.Enabled == true) 
				{
					btn5.Text = "0";
					btn5.Enabled = false;
					check();
					return;
				}
			}
			
			if (btn5.Enabled == true) 
			{
				btn5.Text = "0";
				btn5.Enabled = false;
				check();
				return;
			}
			
			if (btn1.Text == "X" && btn9.Text == "X" && btn5.Text == "0") 
			{
				if (btn2.Enabled == true) 
				{
					btn2.Text = "0";
					btn2.Enabled = false;
					check();
					return;
				}
			}
			
			if (btn3.Text == "X" && btn7.Text == "X" && btn5.Text == "0") 
			{
				if (btn2.Enabled == true) 
				{
					btn2.Text = "0";
					btn2.Enabled = false;
					check();
					return;
				}
			}
			
			if (btn5.Text == "0" && btn2.Text == "X") 
			{
				if (btn3.Enabled == true) 
				{
					btn3.Text = "0";
					btn3.Enabled = false;
					check();
					return;
				}
			}
            
			if (btn5.Text == "0" && btn8.Text == "X") 
			{
				if (btn9.Enabled == true) 
				{
					btn9.Text = "0";
					btn9.Enabled = false;
					check();
					return;
				}
			}
            
			// last options...if none of the above are true
			if (btn1.Enabled == true) 
			{
				btn1.Text = "0";	
				btn1.Enabled = false;
				check();
				return;
			}
			
			if (btn3.Enabled == true) 
			{
				btn3.Text = "0";
				btn3.Enabled = false;
				check();
				return;
			}
            
			if (btn9.Enabled == true) 
			{
				btn9.Text = "0";
				btn9.Enabled = false;
				check();
				return;
			}
            
			if (btn6.Enabled == true) 
			{
				btn6.Text = "0";
				btn6.Enabled = false;
				check();
				return;
			}
		}

		private void btn1_Click(object sender, System.EventArgs e)
		{
			btn1.Text = "X";
			btn1.Enabled = false;
			last = "btn1";
			check();
			auto(last);
		}

		private void btn2_Click(object sender, System.EventArgs e)
		{
			btn2.Text = "X";
			btn2.Enabled = false;
			last = "btn2";
			check();
			auto(last);
		}		

		private void btn3_Click(object sender, System.EventArgs e)
		{
			btn3.Text = "X";
			btn3.Enabled = false;
			last = "btn3";
			check();
			auto(last);
		}

		private void btn4_Click(object sender, System.EventArgs e)
		{
			btn4.Text = "X";
			btn4.Enabled = false;
			last = "btn4";
			check();
			auto(last);
		}

		private void btn5_Click(object sender, System.EventArgs e)
		{
			btn5.Text = "X";
			btn5.Enabled = false;
			last = "btn5";
			check();
			auto(last);
		}

		private void btn6_Click(object sender, System.EventArgs e)
		{
			btn6.Text = "X";
			btn6.Enabled = false;
			last = "btn6";
			check();
			auto(last);
		}

		private void btn7_Click(object sender, System.EventArgs e)
		{
			btn7.Text = "X";
			btn7.Enabled = false;
			last = "btn7";
			check();
			auto(last);
		}

		private void btn8_Click(object sender, System.EventArgs e)
		{
			btn8.Text = "X";
			btn8.Enabled = false;
			last = "btn8";
			check();
			auto(last);
		}

		private void btn9_Click(object sender, System.EventArgs e)
		{
			btn9.Text = "X";
			btn9.Enabled = false;
			last = "btn9";
			check();
			auto(last);
		}

		private void mnuClose_Click(object sender, System.EventArgs e) {
			Application.Exit();
		}

		private void mnuAbout_Click(object sender, System.EventArgs e) {
			frmA = new frmAbout();
			frmA.Show();
		}
	}
}