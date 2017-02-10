using System.IO;
using System.Collections;
using System.Web.UI.WebControls;

namespace CreatorOfDynamicControls.WebApplication_TEST
{
	public class ReadXML
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

		public void ReadXMLMetod()
		{

		}
	}
}