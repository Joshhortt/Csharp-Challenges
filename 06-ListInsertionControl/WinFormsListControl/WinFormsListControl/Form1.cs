using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsListControl
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (textName.Text == "") return;

			// verify if name exists in the two lists, should be in top because if the name exists in both lists, 
			// it doesn´t have to verify anything else
			if (list1.Items.Contains(textName.Text) && list2.Items.Contains(textName.Text)) return;

			// Adds the name to list 1
			if (!list1.Items.Contains(textName.Text))
				{
				list1.Items.Add(textName.Text);
				return;
			}

			// Adds the name to list 2

			list2.Items.Add(textName.Text);
			return;
		}
	}
}
