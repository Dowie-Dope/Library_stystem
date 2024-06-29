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
	public partial class returnbooks : Form
	{
		public returnbooks()
		{
			InitializeComponent();
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
					dataGridView1.DataSource = bSource;
					sda.Update(dbdataset);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This action will delete any unsaved data. Are you sure you want to exit?");
			this.Hide();
			form4 form4 = new form4();
			form4.ShowDialog();
			this.Close();
		}

		private void returnbooks_Load(object sender, EventArgs e)
		{
			returnedbooks();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try

			{

				if (e.RowIndex >= 0)

				{

					DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];



					textBox1.Text = row.Cells["Books Name"].Value.ToString();

					textBox3.Text = row.Cells["Book Issue Date"].Value.ToString();

					dateTimePicker1.Text = row.Cells["Book Return Date"].Value.ToString();

				}

			}
			catch (Exception ex)

			{

			}
		}
	}
}
