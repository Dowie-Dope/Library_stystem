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
	public partial class ForgetPassword : Form
	{
		public ForgetPassword()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void EmailText_Enter(object sender, EventArgs e)
		{
			if (emailSign.Text == "Email")
			{
				emailSign.Text = "";

				emailSign.ForeColor = Color.Red;
			}
		}
		private void EmailText_Leave(object sender, EventArgs e)
		{
			if (emailSign.Text == "")
			{
				emailSign.Text = "Email";

				emailSign.ForeColor = Color.Silver;
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			loginform1 form = new loginform1();
			form.Show();

			this.Hide();
		}

		private void emailSign_TextChanged(object sender, EventArgs e)
		{


		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(emailSign.Text))
			{
				MessageBox.Show("Put your email");
			}
			else
			{
				
				loginform1 form1 = new loginform1();
				form1.Show();
				this.Hide(); 
			}

		}

		private void emailSign_Validating(object sender, CancelEventArgs e)
		{
			
		}
	}
}

