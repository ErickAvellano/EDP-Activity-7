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
using OfficeOpenXml;
using System.IO;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;




namespace SchoolManagementSystem
{
    public partial class Management : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public Management()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Homepage();
            home.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void studentbtn_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var course = new Course();
            course.Show();
        }
        private void AddNewStudent(string firstName, string lastName, DateTime birthDate, int gradeLevel)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO students (FirstName, LastName, BirthDate, GradeLevel) VALUES (@firstName, @lastName, @birthDate, @gradeLevel)";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@birthDate", birthDate);
                command.Parameters.AddWithValue("@gradeLevel", gradeLevel);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add student!");
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

        private void Addnewbtn_Click(object sender, EventArgs e)
        {
            string firstName = Firstname.Text;
            string lastName = Lastname.Text;
            int gradeLevel = Convert.ToInt32(Gradelevel.Text);
            DateTime birthDate = dateTimePicker1.Value;

            AddNewStudent(firstName, lastName, birthDate, gradeLevel);
            LoadDataIntoDataGridView();
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            int studentid = Convert.ToInt32(studentID.Text);
            string firstName = Firstname.Text;
            string lastName = Lastname.Text;
            DateTime birthDate = dateTimePicker1.Value;
            int gradeLevel = Convert.ToInt32(Gradelevel.Text);

            UpdateStudent(studentid, firstName, lastName, birthDate, gradeLevel);
            LoadDataIntoDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM students";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {

        }
        private void Gradelevel_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve data from the selected row
                int studentid = Convert.ToInt32(selectedRow.Cells["StudentID"].Value);
                string firstName = Convert.ToString(selectedRow.Cells["FirstName"].Value);
                string lastName = Convert.ToString(selectedRow.Cells["LastName"].Value);
                int gradeLevel = Convert.ToInt32(selectedRow.Cells["GradeLevel"].Value);
                DateTime birthDate = Convert.ToDateTime(selectedRow.Cells["BirthDate"].Value);

                // Populate text boxes and controls with the selected row data
                studentID.Text = studentid.ToString();
                Firstname.Text = firstName;
                Lastname.Text = lastName;
                Gradelevel.Text = gradeLevel.ToString();
                dateTimePicker1.Value = birthDate;
            }
        }
        private void UpdateStudent(int studentid, string firstName, string lastName, DateTime birthDate, int gradeLevel)
        {
            try
            {
                connection.Open();
                // Update the student record in the database
                string query = "UPDATE students SET FirstName = @firstName, LastName = @lastName, BirthDate = @birthDate, GradeLevel = @gradeLevel WHERE StudentID = @studentID";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@birthDate", birthDate);
                command.Parameters.AddWithValue("@gradeLevel", gradeLevel);
                command.Parameters.AddWithValue("@studentId", studentid);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update student information!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating student information: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void studentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var admin = new Admin();
            admin.Show();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
           
        }
        private Color GetColorForGrade(string gradeLevel)
        {
            switch (gradeLevel)
            {
                case "7":
                    return Color.Yellow; // Change to yellow for grade level 7
                case "8":
                    return Color.LightBlue;
                case "9":
                    return Color.LightGreen;
                case "10":
                    return Color.Orange;
                case "11":
                    return Color.Maroon;
                case "12":
                    return Color.Pink;
                default:
                    return Color.Gray; // Default color for other grade levels
            }
        }

        private void printbtn1_Click(object sender, EventArgs e)
        {
            string filePath = @"F:\VisualStudio2022 Repository\SchoolManagementSystem\School Records.xlsx";
            try
            {
                connection.Open();

                string query = "SELECT GradeLevel, COUNT(*) AS TotalStudents FROM students GROUP BY GradeLevel ORDER BY GradeLevel ASC;";
                string courseQuery = "SELECT CourseID, CourseName, Credits FROM courses;";
                string teacherQuery = "SELECT CONCAT(FirstName, ' ', LastName) AS FullName, SubjectTaught FROM teachers";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> gradeLevels = new List<string>();
                        List<int> totalStudents = new List<int>();

                        // Retrieve grade levels and total students
                        while (reader.Read())
                        {
                            string gradeLevel = reader["GradeLevel"].ToString();
                            gradeLevels.Add(gradeLevel);
                            totalStudents.Add(Convert.ToInt32(reader["TotalStudents"]));
                        }

                        reader.Close();

                        // Create Excel package
                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet_2 = excelPackage.Workbook.Worksheets.Add("Report");
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Graphs");

                            var picture = worksheet.Drawings.AddPicture("Logo", new FileInfo("F:\\VisualStudio2022 Repository\\SchoolManagementSystem\\SchoolManagementSystem\\img\\Letter-A-icon_34765.ico"));
                            // Set the size of the picture
                            picture.SetSize(70, 70); // Set the picture size in pixels

                            // Set the width of column 1 and height of row 1
                            worksheet.Column(1).Width = 13.71;
                            worksheet.Row(1).Height = 52.50;

                            // Calculate the offsets to center the picture in cell A1
                            double cellWidth = worksheet.Column(1).Width;
                            double cellHeight = worksheet.Row(1).Height;
                            double xOffset = cellWidth / 13.71; // Calculate horizontal offset
                            double yOffset = cellHeight / 4; // Calculate vertical offset

                            // Set the position of the picture to center it in cell A1
                            picture.SetPosition(0, (int)xOffset, 0, (int)yOffset);

                            ExcelRange cellsToMerge = worksheet.Cells["B1:I1"];
                            cellsToMerge.Merge = true;
                            cellsToMerge.Value = "Abante International School";
                            cellsToMerge.Style.Font.Size = 20;
                            cellsToMerge.Style.Font.Name = "Broadway";
                            cellsToMerge.Style.Font.Color.SetColor(Color.Black);
                            cellsToMerge.Style.Font.Bold = true;
                            cellsToMerge.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cellsToMerge.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                            // Populate Excel worksheet with data
                            for (int i = 0; i < gradeLevels.Count; i++)
                            {
                                worksheet.Cells[i + 3, 1].Value = gradeLevels[i];
                                worksheet.Cells[i + 3, 2].Value = totalStudents[i];
                            }

                            // Create a chart
                            ExcelChart chart = worksheet.Drawings.AddChart("Chart", eChartType.ColumnClustered);
                            chart.SetPosition(2, 0, 0, 0);
                            chart.SetSize(615, 370);
                            chart.Title.Text = "Enrolled in SY: 2023-2024";
                            chart.YAxis.Title.Text = "Total Students";

                            // Move legend to the bottom
                            chart.Legend.Position = eLegendPosition.Bottom;
                            chart.XAxis.Title.Text = "Grade Level";

                            // Add series to the chart
                            for (int i = 0; i < gradeLevels.Count; i++)
                            {
                                var series = chart.Series.Add(worksheet.Cells[i + 3, 2]);
                                series.Header = $"Grade {gradeLevels[i]}";
                                series.Fill.Color = GetColorForGrade(gradeLevels[i]);
                            }
                            chart.XAxis.MajorTickMark = eAxisTickMark.None;
                            chart.XAxis.TickLabelPosition = eTickLabelPosition.None;

                            // Add signature placeholder
                            worksheet.Cells[23, 7].Value = "_________________________";
                            worksheet.Cells[24, 8].Value = "Principal"; // Placeholder for signature

                            //for worksheet 1
                            var picture1 = worksheet_2.Drawings.AddPicture("Logo", new FileInfo("F:\\VisualStudio2022 Repository\\SchoolManagementSystem\\SchoolManagementSystem\\img\\Letter-A-icon_34765.ico"));
                            // Set the size of the picture
                            picture1.SetSize(70, 70); // Set the picture size in pixels

                            // Set the width of column 1 and height of row 1
                            worksheet_2.Column(1).Width = 13.71;
                            worksheet_2.Row(1).Height = 52.50;

                            // Calculate the offsets to center the picture in cell A1
                            double cellWidths = worksheet_2.Column(1).Width;
                            double cellHeights = worksheet_2.Row(1).Height;
                            // Set the position of the picture to center it in cell A1
                            picture1.SetPosition(0, (int)xOffset, 0, (int)yOffset);

                            ExcelRange cellsToMerge2 = worksheet_2.Cells["B1:I1"];
                            cellsToMerge2.Merge = true;
                            cellsToMerge2.Value = "Abante International School";
                            cellsToMerge2.Style.Font.Size = 20;
                            cellsToMerge2.Style.Font.Name = "Broadway";
                            cellsToMerge2.Style.Font.Color.SetColor(Color.Black);
                            cellsToMerge2.Style.Font.Bold = true;
                            cellsToMerge2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cellsToMerge2.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                            // Add a header for the table

                            ExcelRange cellsToMerge3 = worksheet_2.Cells["D3:E3"];
                            cellsToMerge3.Merge = true;
                            cellsToMerge3.Value = "Enrolled in SY: 2023-2024";
                            cellsToMerge3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cellsToMerge3.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            worksheet_2.Cells["D4"].Value = "Grade Level";
                            worksheet_2.Cells["E4"].Value = "Total Students";

                            // Populate the worksheet with data
                            for (int i = 0; i < gradeLevels.Count; i++)
                            {
                                worksheet_2.Cells[i + 5, 4].Value = gradeLevels[i]; // Assuming 'gradeLevels' contains grade levels
                                worksheet_2.Cells[i + 5, 5].Value = totalStudents[i]; // Assuming 'totalStudents' contains total students per grade level
                            }

                            // Add styling to the table
                            using (ExcelRange range = worksheet_2.Cells["D4:E4"])
                            {
                                range.Style.Font.Bold = true;
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                range.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                            }
                            // Auto-fit columns
                            worksheet_2.Cells[worksheet_2.Dimension.Address].AutoFitColumns();

                            using (MySqlCommand courseCommand = new MySqlCommand(courseQuery, connection))
                            {
                                using (MySqlDataReader courseReader = courseCommand.ExecuteReader())
                                {
                                    ExcelRange cellsToMerge4 = worksheet_2.Cells["D13:F13"];
                                    cellsToMerge4.Merge = true;
                                    cellsToMerge4.Value = "Available Course Offers";
                                    cellsToMerge4.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cellsToMerge4.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                    using (ExcelRange range1 = worksheet_2.Cells["D14:F14"])
                                    {
                                        range1.Style.Font.Bold = true;
                                        range1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                        range1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                        range1.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                        range1.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                                    }
                                    // Add header for course offerings
                                    worksheet_2.Cells["D14"].Value = "Course ID";
                                    worksheet_2.Cells["E14"].Value = "Course Name";
                                    worksheet_2.Cells["F14"].Value = "Credits";

                                    // Populate the worksheet with course offerings data
                                    int row = 15; // Starting row for data
                                    while (courseReader.Read())
                                    {
                                        int courseId = Convert.ToInt32(courseReader["CourseID"]);
                                        string courseName = courseReader["CourseName"].ToString();
                                        int credits = Convert.ToInt32(courseReader["Credits"]);

                                        worksheet_2.Cells[row, 4].Value = courseId;  // Column D (4) for Course ID
                                        worksheet_2.Cells[row, 5].Value = courseName; // Column E (5) for course name
                                        worksheet_2.Cells[row, 6].Value = credits;    // Column F (6) for credits

                                        row++; // Move to the next row
                                    }

                                    courseReader.Close();
                                }
                            }

                            using (MySqlCommand teacherCommand = new MySqlCommand(teacherQuery, connection))
                            {
                                using (MySqlDataReader teacherReader = teacherCommand.ExecuteReader())
                                {
                                    // Add headers

                                    ExcelRange cellsToMerge5 = worksheet_2.Cells["D23:E23"];
                                    cellsToMerge5.Merge = true;
                                    cellsToMerge5.Value = "Faculty";
                                    cellsToMerge5.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    cellsToMerge5.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                                    worksheet_2.Cells["D24"].Value = "Full Name";
                                    worksheet_2.Cells["E24"].Value = "Subject Taught";

                                    using (ExcelRange range2 = worksheet_2.Cells["D24:E24"])
                                    {
                                        range2.Style.Font.Bold = true;
                                        range2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                        range2.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                        range2.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                        range2.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                                    }

                                    int row = 25; // Start from the second row for data
                                    while (teacherReader.Read())
                                    {
                                        string fullName = teacherReader["FullName"].ToString();
                                        string subjectTaught = teacherReader["SubjectTaught"].ToString();

                                        worksheet_2.Cells[row, 4].Value = fullName;
                                        worksheet_2.Cells[row, 5].Value = subjectTaught;

                                        row++;

                                        worksheet_2.Cells[32, 6].Value = "_________________________";
                                        worksheet_2.Cells[33, 7].Value = "Principal";
                                    }

                                    // Auto-fit columns
                                    worksheet_2.Cells[worksheet.Dimension.Address].AutoFitColumns();

                                    teacherReader.Close();
                                }

                            }
                            // Save Excel file
                            excelPackage.SaveAs(new FileInfo(filePath));
                            MessageBox.Show("Excel file saved successfully!");

                            // Dispose the ExcelPackage object
                            excelPackage.Dispose();

                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
            

