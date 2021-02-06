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

			listPasswords.Items.Clear(); // Everytime the button is clicked it clears the fields. 
			Random random = new Random(); //Random object out of the loop, to avoid repetition of passwords.

			for(int n = 1; n <= num_passwords; n++)
			{
				//Random random = new Random();   // Better use ouside the loop cycle to avoid repetition of passwords
				StringBuilder str = new StringBuilder();  // Creates a new empty string
				for (int m = 1; m <= countChars.Value; m++)  // Loop through counting chars
				{  
				int position = random.Next(0, chars.Length);  // Random values
				str.Append(chars[position].ToString());  // Associates to string the character that has a certain position inside string chars and it converts it to string
			}
				listPasswords.Items.Add(str.ToString());  // List all generated passwords converted to string inside list box.
			}
		}
	}
}
