using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace CreatorOfDynamicControls.WebApplicationV2
{
	public partial class CustomForm : UserControl
	{
		public XmlDocument myXmlDoc { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				Panel1.Controls.Clear();
				toDrawControls();				
			}
		}

		public static void toDrawControls()
		{
			throw new NotImplementedException();
		}

		protected static void loadXML()
		{
			throw new NotImplementedException();
		}
	}
}