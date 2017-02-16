using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace CreatorOfDynamicControls.WebApplicationV2
{
	public partial class CustomForm : UserControl
	{
		public string myXmlDoc { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				Panel1.Controls.Clear();
				toDrawControls(myXmlDoc);
			}
			else
			{
				toDrawControls(myXmlDoc);
			}
		}

		public static void toDrawControls(string myXmlDoc)
		{
			List<WebControl> controls = new List<WebControl>();
			List<string> preControl = new List<string>();
			string controlType;

			XmlTextReader xmlToRead = new XmlTextReader(myXmlDoc);



		}

	}
}