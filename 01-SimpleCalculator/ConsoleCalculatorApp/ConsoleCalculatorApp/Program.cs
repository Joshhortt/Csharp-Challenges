using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculatorApp
{
	class Program
	{
		static void Main(string[] args)
		{
			bool exit = false; 

			while(!exit)
			{
				Console.WriteLine("");
				Console.WriteLine("Calculator");
				Console.WriteLine("-----------------");
				Console.WriteLine("1. Addition");
				Console.WriteLine("2. Subtraction");
				Console.WriteLine("3. Multiplication");
				Console.WriteLine("4. Division");
				Console.WriteLine("-----------------");
				Console.WriteLine("0. Exit");
				Console.WriteLine("-----------------");

				Console.Write("Option: ");
				string option = Console.ReadLine();
				double a = 0;
				double b = 0;

				// Etxit aplication
				if (option == "0") Environment.Exit(0);
				// if (option == "0") exit = true;  is another possibility to exit the program.

				// Ask for input values
				Console.Write("A=");
				a = double.Parse(Console.ReadLine());

				Console.Write("B=");
				b = double.Parse(Console.ReadLine());

				// Execute the choosen arithmetic operation
				if (option == "1")
					Console.WriteLine(a + " + " + b + " = " + (a + b).ToString());

				else if (option == "2")
					Console.WriteLine(a + " - " + b + " = " + (a - b).ToString());

				else if (option == "3")
					Console.WriteLine(a + " x " + b + " = " + (a * b).ToString());

				else if(option == "4")
					Console.WriteLine(a + " : " + b + " = " + (a / b).ToString());

			}
		}
	}
}
