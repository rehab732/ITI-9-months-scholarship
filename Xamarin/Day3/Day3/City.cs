using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
	public class City
	{
		public string CityName { get; set; }
		public string Date { get; set; }

		public override string ToString()
		{
			return CityName.ToString();
		}

	}
}
