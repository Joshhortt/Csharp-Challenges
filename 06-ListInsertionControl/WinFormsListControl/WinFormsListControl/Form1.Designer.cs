
namespace WinFormsListControl
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
			this.list1 = new System.Windows.Forms.ListBox();
			this.list2 = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.textName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// list1
			// 
			this.list1.FormattingEnabled = true;
			this.list1.Location = new System.Drawing.Point(41, 84);
			this.list1.Name = "list1";
			this.list1.Size = new System.Drawing.Size(167, 277);
			this.list1.TabIndex = 0;
			// 
			// list2
			// 
			this.list2.FormattingEnabled = true;
			this.list2.Location = new System.Drawing.Point(244, 84);
			this.list2.Name = "list2";
			this.list2.Size = new System.Drawing.Size(170, 277);
			this.list2.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(244, 41);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(170, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(41, 41);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(167, 20);
			this.textName.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.list2);
			this.Controls.Add(this.list1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox list1;
		private System.Windows.Forms.ListBox list2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox textName;
	}
}

