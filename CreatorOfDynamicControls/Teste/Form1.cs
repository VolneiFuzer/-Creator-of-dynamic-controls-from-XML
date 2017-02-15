using System;
using System.Collections;
using System.Windows.Forms;
using System.Xml;

namespace Teste
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			XmlTextReader reader = new XmlTextReader(txtCaminhoXML.Text);
			ArrayList elementos = new ArrayList();

			while ((reader.Read()))
			{
				switch (reader.NodeType)
				{
					case XmlNodeType.Element:
						elementos.Add(reader.Name);
						//Se existirem atributos
						if (reader.HasAttributes)
						{
							while (reader.MoveToNextAttribute())
							{
								//Pega o valor do atributo.
								elementos.Add(reader.Name);
								elementos.Add(reader.Value);
							}
						}
						break;
					case XmlNodeType.Text:
						//Incluir o texto do elemento no ArrayList
						elementos.Add(reader.Value);
						break;
				}
			}
			foreach (var num in elementos)
			{
				lstXML.Items.Add(num);
			}
		}
	}
}
