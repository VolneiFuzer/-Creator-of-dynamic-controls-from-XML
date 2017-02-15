using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Xml;

namespace CreatorOfDynamicControls.WebApplication_TEST
{
	public class XMLTransformer
	{
		const string FOLDER = @"C:\Users\Volnei\Documents\GIT\Creator-of-dynamic-controls-from-XML\CreatorOfDynamicControls\CreatorOfDynamicControls.WebApplication_TEST\XML_TEST";
		private WebControl createdControl;

		public List<WebControl> ListOfControls(string selectXML)
		{
			List<WebControl> controls = new List<WebControl>();

			string xmlFolder = FOLDER + "\\" + selectXML;

			XmlTextReader xmlToRead = new XmlTextReader(xmlFolder);

			while (xmlToRead.Read())
			{
				switch (xmlToRead.NodeType)
				{
					case XmlNodeType.Element:

						TransformToControl(xmlToRead.Name);

						if (xmlToRead.HasAttributes)
						{
							while (xmlToRead.MoveToNextAttribute())
							{
								createdControl.Attributes.Add(xmlToRead.Name, xmlToRead.Value);
							}
						}
						if (createdControl != null)
						{
							controls.Add(createdControl);
						}
						break;
				}
			}

			return controls;
		}

		public WebControl TransformToControl(string receivedPreControl)
		{
			switch (receivedPreControl)
			{
				case "TextBox": createdControl = criateTextBox(); break;
				case "Button": createdControl = criateButton(); break;
			}

			return createdControl;
		}

		private TextBox criateTextBox()
		{
			TextBox tb = new TextBox();
			return tb;
		}

		private Button criateButton()
		{
			Button bt = new Button();
			return bt;
		}
	}
}