
namespace WinFormsGetYourAge
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
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.BtnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker.Location = new System.Drawing.Point(65, 56);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker.TabIndex = 0;
			// 
			// BtnCalculate
			// 
			this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCalculate.Location = new System.Drawing.Point(65, 130);
			this.BtnCalculate.Name = "BtnCalculate";
			this.BtnCalculate.Size = new System.Drawing.Size(200, 82);
			this.BtnCalculate.TabIndex = 1;
			this.BtnCalculate.Text = "Calculate";
			this.BtnCalculate.UseVisualStyleBackColor = true;
			this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 313);
			this.Controls.Add(this.BtnCalculate);
			this.Controls.Add(this.dateTimePicker);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Button BtnCalculate;
	}
}

