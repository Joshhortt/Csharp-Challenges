//Challenge 06: Control of insertion of names in two lists
//if the name in list 1 does not exist, it is added.
//if the name exists in list 1 and does not exist in list 2, it goes to list 2.
//if the name exists in both lists, it is not added.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsListControl
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
