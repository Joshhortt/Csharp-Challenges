

//CHALLENGE 03: Create a class called Date that includes three pieces of information as automatic properties—a month (type int), 
//a day(type int) and a year (type int). Your class should have a constructor that initializes the three automatic properties 
//and assumes that the values provided are correct. Provide a method DisplayDate that displays the month, 
//day and year separated by forward slashes (/). Write a test app named DateTest that demonstrates class Date’s capabilities.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDisplayDate
{
	class Program
	{
		static void Main(string[] args)
		{
			Date date = new Date(31, 01, 2021);
			date.DisplayDay();

			Console.ReadLine();
		}
	}
}
