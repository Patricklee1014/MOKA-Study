using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
	public class HelloWorldService
	{
		private string _output;

		public string GetOutput(string input)
		{
			string value = "Your input is: " + input + "!";
			return value;
		}
	}
}
