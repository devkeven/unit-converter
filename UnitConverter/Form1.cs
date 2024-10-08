namespace UnitConverter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblMessage.Text = "";

			//string[] installs = new string[] { "Meter to Kilometer", "Meter to Yard", "Custom" };
			//cbTypeConversion.Items.AddRange(installs);

			cbTypeConversion.Items.Insert(0, "Meter to Kilometer");
			//cbTypeConversion.Items.Insert(1, "Meter to Yard");

			cbTypeConversion.SelectedIndex = 0;
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			lblMessage.Text = "";

			decimal insertedNumber;

			var valid = Decimal.TryParse(txtValue.Text, out insertedNumber);
			if (!valid)
			{
				lblMessage.Text = "Please insert a valid number!";
			}
			else
			{
				if (cbTypeConversion.SelectedIndex == 0)
				{
					//MessageBox.Show(cbTypeConversion.SelectedItem.ToString());
					decimal result = insertedNumber / 1000;
					txtResult.Text = result.ToString();
				}

			}

			
		}
	}
}
