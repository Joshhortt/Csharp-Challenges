using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLogin
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cmdEnter.Enabled = false;
		}

		private void text_textChanged(object sender, EventArgs e)
		{
			cmdEnter.Enabled = textUser.Text != "" && textPassword.Text != "" ? true : false;
		}
	}
}
