using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagementSystem
{
    public partial class recovery : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private int adminId;

        public recovery()
        {
            InitializeComponent();
            InitializeDatabase();
            CheckSearchButtonEnabled();
            CheckConfirmButtonEnabled();
            newpassword.Enabled = false;
            Confirmpass.Enabled = false;
            Confirm.Enabled = false;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string username = searchtext.Text;

            try
            {
                connection.Open();

                string query = "SELECT * FROM admin WHERE username=@username";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Admin account found!");
                        adminId = reader.GetInt32("id");
                        newpassword.Enabled = true;
                        Confirmpass.Enabled=true;
                        Confirm.Enabled=true;
                    }
                    else
                    {
                        MessageBox.Show("Admin account not found!");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckSearchButtonEnabled();
        }
        private void CheckSearchButtonEnabled()
        {
            search.Enabled = !string.IsNullOrWhiteSpace(searchtext.Text);
        }

        private void recovery_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void newpassword_TextChanged(object sender, EventArgs e)
        {
            CheckConfirmButtonEnabled();
        }

        private void Confirmpass_TextChanged(object sender, EventArgs e)
        {
            CheckConfirmButtonEnabled();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string newPassword = newpassword.Text;
            string confirmedPassword = Confirmpass.Text;

            if (newPassword != confirmedPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            int adminId = 0;

            try
            {
                connection.Open();

                string query = "UPDATE admin SET password = @password WHERE id = @adminId";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@password", newPassword);
                command.Parameters.AddWithValue("@adminId", this.adminId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed successfully!" );
                }
                else
                {
                    MessageBox.Show("Failed to change password!");
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
        private void CheckConfirmButtonEnabled()
        {
            Confirm.Enabled =!string.IsNullOrWhiteSpace(newpassword.Text) && !string.IsNullOrWhiteSpace(Confirmpass.Text);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Loginform = new Login1();
            Loginform.Show();
        }
    }
}
