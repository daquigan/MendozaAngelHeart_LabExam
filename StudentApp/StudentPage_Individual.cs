// StudentPage_Individual.cs
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class StudentPage_Individual : Form
    {
        private string connectionString = "server=localhost; database=StudentInfoDB; uid=root; pwd=lis@0327;";
        private int studentId;

        public StudentPage_Individual(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT sr.*, c.courseName, y.yearLvl 
            FROM StudentRecordTB sr
            JOIN CourseTB c ON sr.courseId = c.courseId
            JOIN YearTB y ON sr.yearId = y.yearId
            WHERE sr.studentId = @studentId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblStudentId.Text = "Student Id: " + reader["studentId"].ToString();
                    lblFullName.Text = "Full Name: " + reader["firstName"].ToString() + " " + reader["middleName"].ToString() + " " + reader["lastName"].ToString();
                    lblAddress.Text = "Address: " + reader["houseNo"].ToString() + ", " + reader["brgyName"].ToString() + ", " +
                                      reader["municipality"].ToString() + ", " + reader["province"].ToString() + ", " +
                                      reader["region"].ToString() + ", " + reader["country"].ToString();
                    lblBirthdate.Text = "Birthdate: " + reader["birthdate"].ToString();
                    lblAge.Text = "Age: " + reader["age"].ToString();
                    lblContact.Text = "Contact Number: " + (reader["studContactNo"] != DBNull.Value ? reader["studContactNo"].ToString() : "N/A");
                    lblEmail.Text = "Email Address: " + (reader["emailAddress"] != DBNull.Value ? reader["emailAddress"].ToString() : "N/A");
                    lblGuardian.Text = "Guardian: " + reader["guardianFirstName"].ToString() + " " + reader["guardianLastName"].ToString();
                    lblHobbies.Text = "Hobby: " + reader["hobbies"].ToString();
                    lblNickname.Text = "Nickname: " + reader["nickname"].ToString();
                    lblCourse.Text = "Course: " + reader["courseName"].ToString();
                    lblYear.Text = "Year Level: " + reader["yearLvl"].ToString();
                }
            }
        }

    }
}