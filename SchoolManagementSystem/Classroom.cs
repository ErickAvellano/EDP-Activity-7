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
using MySqlX.XDevAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagementSystem
{
    public partial class Classroom : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public Classroom()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadDataIntoDataGridView();
            dataGridView1.CellClick += dataGridView1_CellClick;
            PopulateTeacherIDs();
            PopulateCourseIDs();
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

                string query = "SELECT * FROM classrooms";
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
                int classroomid = Convert.ToInt32(selectedRow.Cells["ClassroomID"].Value);
                int teacherid = Convert.ToInt32(selectedRow.Cells["TeacherID"].Value);
                int courseid = Convert.ToInt32(selectedRow.Cells["CourseID"].Value);
                string sched = Convert.ToString(selectedRow.Cells["Schedule"].Value);
                string room = Convert.ToString(selectedRow.Cells["RoomNumber"].Value);


                // Populate text boxes and controls with the selected row data
                classroomID.Text = classroomid.ToString();
                teacherID.Text = teacherid.ToString();
                courseID.Text = courseid.ToString();
                schedule.Text = sched;
                roomNum.Text = room.ToString();
            }
        }
        private void AddNewRoom(int teacherid, int courseid, string sched, string room)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO classrooms (TeacherID, CourseID, Schedule, RoomNumber) VALUES (@teacherid, @courseid, @sched, @room)";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@teacherid", teacherid);
                command.Parameters.AddWithValue("@courseid", courseid);
                command.Parameters.AddWithValue("@sched", sched);
                command.Parameters.AddWithValue("@room", room);



                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Classroom added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add classroom!");
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
        private void PopulateTeacherIDs()
        {
            try
            {
                connection.Open();

                string query = "SELECT TeacherID FROM teachers";
                command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int teacherid = reader.GetInt32("TeacherID");
                        teacherID.Items.Add(teacherid.ToString());
                    }
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
        private void PopulateCourseIDs()
        {
            try
            {
                connection.Open();

                string query = "SELECT CourseID FROM courses";
                command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int courseid = reader.GetInt32("CourseID");
                        courseID.Items.Add(courseid.ToString());
                    }
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
        private void UpdateClassroom(int classroomid, int teacherid, int courseid, string sched, string room)
        {
            try
            {
                connection.Open();
                // Update the teacher record in the database
                //Updates for alt
                string query = "UPDATE classrooms SET TeacherID = @teacherid, CourseID = @courseid, Schedule = @sched, RoomNumber = @room WHERE ClassroomID = @classroomid";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@teacherid", teacherid);
                command.Parameters.AddWithValue("@courseid", courseid);
                command.Parameters.AddWithValue("@sched", sched);
                command.Parameters.AddWithValue("@room", room);
                command.Parameters.AddWithValue("@classroomid", classroomid); // Corrected parameter name

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Classroom information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update classroom information!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating classroom information: " + ex.Message);
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
            LoadDataIntoDataGridView();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Homepage();
            home.Show();
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
            int teacherid = Convert.ToInt32(teacherID.SelectedItem);

            int courseid = Convert.ToInt32(courseID.SelectedItem);

            string sched = schedule.Text;
            string room = roomNum.Text;
            AddNewRoom(teacherid, courseid, sched, room);
            LoadDataIntoDataGridView();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int classroom = Convert.ToInt32(classroomID.Text);
            int teacherid = Convert.ToInt32(teacherID.SelectedItem);
            int courseid = Convert.ToInt32(courseID.SelectedItem);
            string sched = schedule.Text;
            string room = roomNum.Text;
            UpdateClassroom(classroom, teacherid, courseid, sched, room);
            LoadDataIntoDataGridView();
        }

        private void classroomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void courseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void schedule_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacherID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Classroom_Load(object sender, EventArgs e)
        {

        }

        private void courseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update
        }
    }
}
