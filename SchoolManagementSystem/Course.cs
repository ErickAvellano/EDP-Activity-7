using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagementSystem
{
    public partial class Course : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public Course()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadDataIntoDataGridView();
            dataGridView1.CellClick += dataGridView1_CellClick;
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

                string query = "SELECT * FROM courses";
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
                int course = Convert.ToInt32(selectedRow.Cells["CourseID"].Value);
                string coursename = Convert.ToString(selectedRow.Cells["CourseName"].Value);
                string credit = Convert.ToString(selectedRow.Cells["Credits"].Value);

                // Populate text boxes and controls with the selected row data
                courseID.Text = course.ToString();
                courseName.Text = coursename;
                credits.Text = credit;
            }
        }
        private void AddNewCourse(string coursename, string credit)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO courses (CourseName, Credits) VALUES (@coursename, @credit)";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@coursename", coursename);
                command.Parameters.AddWithValue("@credit", credit);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add course!");
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
        private void UpdateCourse(int courseid, string coursename, string credit)
        {
            try
            {
                connection.Open();
                // Update the teacher record in the database
                string query = "UPDATE courses SET CourseName = @coursename, Credits = @credit WHERE CourseID = @courseid";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@coursename", coursename);
                command.Parameters.AddWithValue("@credit", credit);
                command.Parameters.AddWithValue("@courseid", courseid);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update course information!");
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
        private void studentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var student = new Management();
            student.Show();
        }

        private void teacherbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var teach = new Teacher();
            teach.Show();
        }

        private void classroombtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var classr = new Classroom();
            classr.Show();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
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
            string coursename = courseName.Text;
            string credit = credits.Text;
            AddNewCourse(coursename, credit);
            LoadDataIntoDataGridView();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            int courseid = Convert.ToInt32(courseID.Text);
            string coursename = courseName.Text;
            string credit = credits.Text;
            UpdateCourse(courseid, coursename, credit);
            LoadDataIntoDataGridView();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void classroomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void courseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void courseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void credits_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
