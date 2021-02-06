
namespace WinFormsPasswordGenerator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdGenerate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listPasswords = new System.Windows.Forms.ListBox();
			this.countChars = new System.Windows.Forms.NumericUpDown();
			this.checkUppercase = new System.Windows.Forms.CheckBox();
			this.checkDigits = new System.Windows.Forms.CheckBox();
			this.checkSymbols = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.countChars)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdGenerate
			// 
			this.cmdGenerate.Location = new System.Drawing.Point(245, 387);
			this.cmdGenerate.Name = "cmdGenerate";
			this.cmdGenerate.Size = new System.Drawing.Size(140, 51);
			this.cmdGenerate.TabIndex = 0;
			this.cmdGenerate.Text = "Generate";
			this.cmdGenerate.UseVisualStyleBackColor = true;
			this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(245, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Number of Characters";
			// 
			// listPasswords
			// 
			this.listPasswords.FormattingEnabled = true;
			this.listPasswords.ItemHeight = 15;
			this.listPasswords.Location = new System.Drawing.Point(12, 7);
			this.listPasswords.Name = "listPasswords";
			this.listPasswords.Size = new System.Drawing.Size(211, 439);
			this.listPasswords.TabIndex = 7;
			// 
			// countChars
			// 
			this.countChars.Location = new System.Drawing.Point(245, 81);
			this.countChars.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.countChars.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.countChars.Name = "countChars";
			this.countChars.Size = new System.Drawing.Size(120, 23);
			this.countChars.TabIndex = 8;
			this.countChars.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			// 
			// checkUppercase
			// 
			this.checkUppercase.AutoSize = true;
			this.checkUppercase.Location = new System.Drawing.Point(245, 119);
			this.checkUppercase.Name = "checkUppercase";
			this.checkUppercase.Size = new System.Drawing.Size(83, 19);
			this.checkUppercase.TabIndex = 9;
			this.checkUppercase.Text = "UpperCase";
			this.checkUppercase.UseVisualStyleBackColor = true;
			// 
			// checkDigits
			// 
			this.checkDigits.AutoSize = true;
			this.checkDigits.Location = new System.Drawing.Point(245, 144);
			this.checkDigits.Name = "checkDigits";
			this.checkDigits.Size = new System.Drawing.Size(56, 19);
			this.checkDigits.TabIndex = 10;
			this.checkDigits.Text = "Digits";
			this.checkDigits.UseVisualStyleBackColor = true;
			// 
			// checkSymbols
			// 
			this.checkSymbols.AutoSize = true;
			this.checkSymbols.Location = new System.Drawing.Point(245, 169);
			this.checkSymbols.Name = "checkSymbols";
			this.checkSymbols.Size = new System.Drawing.Size(71, 19);
			this.checkSymbols.TabIndex = 11;
			this.checkSymbols.Text = "Symbols";
			this.checkSymbols.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 450);
			this.Controls.Add(this.checkSymbols);
			this.Controls.Add(this.checkDigits);
			this.Controls.Add(this.checkUppercase);
			this.Controls.Add(this.countChars);
			this.Controls.Add(this.listPasswords);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdGenerate);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.countChars)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdGenerate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listPasswords;
		private System.Windows.Forms.NumericUpDown countChars;
		private System.Windows.Forms.CheckBox checkUppercase;
		private System.Windows.Forms.CheckBox checkDigits;
		private System.Windows.Forms.CheckBox checkSymbols;
	}
}

