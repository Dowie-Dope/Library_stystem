using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LogIn_Sys
{
	public partial class Adding_Books : Form
	{
		public Adding_Books()
		{
			InitializeComponent();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string conn = "datasource=localhost;database=my library;port=3306;SSLMode=none;username=root;password =; ";
				string query = "INSERT INTO `library`( `Name`, `Author`, `Publish`, `Date`, `Quantity`, `Price`) VALUES ('"+textBox1.Text+"','"+ textBox2.Text + "','"+ textBox3.Text +"','"+ dateTimePicker1.Value + "','"+ textBox4.Text +"','"+ textBox5.Text+"')";
				MySqlConnection myConn = new MySqlConnection(conn);
				MySqlCommand cmd = new MySqlCommand(query, myConn);
				MySqlDataReader reader;
				myConn.Open();
				reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					MessageBox.Show(" ");
				}
				else
				{
					MessageBox.Show("Done Adding");
					form4 form = new form4();
					form.ShowDialog();
				}
				myConn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This action will delete any unsaved data. Are you sure you want to exit?", "Confirmation");
			
				form4 form4 = new form4();
				form4.Show();
				this.Close();
				this.Hide();
			

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
