using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollTuto1
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            ShowEmployee();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == "" || EmpSalTb.Text == "" || EmpQualCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EmployeeTb Set EmpName=@EN,EmpGen=@EG,EmpDOB=@ED,EmpPhone=@EP,EmpAdd=@EA,EmpPos=@EPOS,EmpDate=@JD,EmpQual=@EQ,EmpBasSal=@EBS where EmpId=@EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString()); 
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EPOS", EmpPosCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                    cmd.Parameters.AddWithValue("@EmpKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated");

                    Con.Close();
                    ShowEmployee();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
     
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\DB\PayRoll1.mdf"";Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            EmpNameTb.Text = "";
            EmpAddTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpSalTb.Text = "";
            EmpGenCb.SelectedIndex = 0;
            EmpPosCb.SelectedIndex = 0;
            EmpQualCb.SelectedIndex = 0;
            Key = 0;
        }

        private void ShowEmployee()
        {
            Con.Open();
            string Query = "Select * from EmployeeTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == "" || EmpSalTb.Text == "" || EmpQualCb.SelectedIndex == -1) 
            {
                MessageBox.Show("Missing Information");
            }
            else 
            {
                try 
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTb(EmpName,EmpGen,EmpDOB,EmpPhone,EmpAdd,EmpPos,EmpDate,EmpQual,EmpBasSal) values(@EN,@EG,@ED,@EP,@EA,@EPOS,@JD,@EQ,@EBS)", Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EPOS", EmpPosCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee saved");

                    Con.Close();
                    ShowEmployee();
                    Clear();
                }
                catch(Exception Ex) 
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

        int Key = 0;
        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpGenCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpDOB.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmpAddTb.Text = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpPosCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[6].Value.ToString();
            JDate.Text = EmployeeDGV.SelectedRows[0].Cells[7].Value.ToString();
            EmpQualCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[8].Value.ToString();
            EmpSalTb.Text = EmployeeDGV.SelectedRows[0].Cells[9].Value.ToString();
            if(EmpNameTb.Text =="")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete EmployeeTb Where EmpId=@EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EmpKey",Key);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");

                    Con.Close();
                    ShowEmployee();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();
            Obj.Show();
            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Aadvance Obj = new Aadvance();
            Obj.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();    
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Attendence Obj = new Attendence();
            Obj.Show();
            this.Hide();
        }
    }
}
