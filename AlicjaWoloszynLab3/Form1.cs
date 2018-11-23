using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTest
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = DESKTOP-ETE01TV; database=AlicjaWoloszynLab3; Trusted_Connection=yes");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewGrades_Click(object sender, EventArgs e)
        {
            ShowData("GradesView");
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM GradesView", connection);
            //DataTable table = new DataTable();
            //dataAdapter.Fill(table);
            //dataGridViewData.DataSource = table;

        }
        /// <summary>
        /// Dodawanie nowego kursu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"INSERT INTO Courses(Name, Teacher) VALUES (@Name, @Teacher)", connection);

            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxCourseName.Text;
            command.Parameters.Add("@Teacher", SqlDbType.NVarChar).Value = textBoxTeacherName.Text;
            connection.Open();
            //wykonanie kwerendy
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ShowData(string tableName)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT * FROM " + tableName, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridViewData.DataSource = table;
        }

        private void buttonViewCourses_Click(object sender, EventArgs e)
        {
            ShowData("Courses");
        }
    }
}
