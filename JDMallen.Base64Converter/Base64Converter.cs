using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JDMallen.Base64Converter
{
	public partial class Base64Converter : Form
	{
		public Base64Converter()
		{
			InitializeComponent();
		}

		private void ConvertButton_Click(object sender, EventArgs e)
		{
			var inputText = string.Join(Environment.NewLine, input.Lines);

			try
			{
				var bytes = Convert.FromBase64String(inputText);
				var result = Encoding.UTF8.GetString(bytes);
				input.Lines = new[] { result };
			}
			catch (Exception)
			{
				var bytes = Encoding.UTF8.GetBytes(inputText);
				var result = Convert.ToBase64String(bytes);
				input.Lines = new[] { result };
			}
		}

		private void JsonPrettifyButton_Click(object sender, EventArgs e)
		{

		}

		private void XmlPrettifyButton_Click(object sender, EventArgs e)
		{

		}
	}
}
