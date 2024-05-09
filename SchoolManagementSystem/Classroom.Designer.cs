namespace SchoolManagementSystem
{
    partial class Classroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classroom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminbtn = new System.Windows.Forms.Button();
            this.classroombtn = new System.Windows.Forms.Button();
            this.coursebtn = new System.Windows.Forms.Button();
            this.teacherbtn = new System.Windows.Forms.Button();
            this.studentbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatebtn = new System.Windows.Forms.Button();
            this.Addnewbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.classroomID = new System.Windows.Forms.TextBox();
            this.schedule = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherID = new System.Windows.Forms.ComboBox();
            this.courseID = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // adminbtn
            // 
            this.adminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminbtn.Location = new System.Drawing.Point(36, 341);
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
            this.classroombtn.Location = new System.Drawing.Point(36, 227);
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
            this.coursebtn.Location = new System.Drawing.Point(36, 284);
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
            this.teacherbtn.Location = new System.Drawing.Point(36, 171);
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
            this.studentbtn.Location = new System.Drawing.Point(36, 116);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Size = new System.Drawing.Size(165, 40);
            this.studentbtn.TabIndex = 5;
            this.studentbtn.Text = "Student";
            this.studentbtn.UseVisualStyleBackColor = true;
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
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
            this.Addnewbtn.Text = "Add New Classroom";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(260, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Room Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(260, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Classroom ID";
            // 
            // classroomID
            // 
            this.classroomID.Location = new System.Drawing.Point(263, 91);
            this.classroomID.Name = "classroomID";
            this.classroomID.Size = new System.Drawing.Size(63, 20);
            this.classroomID.TabIndex = 43;
            this.classroomID.TextChanged += new System.EventHandler(this.classroomID_TextChanged);
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(619, 91);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(111, 20);
            this.schedule.TabIndex = 42;
            this.schedule.TextChanged += new System.EventHandler(this.schedule_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(246, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Add | Update Classroom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(616, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(479, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "CourseID";
            // 
            // roomNum
            // 
            this.roomNum.Location = new System.Drawing.Point(263, 143);
            this.roomNum.Name = "roomNum";
            this.roomNum.Size = new System.Drawing.Size(111, 20);
            this.roomNum.TabIndex = 47;
            this.roomNum.TextChanged += new System.EventHandler(this.roomNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "TeacherID";
            // 
            // teacherID
            // 
            this.teacherID.FormattingEnabled = true;
            this.teacherID.Location = new System.Drawing.Point(347, 91);
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(109, 21);
            this.teacherID.TabIndex = 50;
            // 
            // courseID
            // 
            this.courseID.FormattingEnabled = true;
            this.courseID.Location = new System.Drawing.Point(482, 91);
            this.courseID.Name = "courseID";
            this.courseID.Size = new System.Drawing.Size(109, 21);
            this.courseID.TabIndex = 51;
            this.courseID.SelectedIndexChanged += new System.EventHandler(this.courseID_SelectedIndexChanged);
            // 
            // Classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.nopparuj_plamjaroenphon_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseID);
            this.Controls.Add(this.teacherID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.classroomID);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.Addnewbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Classroom";
            this.Text = "School Management System";
            this.Load += new System.EventHandler(this.Classroom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button classroombtn;
        private System.Windows.Forms.Button coursebtn;
        private System.Windows.Forms.Button teacherbtn;
        private System.Windows.Forms.Button studentbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Addnewbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox classroomID;
        private System.Windows.Forms.TextBox schedule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacherID;
        private System.Windows.Forms.ComboBox courseID;
    }
}