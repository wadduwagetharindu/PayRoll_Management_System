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
using static System.Windows.Forms.AxHost;

namespace PayRollTuto1
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
            ShowAttendance();
            GetEmployees();
            //GetEmployeeName();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\DB\PayRoll1.mdf"";Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            EmpNameTb.Text = "";
            PresenceTb.Text = "";
            AbsTb.Text = "";
            ExcuseTb.Text = "";



            Key = 0;
        }

        private void ShowAttendance()
        {
            Con.Open();
            string Query = "Select * from AttendanceTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendenceDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetEmployees()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from EmployeeTb", Con);
            SqlDataReader Rdr;
            Rdr = Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId",typeof(int));
            dt.Load(Rdr);
            EmpIdCb.ValueMember = "EmpId";
            EmpIdCb.DataSource = dt;

            Con.Close();
        }

        private void GetEmployeeName()
        {
            Con.Open();
            string Query = "Select * from EmployeeTb where EmpId=" +EmpIdCb.SelectedValue.ToString()+ "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                EmpNameTb.Text = dr["EmpName"].ToString();
            }
            
            Con.Close();
        }
            private void SaveBtn_Click(object sender, EventArgs e)
            {
            if (EmpNameTb.Text == "" || PresenceTb.Text == "" || ExcuseTb.Text == "" || AbsTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Period = AttDate.Value.Month + "-" + AttDate.Value.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AttendanceTb1(EmpId,EmpName,Daypres,DayAbs,DayExcused,Period) values(@EI,@EN,@DP,@DA,@DE,@PER)", Con);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                    cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                    cmd.Parameters.AddWithValue("@DE", ExcuseTb.Text);
                    cmd.Parameters.AddWithValue("@PER", Period);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance saved");

                    Con.Close();
                    ShowAttendance();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

            private void AbnTb_TextChanged(object sender, EventArgs e)
            {

            }

        int Key = 0;
        private void AttendenceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = AttendenceDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpIdCb.SelectedItem = AttendenceDGV.SelectedRows[0].Cells[1].Value.ToString();
            PresenceTb.Text = AttendenceDGV.SelectedRows[0].Cells[3].Value.ToString();
            AbsTb.Text = AttendenceDGV.SelectedRows[0].Cells[4].Value.ToString();
            ExcuseTb.Text = AttendenceDGV.SelectedRows[0].Cells[5].Value.ToString();
            AttDate.Text = AttendenceDGV.SelectedRows[0].Cells[6].Value.ToString();
           
            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AttendenceDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmployeeName();
        }

       

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || PresenceTb.Text == "" || ExcuseTb.Text == "" || AbsTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Period = AttDate.Value.Month + "-" + AttDate.Value.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AttendanceTb1 Set EmpId=@EI,EmpName=@EN,Daypres=@DP,DayAbs=@DA,DayExcused=@DE,Period=@PER where AttNum=@AttKey" , Con);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                    cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                    cmd.Parameters.AddWithValue("@DE", ExcuseTb.Text);
                    cmd.Parameters.AddWithValue("@PER", Period);
                    cmd.Parameters.AddWithValue("@AttKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated");

                    Con.Close();
                    ShowAttendance();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

        private void EmpIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Salary Obj = new Salary();
            Obj.Show();
        }
    }
}
