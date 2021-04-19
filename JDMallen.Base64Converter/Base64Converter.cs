using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JDMallen.Base64Converter
{
	public partial class Base64Converter : Form
	{
		public Base64Converter()
		{
			InitializeComponent();
		}

		private string GetInput() => string.Join(Environment.NewLine, input.Lines);

		private void ConvertButton_Click(object sender, EventArgs e)
		{
			var inputText = GetInput();

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
			try
			{
				input.Lines = new[] { ParseAndFormatJson(GetInput()) };
			}
			catch
			{
				//
			}
		}

		private void XmlPrettifyButton_Click(object sender, EventArgs e)
		{

		}

		private string ParseAndFormatJson(string str)
		{
			var result = string.Empty;

			try
			{
				var obj = JsonConvert.DeserializeObject(str);
				result = JsonConvert.SerializeObject(obj, Formatting.Indented);
			}
			catch (Exception e)
			{
				return result;
			}

			return result;
		}
	}
}
