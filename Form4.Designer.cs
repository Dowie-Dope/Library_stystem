namespace LogIn_Sys
{
	partial class form4
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.learnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lEARNERSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewStToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pUBLISHBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rETURNSBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fULLBOOKSDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Silver;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnersToolStripMenuItem,
            this.lEARNERSToolStripMenuItem1,
            this.pUBLISHBOOKSToolStripMenuItem,
            this.rETURNSBOOKSToolStripMenuItem,
            this.fULLBOOKSDETAILSToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 30);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// learnersToolStripMenuItem
			// 
			this.learnersToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.learnersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewBooksToolStripMenuItem});
			this.learnersToolStripMenuItem.Font = new System.Drawing.Font("Poppins ExtraBold", 9F, System.Drawing.FontStyle.Bold);
			this.learnersToolStripMenuItem.Image = global::LogIn_Sys.Properties.Resources.books_removebg_preview;
			this.learnersToolStripMenuItem.Name = "learnersToolStripMenuItem";
			this.learnersToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
			this.learnersToolStripMenuItem.Text = "BOOKS";
			this.learnersToolStripMenuItem.Click += new System.EventHandler(this.learnersToolStripMenuItem_Click);
			// 
			// addNewBookToolStripMenuItem
			// 
			this.addNewBookToolStripMenuItem.Image = global::LogIn_Sys.Properties.Resources.Blue_Brown_White_and_Black_Minimalist_Chocolate_Product_Presentation__6__removebg_preview;
			this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
			this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
			this.addNewBookToolStripMenuItem.Text = "Add New Book";
			this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
			// 
			// viewBooksToolStripMenuItem
			// 
			this.viewBooksToolStripMenuItem.Image = global::LogIn_Sys.Properties.Resources.view;
			this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
			this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
			this.viewBooksToolStripMenuItem.Text = "View Books";
			this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
			// 
			// lEARNERSToolStripMenuItem1
			// 
			this.lEARNERSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStToolStripMenuItem});
			this.lEARNERSToolStripMenuItem1.Font = new System.Drawing.Font("Poppins ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lEARNERSToolStripMenuItem1.Image = global::LogIn_Sys.Properties.Resources.student_icon_removebg_preview;
			this.lEARNERSToolStripMenuItem1.Name = "lEARNERSToolStripMenuItem1";
			this.lEARNERSToolStripMenuItem1.Size = new System.Drawing.Size(99, 26);
			this.lEARNERSToolStripMenuItem1.Text = "LEARNERS";
			this.lEARNERSToolStripMenuItem1.Click += new System.EventHandler(this.lEARNERSToolStripMenuItem1_Click);
			// 
			// addStudentToolStripMenuItem
			// 
			this.addStudentToolStripMenuItem.Image = global::LogIn_Sys.Properties.Resources.add_students;
			this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
			this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.addStudentToolStripMenuItem.Text = "Add Student";
			this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
			// 
			// viewStToolStripMenuItem
			// 
			this.viewStToolStripMenuItem.Image = global::LogIn_Sys.Properties.Resources.student;
			this.viewStToolStripMenuItem.Name = "viewStToolStripMenuItem";
			this.viewStToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.viewStToolStripMenuItem.Text = "View Student Information";
			this.viewStToolStripMenuItem.Click += new System.EventHandler(this.viewStToolStripMenuItem_Click);
			// 
			// pUBLISHBOOKSToolStripMenuItem
			// 
			this.pUBLISHBOOKSToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.pUBLISHBOOKSToolStripMenuItem.Font = new System.Drawing.Font("Poppins ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pUBLISHBOOKSToolStripMenuItem.Image = global::LogIn_Sys.Properties.Resources.puclish_books;
			this.pUBLISHBOOKSToolStripMenuItem.Name = "pUBLISHBOOKSToolStripMenuItem";
			this.pUBLISHBOOKSToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			this.pUBLISHBOOKSToolStripMenuItem.Text = "PUBLISH BOOKS";
			this.pUBLISHBOOKSToolStripMenuItem.Click += new System.EventHandler(this.pUBLISHBOOKSToolStripMenuItem_Click);
			// 
			// rETURNSBOOKSToolStripMenuItem
			// 
			this.rETURNSBOOKSToolStripMenuItem.Font = new System.Drawing.Font("Poppins ExtraBold", 9F, System.Drawing.FontStyle.Bold);
			this.rETURNSBOOKSToolStripMenuItem.Image = global::LogIn_Sys.Properties.Resources.return_books;
			this.rETURNSBOOKSToolStripMenuItem.Name = "rETURNSBOOKSToolStripMenuItem";
			this.rETURNSBOOKSToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
			this.rETURNSBOOKSToolStripMenuItem.Text = "RETURNS BOOKS";
			this.rETURNSBOOKSToolStripMenuItem.Click += new System.EventHandler(this.rETURNSBOOKSToolStripMenuItem_Click);
			// 
			// fULLBOOKSDETAILSToolStripMenuItem
			// 
			this.fULLBOOKSDETAILSToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.fULLBOOKSDETAILSToolStripMenuItem.Font = new System.Drawing.Font("Poppins ExtraBold", 9F, System.Drawing.FontStyle.Bold);
			this.fULLBOOKSDETAILSToolStripMenuItem.Image = global::LogIn_Sys.Properties.Resources.full_book_details;
			this.fULLBOOKSDETAILSToolStripMenuItem.Name = "fULLBOOKSDETAILSToolStripMenuItem";
			this.fULLBOOKSDETAILSToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
			this.fULLBOOKSDETAILSToolStripMenuItem.Text = "FULL BOOKS DETAILS";
			this.fULLBOOKSDETAILSToolStripMenuItem.Click += new System.EventHandler(this.fULLBOOKSDETAILSToolStripMenuItem_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::LogIn_Sys.Properties.Resources.exit;
			this.pictureBox2.Location = new System.Drawing.Point(774, 1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(26, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LogIn_Sys.Properties.Resources.Blue_Brown_White_and_Black_Minimalist_Chocolate_Product_Presentation__1_;
			this.pictureBox1.Location = new System.Drawing.Point(0, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(800, 419);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
			// 
			// form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "form4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form4";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem learnersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lEARNERSToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pUBLISHBOOKSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rETURNSBOOKSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fULLBOOKSDETAILSToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolStripMenuItem viewStToolStripMenuItem;
	}
}