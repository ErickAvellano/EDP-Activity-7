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

namespace SchoolManagementSystem
{
    public partial class Login1 : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;

        public Login1()
        {
            InitializeComponent();
            InitializeDatabase();
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

        private void user_TextChanged(object sender, EventArgs e)
        {
            CheckLoginButtonEnabled();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            CheckLoginButtonEnabled();
        }

        private void CheckLoginButtonEnabled()
        {
            loginbtn.Enabled = !string.IsNullOrWhiteSpace(user.Text) && !string.IsNullOrWhiteSpace(password.Text);
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = user.Text;
            string enteredPassword = password.Text;

            try
            {
                connection.Open();

                string query = "SELECT * FROM admin WHERE username=@username AND password=@password";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", enteredPassword);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    var manage = new Management();
                    manage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
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

        private void Login1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void recover_Click(object sender, EventArgs e)
        {
            this.Hide();
            var recovery = new recovery();
            recovery.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Homepage();
            home.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
