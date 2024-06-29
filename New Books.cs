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
	public partial class New_Books : Form
	{
		public New_Books()
		{
			InitializeComponent();
		}

		private void datagridview()
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
		private void New_Books_Load(object sender, EventArgs e)
		{
			datagridview();
		}

		private void button4_Click(object sender, EventArgs e)
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

					DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];



					text_Box2.Text = row.Cells["Name"].Value.ToString();

					textBox3.Text = row.Cells["Author"].Value.ToString();

					textBox4.Text = row.Cells["Publish"].Value.ToString();

					textBox5.Text = row.Cells["Date"].Value.ToString();

					textBox6.Text = row.Cells["Quantity"].Value.ToString();

					textBox6.Text = row.Cells["Price"].Value.ToString();
				}

			}
			catch (Exception ex)

			{

			}
		}
		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			String Name = text_Box2.Text;
			String Author = textBox3.Text;
			String Publish = textBox4.Text;
			String Date = textBox5.Text;
			String Quantity = textBox5.Text;
			String Price = textBox6.Text;

			MySqlDataAdapter sda = new MySqlDataAdapter();
			DataTable dbdataset = new DataTable();
			sda.Fill(dbdataset);
			BindingSource bSource = new BindingSource();
			bSource.DataSource = dbdataset;
			dataGridView1.DataSource = bSource;
			sda.Update(dbdataset);
		}
		private void iDelete()
		{
			foreach (DataGridViewRow item in this.dataGridView1.SelectedRows) 
			{ 
				dataGridView1.Rows.RemoveAt(item.Index);
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			iDelete();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			datagridview();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void text_Box2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
