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
	public partial class publishbooks : Form
	{
		public publishbooks()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This action will delete any unsaved data. Are you sure you want to exit?");
			this.Hide();
			form4 form4 = new form4();
			form4.ShowDialog();
			this.Close();
		}

		private void publishbooks_Load(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				string conn = "datasource=localhost;database=my library;port=3306;SSLMode=none;username=root;password =; ";
				string query = "INSERT INTO `publishbooks`( `Student Name`, `Department`, `Student Semester`, `Contact`, `Email`) VALUES ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
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
					MessageBox.Show("Publish Books, See it at Returned Books.");
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

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
