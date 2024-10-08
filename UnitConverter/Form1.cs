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
			cbTypeConversion.Items.Insert(1, "Kilometer to Meter");
			cbTypeConversion.Items.Insert(2, "Meter to Yard");

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
					decimal result = insertedNumber / 1000;
					txtResult.Text = result.ToString();
				}
				else if (cbTypeConversion.SelectedIndex == 1)
				{
					decimal result = insertedNumber * 1000;
					txtResult.Text = result.ToString();
				}
				else if (cbTypeConversion.SelectedIndex == 2)
				{
					decimal result = insertedNumber * 1.0936m;
					txtResult.Text = result.ToString();
				}

			}

		}

		private void cbTypeConversion_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbTypeConversion.SelectedIndex == 0)
			{
				lblMeasurement.Text = "km";
			}
			else if (cbTypeConversion.SelectedIndex == 1)
			{
				lblMeasurement.Text = "m";
			}
			else if (cbTypeConversion.SelectedIndex == 2)
			{
				lblMeasurement.Text = "yd";
			}
		}
	}
}
