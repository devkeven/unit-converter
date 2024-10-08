namespace UnitConverter
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			cbTypeConversion = new ComboBox();
			label1 = new Label();
			txtValue = new TextBox();
			txtResult = new TextBox();
			label2 = new Label();
			label3 = new Label();
			btnConvert = new Button();
			label4 = new Label();
			lblMessage = new Label();
			label5 = new Label();
			SuspendLayout();
			// 
			// cbTypeConversion
			// 
			cbTypeConversion.FormattingEnabled = true;
			cbTypeConversion.Location = new Point(223, 81);
			cbTypeConversion.Name = "cbTypeConversion";
			cbTypeConversion.Size = new Size(155, 23);
			cbTypeConversion.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(89, 84);
			label1.Name = "label1";
			label1.Size = new Size(128, 15);
			label1.TabIndex = 1;
			label1.Text = "Select conversion type:";
			// 
			// txtValue
			// 
			txtValue.Location = new Point(89, 140);
			txtValue.Name = "txtValue";
			txtValue.Size = new Size(128, 23);
			txtValue.TabIndex = 2;
			// 
			// txtResult
			// 
			txtResult.Enabled = false;
			txtResult.Location = new Point(250, 140);
			txtResult.Name = "txtResult";
			txtResult.Size = new Size(93, 23);
			txtResult.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(223, 143);
			label2.Name = "label2";
			label2.Size = new Size(21, 15);
			label2.TabIndex = 4;
			label2.Text = " = ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(89, 122);
			label3.Name = "label3";
			label3.Size = new Size(82, 15);
			label3.TabIndex = 5;
			label3.Text = "Insert a value: ";
			// 
			// btnConvert
			// 
			btnConvert.Location = new Point(89, 205);
			btnConvert.Name = "btnConvert";
			btnConvert.Size = new Size(289, 23);
			btnConvert.TabIndex = 6;
			btnConvert.Text = "Convert";
			btnConvert.UseVisualStyleBackColor = true;
			btnConvert.Click += btnConvert_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(340, 148);
			label4.Name = "label4";
			label4.Size = new Size(24, 15);
			label4.TabIndex = 7;
			label4.Text = "km";
			// 
			// lblMessage
			// 
			lblMessage.AutoSize = true;
			lblMessage.ForeColor = Color.Red;
			lblMessage.Location = new Point(89, 231);
			lblMessage.Name = "lblMessage";
			lblMessage.Size = new Size(26, 15);
			lblMessage.TabIndex = 8;
			lblMessage.Text = "test";
			// 
			// label5
			// 
			label5.BackColor = Color.Gold;
			label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label5.Location = new Point(12, 9);
			label5.Name = "label5";
			label5.Size = new Size(453, 45);
			label5.TabIndex = 9;
			label5.Text = "Unit Converter";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(477, 282);
			Controls.Add(label5);
			Controls.Add(lblMessage);
			Controls.Add(label4);
			Controls.Add(btnConvert);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(txtResult);
			Controls.Add(txtValue);
			Controls.Add(label1);
			Controls.Add(cbTypeConversion);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbTypeConversion;
		private Label label1;
		private TextBox txtValue;
		private TextBox txtResult;
		private Label label2;
		private Label label3;
		private Button btnConvert;
		private Label label4;
		private Label lblMessage;
		private Label label5;
	}
}
