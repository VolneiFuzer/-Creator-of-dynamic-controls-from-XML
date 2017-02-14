using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreatorOfDynamicControls.WebApplication_TEST
{
	public partial class MeuFormo : System.Web.UI.UserControl
	{
		public string XML { get; set; }
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
		}

		public void Draw()
		{
			
		}
	}
}