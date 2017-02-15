using System.IO;
using System.Collections;
using System.Xml;
using System.Text;

namespace CreatorOfDynamicControls.WebApplication_TEST
{
	public class XMLReader
	{
		const string FOLDER = @"C:\Users\Volnei\Documents\GIT\Creator-of-dynamic-controls-from-XML\CreatorOfDynamicControls\CreatorOfDynamicControls.WebApplication_TEST\XML_TEST";

		public ArrayList ListOfListBox()
		{
			ArrayList vetor = new ArrayList();
			try
			{
				string[] files = Directory.GetFiles(FOLDER, "*");

				foreach (string file in files)
				{
					FileInfo fileInfo = new FileInfo(file);
					vetor.Add(fileInfo.Name);
				}
				
			}
			catch (System.Exception)
			{

				throw;
			}
			return vetor;
		}

		public string XMLContentDisplayer(string selectXML)
		{
			StringBuilder textOfXml = new StringBuilder();

			try
			{
				string xmlFolder = FOLDER + "\\" + selectXML;
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(xmlFolder);

				using (StringWriter stringWriter = new StringWriter(textOfXml))
				{
					using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
					{
						xmlTextWriter.Formatting = Formatting.Indented;
						xmlDoc.WriteTo(xmlTextWriter);
					}
				}
			}
			catch (System.Exception)
			{
				throw;
			}
			return textOfXml.ToString();
		}
	}
}