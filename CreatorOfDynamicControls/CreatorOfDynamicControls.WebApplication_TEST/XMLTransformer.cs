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
			List<string> preControl = new List<string>();
			string controlType;

			string xmlFolder = FOLDER + "\\" + selectXML;

			XmlTextReader xmlToRead = new XmlTextReader(xmlFolder);

			while (xmlToRead.Read())
			{
				switch (xmlToRead.NodeType)
				{
					case XmlNodeType.Element:

						controlType = xmlToRead.Name;

						if (isImplementedControl(controlType))
						{
							if (xmlToRead.HasAttributes)
							{
								while (xmlToRead.MoveToNextAttribute())
								{
									preControl.Add(xmlToRead.Name);
									preControl.Add(xmlToRead.Value);
								}
							}

							TransformToControl(controlType, preControl);

							if (createdControl != null)
							{
								controls.Add(createdControl);
							}
						}
						break;
				}
			}

			return controls;
		}

		public WebControl TransformToControl(string tipeControl, List<string> attributesList)
		{
			switch (tipeControl)
			{
				case "TextBox": createdControl = criateTextBox(attributesList); break;
				case "Button": createdControl = criateButton(attributesList); break;
				case "LinkButton": createdControl = criateLinkButton(attributesList); break;
				case "ImageButton": createdControl = criateImageButton(attributesList); break;
				case "DropDownList": createdControl = criateDropDownList(attributesList); break;
				case "ListBox": createdControl = criateListBox(attributesList); break;
				case "Image": createdControl = criateImage(attributesList); break;
				default: createdControl = null; break;
			}

			return createdControl;
		}

		public bool isImplementedControl(string preControlName)
		{
			bool check = false;

			switch (preControlName)
			{
				case "TextBox": check= true; break;
				case "Button": check = true; break;
				case "LinkButton": check = true; break;
				case "ImageButton": check = true; break;
				case "DropDownList": check = true; break;
				case "ListBox": check = true; break;
				case "Image": check = true; break;
				default: break;
			}

			return check;
		}

		private TextBox criateTextBox(List<string> attributesList)
		{
			TextBox tb = new TextBox();
			for (int i = 0; i < attributesList.Count - 1; i++)
			{
				switch (attributesList[i])
				{
					case "name": tb.ID = attributesList[i + 1]; i++; break;
					case "value": tb.Text = attributesList[i + 1]; i++; break;
					default: tb.Attributes.Add(attributesList[i], attributesList[i + 1]); i++; break;
				}
			}
			return tb;
		}

		private Button criateButton(List<string> attributesList)
		{
			Button bt = new Button();
			for (int i = 0; i < attributesList.Count - 1; i++)
			{
				switch (attributesList[i])
				{
					case "name": bt.ID = attributesList[i + 1]; i++; break;
					case "value": bt.Text = attributesList[i + 1]; i++; break;
					default: bt.Attributes.Add(attributesList[i], attributesList[i + 1]); i++; break;
				}
			}
			return bt;
		}

		private LinkButton criateLinkButton(List<string> attributesList)
		{
			LinkButton lbt = new LinkButton();
			for (int i = 0; i < attributesList.Count - 1; i++)
			{
				switch (attributesList[i])
				{
					case "name": lbt.ID = attributesList[i + 1]; i++; break;
					case "value": lbt.Text = attributesList[i + 1]; i++; break;
					default: lbt.Attributes.Add(attributesList[i], attributesList[i + 1]); i++; break;
				}
			}
			return lbt;
		}

		private ImageButton criateImageButton(List<string> attributesList)
		{
			ImageButton imbt = new ImageButton();
			for (int i = 0; i < attributesList.Count - 1; i++)
			{
				switch (attributesList[i])
				{
					case "name": imbt.ID = attributesList[i + 1]; i++; break;
					case "ImageUrl": imbt.ImageUrl = attributesList[i + 1]; i++; break;
					default: imbt.Attributes.Add(attributesList[i], attributesList[i + 1]); i++; break;
				}
			}
			return imbt;
		}

		private DropDownList criateDropDownList(List<string> attributesList)
		{
			DropDownList ddl = new DropDownList();
			for (int i = 0; i < attributesList.Count - 1; i++)
			{
				switch (attributesList[i])
				{
					case "name": ddl.ID = attributesList[i + 1]; i++; break;
					default: ddl.Attributes.Add(attributesList[i], attributesList[i + 1]); i++; break;
				}
			}
			return ddl;
		}

		private ListBox criateListBox(List<string> attributesList)
		{
			ListBox lbx = new ListBox();
			for (int i = 0; i < attributesList.Count - 1; i++)
			{
				switch (attributesList[i])
				{
					case "name": lbx.ID = attributesList[i + 1]; i++; break;
					default: lbx.Attributes.Add(attributesList[i], attributesList[i + 1]); i++; break;
				}
			}
			return lbx;
		}

		private Image criateImage(List<string> attributesList)
		{
			Image img = new Image();
			for (int i = 0; i < attributesList.Count - 1; i++)
			{
				switch (attributesList[i])
				{
					case "name": img.ID = attributesList[i + 1]; i++; break;
					case "ImageUrl": img.ImageUrl = attributesList[i + 1]; i++; break;
					default: img.Attributes.Add(attributesList[i], attributesList[i + 1]); i++; break;
				}
			}
			return img;
		}
	}
}