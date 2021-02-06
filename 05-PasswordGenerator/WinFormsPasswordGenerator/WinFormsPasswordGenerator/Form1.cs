using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPasswordGenerator
{
	public partial class Form1 : Form
	{
		int num_passwords = 10;

		public Form1()
		{
			InitializeComponent();
		}

		private void cmdGenerate_Click(object sender, EventArgs e)
		{
			string chars = "abcdefghijklmnopqrstuvwxyz";
			if(checkUppercase.Checked)
				chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			if (checkDigits.Checked)
				chars += "0123456789";
			if (checkSymbols.Checked)
				chars += "#/$!?=-\"";
		}
	}
}
