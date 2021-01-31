using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDisplayDate
{
	class Date
	{
		public int Month { get; set; }
		public int Day { get; set; }
		public int Year { get; set; }

		public Date(int month, int day, int year)
		{
			Month = month;
			Day = day;
			Year = year;
		}
		public void DisplayDay()
		{
			Console.WriteLine("{0:D2}/{1:D2}/{2:D4}", Month, Day, Year);
		}
	}
}
