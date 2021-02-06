
namespace WinFormsLogin
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
			this.cmdEnter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textUser = new System.Windows.Forms.TextBox();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmdEnter
			// 
			this.cmdEnter.Location = new System.Drawing.Point(160, 227);
			this.cmdEnter.Name = "cmdEnter";
			this.cmdEnter.Size = new System.Drawing.Size(75, 23);
			this.cmdEnter.TabIndex = 2;
			this.cmdEnter.Text = "Enter";
			this.cmdEnter.UseVisualStyleBackColor = true;
			this.cmdEnter.Click += new System.EventHandler(this.cmdEnter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(82, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "User";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(82, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// textUser
			// 
			this.textUser.Location = new System.Drawing.Point(85, 100);
			this.textUser.Name = "textUser";
			this.textUser.Size = new System.Drawing.Size(150, 20);
			this.textUser.TabIndex = 0;
			this.textUser.TextChanged += new System.EventHandler(this.text_textChanged);
			this.textUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textUser_KeyDown);
			// 
			// textPassword
			// 
			this.textPassword.Location = new System.Drawing.Point(85, 166);
			this.textPassword.Name = "textPassword";
			this.textPassword.Size = new System.Drawing.Size(150, 20);
			this.textPassword.TabIndex = 1;
			this.textPassword.TextChanged += new System.EventHandler(this.text_textChanged);
			this.textPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPassword_KeyDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 450);
			this.Controls.Add(this.textPassword);
			this.Controls.Add(this.textUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdEnter);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdEnter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textUser;
		private System.Windows.Forms.TextBox textPassword;
	}
}

