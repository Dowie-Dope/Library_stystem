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
	public partial class form4 : Form
	{
		public form4()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void learnersToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("You want to log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes) 
			{
				loginform1 form1 = new loginform1();
				form1.Show();
				this.Close();
				Application.Exit();
			}

		}

		private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Adding_Books adding_Books = new Adding_Books();
			adding_Books.Show();
			
		}

		private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			New_Books new_Books = new New_Books();
			new_Books.Show();
		}

		private void adadToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addstudent add_students = new addstudent();
			add_students.Show();
		}

		private void lEARNERSToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{

		}

		private void pUBLISHBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			publishbooks publish_books = new publishbooks();
			publish_books.Show();
		}

		private void rETURNSBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			returnbooks publish_books = new returnbooks();
			publish_books.Show();
		}

		private void viewStToolStripMenuItem_Click(object sender, EventArgs e)
		{
			viewstudentinfo student_info = new viewstudentinfo();
			student_info.Show();
		}

		private void fULLBOOKSDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			completebook complete_books = new completebook();
			complete_books.Show();
		}
	}
}
