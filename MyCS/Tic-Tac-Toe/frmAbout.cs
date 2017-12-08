using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
	/// <summary>
	/// Summary description for frmAbout.
	/// </summary>
	public class frmAbout : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox picFace;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.Container components = null;

		public frmAbout()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAbout));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.picFace = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(208, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name: Jacob Soo Lead Re";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(208, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "E-Mail: jacob.soo@blurberries.com";
			// 
			// picFace
			// 
			this.picFace.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("picFace.BackgroundImage")));
			this.picFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picFace.Location = new System.Drawing.Point(8, 24);
			this.picFace.Name = "picFace";
			this.picFace.Size = new System.Drawing.Size(184, 240);
			this.picFace.TabIndex = 3;
			this.picFace.TabStop = false;
			// 
			// frmAbout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(394, 279);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.picFace,
																		  this.label3,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.Text = "About Jacob Soo Lead Re";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
