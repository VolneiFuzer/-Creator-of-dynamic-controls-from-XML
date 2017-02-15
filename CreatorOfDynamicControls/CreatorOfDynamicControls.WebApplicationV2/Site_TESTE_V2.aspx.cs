using System;
using System.Web.UI;
using System.Xml;

namespace CreatorOfDynamicControls.WebApplicationV2
{
	public partial class Site_TESTE_V2 : Page
	{
		XmlDocument xmlDoc = new XmlDocument();
		const string FOLDER = @"C:\Users\Volnei\Documents\GIT\Creator-of-dynamic-controls-from-XML\CreatorOfDynamicControls\CreatorOfDynamicControls.WebApplicationV2\XML_TEST";

		protected void Page_Load(object sender, EventArgs e)
		{
			xmlDoc.Load(FOLDER + "\\XML_TEST_01.xml");
			CustomForm01.myXmlDoc = xmlDoc;
			//CustomForm01.toDrawControls(); // ???
		}
	}
}