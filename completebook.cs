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
	public partial class completebook : Form
	{
		public completebook()
		{
			InitializeComponent();
		}
		private void activebooks()
		{
			string conn = "datasource=localhost;database=my library;port=3306;SSLMode=none;username=root;password =; ";
			MySqlConnection con = new MySqlConnection(conn);
			MySqlCommand cmd = new MySqlCommand("select * from library", con);
			try
			{
				MySqlDataAdapter sda = new MySqlDataAdapter();
				sda.SelectCommand = cmd;
				DataTable dbdataset = new DataTable();
				sda.Fill(dbdataset);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dbdataset;
				dataGridView1.DataSource = bSource;
				sda.Update(dbdataset);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void returnedbooks()
		{
			string conn = "datasource=localhost;database=my library;port=3306;SSLMode=none;username=root;password =; ";
			MySqlConnection con = new MySqlConnection(conn);
			MySqlCommand cmd = new MySqlCommand("select * from publishbooks", con);
			try
			{
				MySqlDataAdapter sda = new MySqlDataAdapter();
				sda.SelectCommand = cmd;
				DataTable dbdataset = new DataTable();
				sda.Fill(dbdataset);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dbdataset;
				dataGridView2.DataSource = bSource;
				sda.Update(dbdataset);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void issuedbooks()
		{
			string conn = "datasource=localhost;database=my library;port=3306;SSLMode=none;username=root;password =; ";
			MySqlConnection con = new MySqlConnection(conn);
			MySqlCommand cmd = new MySqlCommand("select * from issued books", con);
			try
			{
				MySqlDataAdapter sda = new MySqlDataAdapter();
				sda.SelectCommand = cmd;
				DataTable dbdataset = new DataTable();
				sda.Fill(dbdataset);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dbdataset;
				dataGridView3.DataSource = bSource;
				sda.Update(dbdataset);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void activeaccounts()
		{
			string conn = "datasource=localhost;database=my library;port=3306;SSLMode=none;username=root;password =; ";
			MySqlConnection con = new MySqlConnection(conn);
			MySqlCommand cmd = new MySqlCommand("select * from studentaccounts", con);
			try
			{
				MySqlDataAdapter sda = new MySqlDataAdapter();
				sda.SelectCommand = cmd;
				DataTable dbdataset = new DataTable();
				sda.Fill(dbdataset);
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dbdataset;
				dataGridView4.DataSource = bSource;
				sda.Update(dbdataset);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

		private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void completebook_Load(object sender, EventArgs e)
		{
			activebooks();
			returnedbooks();
			issuedbooks();
			activeaccounts();

		}
	}
}
