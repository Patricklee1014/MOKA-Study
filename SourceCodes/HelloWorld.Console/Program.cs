using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Services;

namespace HelloWorld.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			var service = new HelloWorldService();
			var output = service.GetOutput("Hello World Service");
			//var output = "Hello World Direct";

			System.Console.Write(output);
		}
	}
}
