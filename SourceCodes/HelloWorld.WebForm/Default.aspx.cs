using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HelloWorld.Services;

namespace HelloWorld.WebForm
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var service = new HelloWorldService();
			var output = service.GetOutput("Hello World WebForm");
			this.helloWorld.Text = output;
		}

		protected void Submit_Click(object sender, EventArgs e)
		{
			this.Result.Text = this.Username.Text + ":::" + this.Password.Text;
		}
	}
}