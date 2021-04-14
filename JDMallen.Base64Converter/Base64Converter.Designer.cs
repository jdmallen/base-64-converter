
namespace JDMallen.Base64Converter
{
	partial class Base64Converter
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.input = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.JsonPrettifyButton = new System.Windows.Forms.Button();
			this.ConvertButton = new System.Windows.Forms.Button();
			this.XmlPrettifyButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.input, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// input
			// 
			this.input.AcceptsReturn = true;
			this.input.AcceptsTab = true;
			this.input.AllowDrop = true;
			this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.input.HideSelection = false;
			this.input.Location = new System.Drawing.Point(3, 3);
			this.input.MaxLength = 1073741824;
			this.input.Multiline = true;
			this.input.Name = "input";
			this.input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.input.Size = new System.Drawing.Size(770, 390);
			this.input.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.JsonPrettifyButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ConvertButton, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.XmlPrettifyButton, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 396);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 30);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// JsonPrettifyButton
			// 
			this.JsonPrettifyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.JsonPrettifyButton.Location = new System.Drawing.Point(53, 3);
			this.JsonPrettifyButton.Name = "JsonPrettifyButton";
			this.JsonPrettifyButton.Size = new System.Drawing.Size(88, 23);
			this.JsonPrettifyButton.TabIndex = 4;
			this.JsonPrettifyButton.Text = "JSON Prettify";
			this.JsonPrettifyButton.UseVisualStyleBackColor = true;
			this.JsonPrettifyButton.Click += new System.EventHandler(this.JsonPrettifyButton_Click);
			// 
			// ConvertButton
			// 
			this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ConvertButton.Location = new System.Drawing.Point(698, 3);
			this.ConvertButton.Name = "ConvertButton";
			this.ConvertButton.Size = new System.Drawing.Size(75, 23);
			this.ConvertButton.TabIndex = 2;
			this.ConvertButton.Text = "Convert";
			this.ConvertButton.UseVisualStyleBackColor = true;
			this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
			// 
			// XmlPrettifyButton
			// 
			this.XmlPrettifyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.XmlPrettifyButton.Location = new System.Drawing.Point(250, 3);
			this.XmlPrettifyButton.Name = "XmlPrettifyButton";
			this.XmlPrettifyButton.Size = new System.Drawing.Size(82, 23);
			this.XmlPrettifyButton.TabIndex = 3;
			this.XmlPrettifyButton.Text = "XML Prettify";
			this.XmlPrettifyButton.UseVisualStyleBackColor = true;
			this.XmlPrettifyButton.Click += new System.EventHandler(this.XmlPrettifyButton_Click);
			// 
			// Base64Converter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Base64Converter";
			this.Text = "Base64Converter";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox input;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button ConvertButton;
		private System.Windows.Forms.Button XmlPrettifyButton;
		private System.Windows.Forms.Button JsonPrettifyButton;
	}
}