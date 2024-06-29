using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogIn_Sys
{
	public partial class email_enter : Form
	{
		public email_enter()
		{
			InitializeComponent();
		}
		private void email_enter_Load(object sender, EventArgs e)
		{
			button1.Enabled = false;
		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			loginform1 form = new loginform1();
			form.Show();

			this.Hide();
		}

		private void emailText_Enter(object sender, EventArgs e)
		{
			if (emailText.Text == "Email")
			{
				emailText.Text = "";

				emailText.ForeColor = Color.Black;
			}

		}

		private void emailText_Leave(object sender, EventArgs e)
		{
			if (emailText.Text == "")
			{
				emailText.Text = "Email";

				emailText.ForeColor = Color.Gray;
			}
		}

		private void passwordText_Enter(object sender, EventArgs e)
		{
			if (passwordText.Text == "Password")
			{
				passwordText.Text = "";

				passwordText.ForeColor = Color.Black;
			}
		}
		private void passwordText_Leave(object sender, EventArgs e)
		{
			if (passwordText.Text == "")
			{
				passwordText.Text = "Password";

				passwordText.ForeColor = Color.Gray;
			}
		}

		private void firstText_Enter(object sender, EventArgs e)
		{
			if (firstText.Text == "First Name (optional)")
			{
				firstText.Text = "";

				firstText.ForeColor = Color.Black;
			}
		}
		private void firstText_Leave(object sender, EventArgs e)
		{
			if (firstText.Text == "")
			{
				firstText.Text = "First Name (optional)";

				firstText.ForeColor = Color.Gray;
			}
		}

		private void lastText_Enter(object sender, EventArgs e)
		{
			if (lastText.Text == "Last Name (optional)")
			{
				lastText.Text = "";

				lastText.ForeColor = Color.Black;
			}
		}
		private void lastText_Leave(object sender, EventArgs e)
		{
			if (lastText.Text == "")
			{
				lastText.Text = "Last Name (optional)";

				lastText.ForeColor = Color.Gray;
			}
		}

		private void monthCombo_Enter(object sender, EventArgs e)
		{
			if (monthCombo.Text == "Birthdate (MM)")
			{
				monthCombo.Text = "";

				monthCombo.ForeColor = Color.Black;
			}
		}

		private void monthCombo_Leave(object sender, EventArgs e)
		{
			if (monthCombo.Text == "")
			{
				monthCombo.Text = "Birthdate (MM)";

				monthCombo.ForeColor = Color.Gray;
			}
		}
		private void yearCombo_Enter(object sender, EventArgs e)
		{
			if (yearCombo.Text == "Birthdate (YYYY)")
			{
				yearCombo.Text = "";

				yearCombo.ForeColor = Color.Black;
			}
		}

		private void yearCombo_Leave(object sender, EventArgs e)
		{
			if (yearCombo.Text == "")
			{
				yearCombo.Text = "Birthdate (YYYY)";

				yearCombo.ForeColor = Color.Gray;
			}
		}

		private void countryCombo_Enter(object sender, EventArgs e)
		{
			if (countryCombo.Text == "Country/Region/Asia")
			{
				countryCombo.Text = "";

				countryCombo.ForeColor = Color.Black;
			}
		}

		private void countryCombo_Leave(object sender, EventArgs e)
		{
			if (countryCombo.Text == "")
			{
				countryCombo.Text = "Country/Region/Asia";

				countryCombo.ForeColor = Color.Gray;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				button1.Enabled = false;
			}
			else 
			{
				button1.Enabled = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string conn = "datasource=localhost;database=my library;port=3306;SSLMode=none;username=root;password =; ";
				string query = "INSERT INTO `account`(`email`, `password`, `first`, `last`, `month`, `year`, `country`) VALUES ('"+ emailText.Text + "','"+ passwordText.Text + "','" + firstText.Text + "','"+ lastText.Text + "','"+ monthCombo.Text + "','"+ yearCombo.Text + "','"+ countryCombo.Text + "')";
				MySqlConnection myConn = new MySqlConnection(conn);
				MySqlCommand cmd = new MySqlCommand(query, myConn);
				MySqlDataReader reader;
				myConn.Open();
				reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					MessageBox.Show("BANO SI JAKE");
				}
				else
				{
					MessageBox.Show("Established account");
				}
				myConn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			loginform1 form1 = new loginform1();
			form1.Show();
			this.Close();

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked) 
			{ 
				button1.Enabled = true;
			}
			else
			{
				button1.Enabled = false;
			}
		}
	}
}
