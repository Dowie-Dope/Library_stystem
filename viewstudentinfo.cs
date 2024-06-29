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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogIn_Sys
{
	public partial class viewstudentinfo : Form
	{
		public viewstudentinfo()
		{
			InitializeComponent();
		}
		private void datagridview()
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
				dataSet1.DataSource = bSource;
				sda.Update(dbdataset);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try

			{

				if (e.RowIndex >= 0)

				{

					DataGridViewRow row = this.dataSet1.Rows[e.RowIndex];



					textBox2.Text = row.Cells["student name"].Value.ToString();

					textBox3.Text = row.Cells["enrollment no"].Value.ToString();

					textBox4.Text = row.Cells["department"].Value.ToString();

					textBox5.Text = row.Cells["student semester"].Value.ToString();

					textBox6.Text = row.Cells["student contact"].Value.ToString();

					textBox7.Text = row.Cells["student email"].Value.ToString();
				}

			}
			catch (Exception ex)

			{

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			datagridview();
		}

		private void publishbooks(object sender, EventArgs e)
		{
			datagridview();
		}
		private void iDelete()
		{
			foreach (DataGridViewRow item in this.dataSet1.SelectedRows)
			{
				dataSet1.Rows.RemoveAt(item.Index);
			}
		}
		private void button4_Click(object sender, EventArgs e)
		{
			iDelete();
		}
	}
}
