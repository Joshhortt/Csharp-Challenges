using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGetYourAge
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnCalculate_Click(object sender, EventArgs e)
		{
			int age = DateTime.Now.Year - dateTimePicker.Value.Year;  
			if (DateTime.Now.DayOfYear < dateTimePicker.Value.DayOfYear) age--;

			MessageBox.Show("You are " + age + " years old right now.");
		}
	}
}
