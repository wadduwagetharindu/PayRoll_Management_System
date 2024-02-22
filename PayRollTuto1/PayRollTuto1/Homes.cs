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

namespace PayRollTuto1
{
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
            CountEmployee();
            CountManagers();
            SumSalary();
            SumBonus();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\DB\PayRoll1.mdf"";Integrated Security=True;Connect Timeout=30");

        private void CountEmployee()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTb", Con);
            DataTable dt = new DataTable();
            sda .Fill(dt);
            EmpLb1.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountManagers()
        {
            string Pos = "Manager";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTb where EmpPos='"+Pos+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ManagerLb1.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void SumSalary()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBalance) from SalaryTb1 ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SalaryLb1.Text = "Rs " +dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void SumBonus()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBonus) from SalaryTb1 ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BonusLb1.Text = "Rs" +dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Salary Obj = new Salary();
            Obj.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Homes_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
