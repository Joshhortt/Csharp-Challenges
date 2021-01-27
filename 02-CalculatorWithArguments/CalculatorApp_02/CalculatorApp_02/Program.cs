using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp_02
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1. version
			string version = "v1.0.0";

			// 3. error
			if (args.Length == 0)
			{
				error();
			}
			// 4. presenting the version
			if (args[0] == "-v")
			{
				Console.WriteLine("CALCULATOR: " + version);
				Environment.Exit(0);
			}
			if (args.Length != 3)
			{
				error();
			}
			// 5. verfies if data is corret 
			bool forward = true;

			// x + y

			// x = [0]
			// + = [1]
			// y = [2]

			// 6. check if x exists ( Is it false to tryparse double the argument [0]. If it can convert it out in x double
			if (!double.TryParse(args[0], out double a)) forward = false;

			// 8. the operation with array. (If inside the array of symbols is not the argument [1], than going forward is false)
			string[] symbols = {"+", "-", "*", ":" };
			if (!symbols.Any(args[1].Contains)) forward = false;

			// 7. check if y exists ( Is it false to tryparse double the argument [2]. If it can convert it out in y double.
			if (!double.TryParse(args[2], out double y)) forward = false;

			// 9. if going forward false than error
			if (!forward) error();

			// 10. Execute the operations
			string operation = args[0];
			string result = "";
			if (operation == "+") result = (a + y).ToString();
			else if (operation == "-") result = (a - y).ToString();
			else if (operation == "*") result = (a * y).ToString();
			else if (operation == ":") result = (a / y).ToString();

			// 11. Print result to console
			Console.WriteLine(result);	
		}

		static void error()  // 2. argumentos
		{
			Console.WriteLine("Invalid Arguments!");
			Console.WriteLine("Usage: Calculator 02 a + y | a - y | a * y | a : y [-v]");
			Environment.Exit(0);
		}
	}
}
