using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreatorOfDynamicControls.WebApplication_TEST
{
	public partial class Site_TEST : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			MeuFormo.XML = "dkwjlk";
			MeuFormo.Draw();
			//meuform.Load(xml);
			//string validade = HiddenField1.Value;

			//if (!IsPostBack)
			//{
			//	XMLReader RedEngine = new XMLReader();
			//	DropDownList1.DataSource = RedEngine.ListOfListBox();
			//	DropDownList1.DataBind();
			//}
			//else if (validade == "true")
			//{
			//	Panel1.Controls.Clear();

			//	XMLTransformer transf = new XMLTransformer();
			//	foreach (WebControl w in transf.ListOfControls())
			//	{
			//		Panel1.Controls.Add(w);
			//		Panel1.Controls.Add(new LiteralControl("<br />"));
			//	}
			//}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			XMLReader RedEngine = new XMLReader();
			TextBox1.Text = RedEngine.XMLContentDisplayer(DropDownList1.SelectedValue);
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			if (HiddenField1.Value == "true")
			{
				Panel1.Controls.Clear();
			}
			else
			{
				HiddenField1.Value = "true";
			}

			XMLTransformer transf = new XMLTransformer();
			foreach (WebControl w in transf.ListOfControls())
			{
				Panel1.Controls.Add(w);
				Panel1.Controls.Add(new LiteralControl("<br />"));
			}
		}

		protected void Button3_Click(object sender, EventArgs e)
		{
			
		}
	}
}