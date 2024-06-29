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

namespace LogIn_Sys
{
	public partial class addstudent : Form
	{
		public addstudent()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This action will delete any unsaved data. Are you sure you want to exit?");
			this.Hide();
			form4 form4 = new form4();
			form4.ShowDialog();
			this.Close();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				string conn = "datasource=localhost;database=my library;port=3306;SSLMode=none;username=root;password =; ";
				string query = "INSERT INTO studentaccounts (`student name`, `enrollment no`, `department`, `student semester`, `student contact`, `student email`) VALUES ('"+textBox1.Text+ "','"+textBox2.Text+ "','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')";
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

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();

			textBox1.Text = "";
		}
	}
}
