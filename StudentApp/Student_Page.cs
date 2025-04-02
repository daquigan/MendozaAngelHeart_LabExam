// Student_Page.cs
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT studentId, CONCAT(firstName, ' ', lastName) AS fullName FROM StudentRecordTB", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                studentGridView.DataSource = dt;
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
    }
}
