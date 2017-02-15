namespace Teste
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.txtCaminhoXML = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lstXML = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(173, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Colocar o nome e caminho do XML";
			// 
			// txtCaminhoXML
			// 
			this.txtCaminhoXML.Location = new System.Drawing.Point(3, 31);
			this.txtCaminhoXML.Name = "txtCaminhoXML";
			this.txtCaminhoXML.Size = new System.Drawing.Size(283, 20);
			this.txtCaminhoXML.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(283, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "Acessar e ler o arquivo xml";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lstXML
			// 
			this.lstXML.FormattingEnabled = true;
			this.lstXML.Location = new System.Drawing.Point(3, 94);
			this.lstXML.Name = "lstXML";
			this.lstXML.Size = new System.Drawing.Size(283, 173);
			this.lstXML.TabIndex = 3;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(291, 277);
			this.Controls.Add(this.lstXML);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtCaminhoXML);
			this.Controls.Add(this.label2);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCaminhoXML;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox lstXML;
	}
}

