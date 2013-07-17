using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThreeSixNineServices
{
	public class ThreeSixNineService
	{
		public string GetOutput(int maxNumber)
		{
			var pattern = "(3|6|9)";
			var output = String.Empty;
			for (var i = 1; i <= maxNumber; i++)
			{
				var matches = Regex.Matches(Convert.ToString(i),
				                            pattern,
				                            RegexOptions.IgnoreCase);
				if (matches.Count == 0)
				{
					output += Convert.ToString(i) + " ";
				}
				else
				{
					for (var j = 0; j < matches.Count; j++)
					{
						output += "X";
					}
					output += " ";
				}
			}
			return output.Trim();
		}
	}
}
