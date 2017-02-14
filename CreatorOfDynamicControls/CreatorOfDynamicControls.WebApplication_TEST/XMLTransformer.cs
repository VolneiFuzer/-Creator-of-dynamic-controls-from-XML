using System.Collections.Generic;
using System.Web.UI.WebControls;


namespace CreatorOfDynamicControls.WebApplication_TEST
{
	public class XMLTransformer
	{
		public List<WebControl> ListOfControls()
		{
			List<WebControl> controls = new List<WebControl>();

			TextBox txtbox = new TextBox();
			Button bt = new Button();
			txtbox.ID = "txtbox01";
			txtbox.Text = "testeTXTBOX";
			bt.ID = "bt01";
			bt.Text = "BTTEXTE";
			controls.Add(txtbox);
			controls.Add(bt);
	
			return controls;
		}

		public void TransformToControl()
		{
		}
	}
}