using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace JDMallen.Base64Converter
{
	public partial class Base64Converter : Form
	{
		public Base64Converter()
		{
			InitializeComponent();
			_undoStack = new Stack<string>();
			_redoStack = new Stack<string>();
			UndoButton.Enabled = false;
			RedoButton.Enabled = false;
		}

		private readonly Stack<string> _undoStack;
		private readonly Stack<string> _redoStack;

		private string GetInput() => string.Join(Environment.NewLine, input.Lines);

		private void ConvertButton_Click(object sender, EventArgs e)
		{
			string inputText = GetInput();

			try
			{
				byte[] bytes = Convert.FromBase64String(inputText);
				string result = Encoding.UTF8.GetString(bytes);
				SetInput(result);
			}
			catch (Exception)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(inputText);
				string result = Convert.ToBase64String(bytes);
				SetInput(result);
			}
		}

		private void JsonPrettifyButton_Click(object sender, EventArgs e)
		{
			try
			{
				string prettyJson = ParseAndFormatJson(GetInput());
				SetInput(prettyJson);
			}
			catch
			{
				//
			}
		}

		private void XmlPrettifyButton_Click(object sender, EventArgs e)
		{
			try
			{
				string prettyXml = ParseAndFormatXml(GetInput());
				SetInput(prettyXml);
			}
			catch
			{
				//
			}
		}

		private static string ParseAndFormatXml(string str)
		{
			var result = string.Empty;

			MemoryStream mStream = new MemoryStream();
			XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
			XmlDocument document = new XmlDocument();

			try
			{
				// Load the XmlDocument with the XML.
				document.LoadXml(str);

				writer.Formatting = System.Xml.Formatting.Indented;

				// Write the XML into a formatting XmlTextWriter
				document.WriteContentTo(writer);
				writer.Flush();
				mStream.Flush();

				// Have to rewind the MemoryStream in order to read
				// its contents.
				mStream.Position = 0;

				// Read MemoryStream contents into a StreamReader.
				StreamReader sReader = new StreamReader(mStream);

				// Extract the text from the StreamReader.
				string formattedXml = sReader.ReadToEnd();

				result = formattedXml;
			}
			catch (XmlException)
			{
				// Handle the exception
			}
			finally
			{
				mStream.Close();
				writer.Close();
			}

			return result;
		}

		private static string ParseAndFormatJson(string str)
		{
			var result = string.Empty;

			try
			{
				object obj = JsonConvert.DeserializeObject(str);
				result = JsonConvert.SerializeObject(obj, Formatting.Indented);
			}
			catch
			{
				return result;
			}

			return result;
		}

		private void ConvertFileButton_Click(object sender, EventArgs e)
		{
			try
			{
				var openDialog = new OpenFileDialog();
				openDialog.ShowDialog();
				string filename = openDialog.FileName;

				byte[] bytes = File.ReadAllBytes(filename);
				string result = Convert.ToBase64String(bytes);
				SetInput(result);
			}
			catch
			{
				//
			}
		}

		private void UndoButton_Click(object sender, EventArgs e)
		{
			string inputText = GetInput();
			_redoStack.Push(inputText);
			input.Lines = new[] { _undoStack.Pop() };

			CheckButtons();
		}

		private void RedoButton_Click(object sender, EventArgs e)
		{
			SetInput(_redoStack.Pop(), false);
		}

		private void SetInput(string str, bool clearRedo = true)
		{
			string inputText = GetInput();
			_undoStack.Push(inputText);
			if (clearRedo)
			{
				_redoStack.Clear();
			}
			input.Lines = new[] { str };

			CheckButtons();
		}

		private void CheckButtons()
		{
			UndoButton.Enabled = _undoStack.Count > 0;
			RedoButton.Enabled = _redoStack.Count > 0;
		}
	}
}
