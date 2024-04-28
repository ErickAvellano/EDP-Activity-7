using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.AxHost;


namespace SchoolManagementSystem
{
    public partial class Teacher : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        private Management managementForm;



        public Teacher()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadDataIntoDataGridView();
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;


        }
        private void InitializeDatabase()
        {
            server = "localhost";
            database = "schoolmanagement";
            uid = "root";
            pass = "erick";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={pass};";
            connection = new MySqlConnection(connectionString);
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM teachers";
                command = new MySqlCommand(query, connection);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve data from the selected row
                int teacherid = Convert.ToInt32(selectedRow.Cells["TeacherID"].Value);
                string firstName = Convert.ToString(selectedRow.Cells["FirstName"].Value);
                string lastName = Convert.ToString(selectedRow.Cells["LastName"].Value);
                string subs = Convert.ToString(selectedRow.Cells["SubjectTaught"].Value);
                string stat = Convert.ToString(selectedRow.Cells["Teachingstatus"].Value);


                // Populate text boxes and controls with the selected row data
                teacherID.Text = teacherid.ToString();
                Firstname.Text = firstName;
                Lastname.Text = lastName;
                subject.Text = subs;

                if (stat == "Active")
                {
                    status.SelectedItem = "Active";
                }
                else if (stat == "Inactive")
                {
                    status.SelectedItem = "Inactive";
                }
            }
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Check if the row index is valid
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the teaching status value from the cell in the Teachingstatus column
                string teachingStatus = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Teachingstatus"].Value);

                // Set the background color based on the teaching status value
                if (teachingStatus == "Active")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (teachingStatus == "Inactive")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                // Add additional conditions for other teaching status values if needed
            }
        }
        private void AddNewTeacher(string firstName, string lastName, string subs, string stat)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO teachers (FirstName, LastName, SubjectTaught, Teachingstatus) VALUES (@firstName, @lastName, @subs, @stat)";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@subs", subs);
                command.Parameters.AddWithValue("@stat", stat);



                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Teacher added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add teacher!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void UpdateTeacher(int teacherid, string firstName, string lastName, string subs, string stat)
        {
            try
            {
                connection.Open();
                // Update the teacher record in the database
                string query = "UPDATE teachers SET FirstName = @firstName, LastName = @lastName, SubjectTaught = @subs, Teachingstatus = @stat WHERE TeacherID = @teacherid";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@subs", subs);
                command.Parameters.AddWithValue("@stat", stat);
                command.Parameters.AddWithValue("@teacherid", teacherid);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Teacher information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update teacher information!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating teacher information: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void Teacher_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var student = new Management();
            student.Show(); 
        }

        private void teacherbtn_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void classroombtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var classr = new Classroom();
            classr.Show();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var course = new Course();
            course.Show();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var admin = new Admin();
            admin.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Addnewbtn_Click(object sender, EventArgs e)
        {
            string firstName = Firstname.Text;
            string lastName = Lastname.Text;
            string subs = subject.Text;
            string stat = status.SelectedItem.ToString();
            AddNewTeacher(firstName, lastName, subs, stat);
            LoadDataIntoDataGridView();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int teacherid = Convert.ToInt32(teacherID.Text);
            string firstName = Firstname.Text;
            string lastName = Lastname.Text;
            string subs = subject.Text;
            string stat = status.SelectedItem.ToString();
            UpdateTeacher(teacherid, firstName, lastName,subs, stat);
            LoadDataIntoDataGridView();
        }

        private void teacherID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void subject_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void printbtn1_Click(object sender, EventArgs e)
        {

        }
    }
}
