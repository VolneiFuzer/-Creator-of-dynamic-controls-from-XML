using System;

namespace CreatorOfDynamicControls.WebApplication_TEST
{
	public partial class Site_TEST : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				XMLReader RedEngine = new XMLReader();
				DropDownList1.DataSource = RedEngine.ListOfListBox();
				DropDownList1.DataBind();
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			XMLReader RedEngine = new XMLReader();
			TextBox1.Text = RedEngine.XMLContentDisplayer(DropDownList1.SelectedValue);
		}

		protected void Button2_Click(object sender, EventArgs e)
		{

		}

		protected void Button3_Click(object sender, EventArgs e)
		{
		}
	}
}