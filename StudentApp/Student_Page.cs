
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Student_Page : Form
    {
        private string connectionString = "server=localhost; database=StudentInfoDB; uid=root; pwd=lis@0327;";

        public Student_Page()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT studentId AS StudentID, CONCAT(firstName, ' ',middleName,' ', lastName) AS FullName FROM StudentRecordTB", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                studentGridView.DataSource = dt;
                studentGridView.Columns["FullName"].HeaderText = "Full Name";
                studentGridView.Columns["studentId"].HeaderText = "Student ID";
            }
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == studentGridView.Columns["ViewBtn"].Index && e.RowIndex >= 0)
            {
                int studentId = Convert.ToInt32(studentGridView.Rows[e.RowIndex].Cells["studentId"].Value);
                StudentPage_Individual individualPage = new StudentPage_Individual(studentId);
                individualPage.Show();
            }
        }

        private void Student_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
