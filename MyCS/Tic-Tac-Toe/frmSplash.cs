using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
	/// <summary>
	/// Summary description for frmSplash.
	/// </summary>
	public class frmSplash : System.Windows.Forms.Form
	{
		public System.Windows.Forms.ToolTip toolTip1;
		public System.Windows.Forms.Timer timer1;
		public System.ComponentModel.IContainer components;

		public frmSplash() {
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
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSplash));
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 60000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// frmSplash
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(500, 270);
			this.ControlBox = false;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSplash";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Click += new System.EventHandler(this.frmSplash_Click);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSplash_KeyPress);

		}
		#endregion

		public void frmSplash_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		public void timer1_Tick(object sender, System.EventArgs e) {
			this.Close();
		}

		public void frmSplash_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) {
			int KeyAscii = Int32.Parse(e.KeyChar.ToString());
			this.Close();
			if (KeyAscii == 0) {
				e.Handled = true;
			}
		}
	}
}