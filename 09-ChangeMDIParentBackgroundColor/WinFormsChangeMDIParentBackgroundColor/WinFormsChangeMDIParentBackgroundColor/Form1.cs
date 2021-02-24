using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsChangeMDIParentBackgroundColor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			foreach(Control c in this.Controls)
				if(c is MdiClient)
					c.BackColor = Color.Blue;
				
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
