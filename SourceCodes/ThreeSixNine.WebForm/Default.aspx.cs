using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThreeSixNineServices;

namespace ThreeSixNine.WebForm
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (this.IsPostBack)
				return;
		}

		protected void Submit_Click(object sender, EventArgs e)
		{
			// parsing string to integer
			var input = 0;
			int iresult;
			if (Int32.TryParse(
				this.InputNumber.Text.Trim(),
				out iresult))
				input = iresult;

			//	calling the service to get the result.
			var service = new ThreeSixNineService();
			var output = service.GetOutput(input);
			this.Result.Text = output;
		}
	}
}