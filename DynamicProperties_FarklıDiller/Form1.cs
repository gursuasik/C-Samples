using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DynamicProperties_FarklęDiller
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
  internal System.Windows.Forms.Button Button1;
  internal System.Windows.Forms.TextBox TextBox3;
  internal System.Windows.Forms.Label Label3;
  internal System.Windows.Forms.TextBox TextBox2;
  internal System.Windows.Forms.Label Label2;
  internal System.Windows.Forms.TextBox TextBox1;
  internal System.Windows.Forms.Label Label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
   System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
   this.Button1 = new System.Windows.Forms.Button();
   this.TextBox3 = new System.Windows.Forms.TextBox();
   this.Label3 = new System.Windows.Forms.Label();
   this.TextBox2 = new System.Windows.Forms.TextBox();
   this.Label2 = new System.Windows.Forms.Label();
   this.TextBox1 = new System.Windows.Forms.TextBox();
   this.Label1 = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // Button1
   // 
   this.Button1.Location = new System.Drawing.Point(104, 80);
   this.Button1.Name = "Button1";
   this.Button1.Size = new System.Drawing.Size(104, 23);
   this.Button1.TabIndex = 13;
   this.Button1.Text = ((string)(configurationAppSettings.GetValue("Button1.Text", typeof(string))));
   this.Button1.Click += new System.EventHandler(this.Button1_Click);
   // 
   // TextBox3
   // 
   this.TextBox3.Location = new System.Drawing.Point(104, 56);
   this.TextBox3.Name = "TextBox3";
   this.TextBox3.TabIndex = 12;
   this.TextBox3.Text = "TextBox3";
   // 
   // Label3
   // 
   this.Label3.Location = new System.Drawing.Point(8, 56);
   this.Label3.Name = "Label3";
   this.Label3.TabIndex = 11;
   this.Label3.Text = ((string)(configurationAppSettings.GetValue("Label3.Text", typeof(string))));
   // 
   // TextBox2
   // 
   this.TextBox2.Location = new System.Drawing.Point(104, 32);
   this.TextBox2.Name = "TextBox2";
   this.TextBox2.TabIndex = 10;
   this.TextBox2.Text = "TextBox2";
   // 
   // Label2
   // 
   this.Label2.Location = new System.Drawing.Point(8, 32);
   this.Label2.Name = "Label2";
   this.Label2.Size = new System.Drawing.Size(56, 23);
   this.Label2.TabIndex = 9;
   this.Label2.Text = ((string)(configurationAppSettings.GetValue("Label2.Text", typeof(string))));
   // 
   // TextBox1
   // 
   this.TextBox1.Location = new System.Drawing.Point(104, 8);
   this.TextBox1.Name = "TextBox1";
   this.TextBox1.TabIndex = 8;
   this.TextBox1.Text = "TextBox1";
   // 
   // Label1
   // 
   this.Label1.Location = new System.Drawing.Point(8, 8);
   this.Label1.Name = "Label1";
   this.Label1.Size = new System.Drawing.Size(48, 23);
   this.Label1.TabIndex = 7;
   this.Label1.Text = ((string)(configurationAppSettings.GetValue("Label1.Text", typeof(string))));
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(216, 118);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.Button1,
                                                              this.TextBox3,
                                                              this.Label3,
                                                              this.TextBox2,
                                                              this.Label2,
                                                              this.TextBox1,
                                                              this.Label1});
   this.Name = "Form1";
   this.Text = ((string)(configurationAppSettings.GetValue("Form1.Text", typeof(string))));
   this.ResumeLayout(false);

  }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

  private void Button1_Click(object sender, System.EventArgs e)
  {
   Close();
  }
	}
}
