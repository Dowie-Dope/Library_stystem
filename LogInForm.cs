using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LogIn_Sys
{
	public partial class loginform1 : Form
	{
		public loginform1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string conn = "datasource=localhost;database=my library;port=3306;SSLMode=none;username=root;password =; ";
				string query = "select * from account where email = '" + textBox1.Text + "'&& password = '" + textBox2.Text + "' ";
				MySqlConnection myConn = new MySqlConnection(conn);
				MySqlCommand cmd = new MySqlCommand(query, myConn);
				MySqlDataReader reader;
				myConn.Open();
				reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					form4 calc = new form4();
					calc.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Username and Password are incorrect");
				}
				myConn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ForgetPassword form = new ForgetPassword();
			form.Show();

			this.Hide();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			email_enter form = new email_enter();
			form.Show();

			this.Hide();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
			
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
	}
}
