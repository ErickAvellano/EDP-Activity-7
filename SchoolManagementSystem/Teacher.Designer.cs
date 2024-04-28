namespace SchoolManagementSystem
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminbtn = new System.Windows.Forms.Button();
            this.classroombtn = new System.Windows.Forms.Button();
            this.coursebtn = new System.Windows.Forms.Button();
            this.teacherbtn = new System.Windows.Forms.Button();
            this.studentbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatebtn = new System.Windows.Forms.Button();
            this.Addnewbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.teacherID = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printbtn1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.printbtn1);
            this.panel1.Controls.Add(this.adminbtn);
            this.panel1.Controls.Add(this.classroombtn);
            this.panel1.Controls.Add(this.coursebtn);
            this.panel1.Controls.Add(this.teacherbtn);
            this.panel1.Controls.Add(this.studentbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 430);
            this.panel1.TabIndex = 2;
            // 
            // adminbtn
            // 
            this.adminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminbtn.Location = new System.Drawing.Point(38, 307);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(165, 40);
            this.adminbtn.TabIndex = 14;
            this.adminbtn.Text = "Admin";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // classroombtn
            // 
            this.classroombtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.classroombtn.Location = new System.Drawing.Point(38, 192);
            this.classroombtn.Name = "classroombtn";
            this.classroombtn.Size = new System.Drawing.Size(165, 40);
            this.classroombtn.TabIndex = 8;
            this.classroombtn.Text = "Classroom";
            this.classroombtn.UseVisualStyleBackColor = true;
            this.classroombtn.Click += new System.EventHandler(this.classroombtn_Click);
            // 
            // coursebtn
            // 
            this.coursebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.coursebtn.Location = new System.Drawing.Point(38, 249);
            this.coursebtn.Name = "coursebtn";
            this.coursebtn.Size = new System.Drawing.Size(165, 40);
            this.coursebtn.TabIndex = 7;
            this.coursebtn.Text = "Course";
            this.coursebtn.UseVisualStyleBackColor = true;
            this.coursebtn.Click += new System.EventHandler(this.coursebtn_Click);
            // 
            // teacherbtn
            // 
            this.teacherbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.teacherbtn.Location = new System.Drawing.Point(38, 136);
            this.teacherbtn.Name = "teacherbtn";
            this.teacherbtn.Size = new System.Drawing.Size(165, 40);
            this.teacherbtn.TabIndex = 6;
            this.teacherbtn.Text = "Teacher";
            this.teacherbtn.UseVisualStyleBackColor = true;
            this.teacherbtn.Click += new System.EventHandler(this.teacherbtn_Click);
            // 
            // studentbtn
            // 
            this.studentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.studentbtn.Location = new System.Drawing.Point(38, 81);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Size = new System.Drawing.Size(165, 40);
            this.studentbtn.TabIndex = 5;
            this.studentbtn.Text = "Student";
            this.studentbtn.UseVisualStyleBackColor = true;
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(678, 145);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.updatebtn.Size = new System.Drawing.Size(98, 32);
            this.updatebtn.TabIndex = 13;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // Addnewbtn
            // 
            this.Addnewbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.Addnewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Addnewbtn.ForeColor = System.Drawing.Color.White;
            this.Addnewbtn.Location = new System.Drawing.Point(519, 145);
            this.Addnewbtn.Name = "Addnewbtn";
            this.Addnewbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Addnewbtn.Size = new System.Drawing.Size(142, 32);
            this.Addnewbtn.TabIndex = 12;
            this.Addnewbtn.Text = "Add New Teacher";
            this.Addnewbtn.UseVisualStyleBackColor = false;
            this.Addnewbtn.Click += new System.EventHandler(this.Addnewbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 255);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(262, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Teacher ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // teacherID
            // 
            this.teacherID.Location = new System.Drawing.Point(265, 93);
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(63, 20);
            this.teacherID.TabIndex = 32;
            this.teacherID.TextChanged += new System.EventHandler(this.teacherID_TextChanged);
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(621, 93);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(111, 20);
            this.subject.TabIndex = 31;
            this.subject.TextChanged += new System.EventHandler(this.subject_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(248, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Add | Update Teacher";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(618, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Subject";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(481, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(484, 93);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(111, 20);
            this.Lastname.TabIndex = 26;
            this.Lastname.TextChanged += new System.EventHandler(this.Lastname_TextChanged);
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(348, 93);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(111, 20);
            this.Firstname.TabIndex = 25;
            this.Firstname.TextChanged += new System.EventHandler(this.Firstname_TextChanged);
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status.Location = new System.Drawing.Point(265, 145);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(103, 21);
            this.status.TabIndex = 34;
            this.status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(262, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Teaching Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // printbtn1
            // 
            this.printbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.printbtn1.Location = new System.Drawing.Point(38, 362);
            this.printbtn1.Name = "printbtn1";
            this.printbtn1.Size = new System.Drawing.Size(165, 40);
            this.printbtn1.TabIndex = 15;
            this.printbtn1.Text = "Print";
            this.printbtn1.UseVisualStyleBackColor = true;
            this.printbtn1.Click += new System.EventHandler(this.printbtn1_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.nopparuj_plamjaroenphon_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.teacherID);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.Addnewbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teacher";
            this.Text = "School Management System";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button classroombtn;
        private System.Windows.Forms.Button coursebtn;
        private System.Windows.Forms.Button teacherbtn;
        private System.Windows.Forms.Button studentbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Addnewbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teacherID;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button printbtn1;
    }
}