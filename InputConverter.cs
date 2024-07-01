using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
	public class InputConverter
	{
		public double ConvertToNumber(string argInput)
		{
			double convertedNumber;

			if(!double.TryParse(argInput, out convertedNumber))
			{
				throw new ArgumentException("Expected a numeric Value");
				
			}
			return convertedNumber;
		}
	}
}
