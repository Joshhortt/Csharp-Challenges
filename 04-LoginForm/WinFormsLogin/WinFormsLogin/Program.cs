
//Challenge 04: Simple Login Form
//Build a simple login form with user, password and button to enter. At start Enter button is disabled.
//When you enter details in the next field, it will automatically executes the field to enter. 
//Suppress beeps when passing fields.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLogin
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
