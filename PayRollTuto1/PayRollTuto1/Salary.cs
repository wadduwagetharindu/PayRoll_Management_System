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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
            GetEmployees();
            GetAttendence();
           
            GetBonus();
            ShowSalary();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BonusIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ExcusedTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\DB\PayRoll1.mdf"";Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            EmpNameTb.Text = "";
            PresTb.Text = "";
            AbsTb.Text = "";
            ExcusedTb.Text = "";

           // Key = 0;
        }

        private void ShowSalary()
        {
            Con.Open();
            string Query = "Select * from SalaryTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SalaryDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetEmployees()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from EmployeeTb", Con);
            SqlDataReader Rdr;
            Rdr = Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            EmpIdCb.ValueMember = "EmpId";
            EmpIdCb.DataSource = dt;

            Con.Close();
        }

        private void GetBonus()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from BonusTb1", Con);
            SqlDataReader Rdr;
            Rdr = Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BName", typeof(String));
            dt.Load(Rdr);
            BonusIdCb.ValueMember = "BName";
            BonusIdCb.DataSource = dt;

            Con.Close();
        }

        private void GetAttendence()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from AttendanceTb1 where EmpId="+EmpIdCb.SelectedValue.ToString()+"", Con);
            SqlDataReader Rdr;
            Rdr = Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AttNum", typeof(int));
            dt.Load(Rdr);
            AttNumCb.ValueMember = "AttNum";
            AttNumCb.DataSource = dt;

            Con.Close();
        }

        private void GetAttendanceData()
        {
            Con.Open();
            string Query = "Select * from AttendanceTb1 where AttNum=" + AttNumCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PresTb.Text = dr["Daypres"].ToString();
                AbsTb.Text = dr["DayAbs"].ToString();
                ExcusedTb.Text = dr["DAyExcused"].ToString();
            }

            Con.Close();
        }

        private void GetEmployeeName()
        {
            Con.Open();
            string Query = "Select * from EmployeeTb where EmpId=" + EmpIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmpNameTb.Text = dr["EmpName"].ToString();
                BaseSalaryTb.Text = dr["EmpBassal"].ToString();
            }

            Con.Close();
        }

        private void GetBonusAmt()
        {
            Con.Open();
            string Query = "Select * from BonusTb1 where BName='" + BonusIdCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BonusTb.Text = dr["BAmt"].ToString();
                BonusTb.Text = dr["BAmt"].ToString();
            }

            Con.Close();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || PresTb.Text == "" || AbsTb.Text =="" || ExcusedTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Period = SalDate.Value.Month + "-" + SalDate.Value.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SalaryTb1(EmpId,EmpName,EmpBasSal,EmpBonus,EmpAdvance,EmpTax,EmpBalance,SalPeriod) values(@EI,@EN,@EBS,@EBon,@EAd,@ETax,@EBalance,@SPer)", Con);
                   
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EBS", BaseSalaryTb.Text);
                    cmd.Parameters.AddWithValue("@Ebon", BonusTb.Text); 
                    cmd.Parameters.AddWithValue("@EAd", AdvanceTb.Text);
                    cmd.Parameters.AddWithValue("@ETax", TotTax); 
                    cmd.Parameters.AddWithValue("@Ebalance", GrdTot);
                    cmd.Parameters.AddWithValue("@SPer", Period);
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Saved");

                    Con.Close();
                    ShowSalary();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmployeeName();
            GetAttendence();
        }

        private void BonusIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBonusAmt();
        }

        private void AttNumCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetAttendanceData();
        }

        int DailyBase = 0,Total=0, pres=0, Abs=0, EXC=0;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Attendence Obj = new Attendence();
            Obj.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MyCodeSpace", new Font("Averia", 12, FontStyle.Bold), Brushes.Red, new Point(190, 25));
            e.Graphics.DrawString("PayRoll Management Style 1.0", new Font ("Averia", 10,FontStyle.Bold),Brushes.Blue, new Point(145,50));
            
            string SalNum = SalaryDGV.SelectedRows[0].Cells[0].Value.ToString();
            string EmpId = SalaryDGV.SelectedRows[0].Cells[1].Value.ToString();
            string EmpName = SalaryDGV.SelectedRows[0].Cells[2].Value.ToString();
            string BasSal = SalaryDGV.SelectedRows[0].Cells[3].Value.ToString();
            string Bonus = SalaryDGV.SelectedRows[0].Cells[4].Value.ToString();
            string Advance = SalaryDGV.SelectedRows[0].Cells[5].Value.ToString();
            string Tax = SalaryDGV.SelectedRows[0].Cells[6].Value.ToString();
            string Balance = SalaryDGV.SelectedRows[0].Cells[7].Value.ToString();
            string Period = SalaryDGV.SelectedRows[0].Cells[8].Value.ToString();

            e.Graphics.DrawString("Salary Number: "+ SalNum, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 100));
            e.Graphics.DrawString("Employee Id: " + EmpId, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 150));
            e.Graphics.DrawString("Employee Name: " + EmpName, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(250, 150));
            e.Graphics.DrawString("Base Salary : " + BasSal, new Font("Bellota", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 180));
            e.Graphics.DrawString("Bonus: Rs " + Bonus, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 210));
            e.Graphics.DrawString("Advance  On Salary: Rs " + Advance, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 240));
            e.Graphics.DrawString("Tax: Rs " + Tax, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 270));
            e.Graphics.DrawString("Total: Rs " + Balance, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 300));
            e.Graphics.DrawString("Period " + Period, new Font("Bellota", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 330));


            e.Graphics.DrawString("Powered By MyCodeSpace", new Font("Bellota", 12, FontStyle.Bold), Brushes.Crimson, new Point(130, 420));
            e.Graphics.DrawString("*********Version 1.0*********" , new Font("Bellota", 12, FontStyle.Bold), Brushes.Blue, new Point(130, 440));


        }

        private void SalaryDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 500, 800);
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            {
                printDocument1.Print();
            }
        }

        double GrdTot = 0, TotTax = 0;

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (BaseSalaryTb.Text == "" || BonusTb.Text =="" || AdvanceTb.Text =="")
            {
                MessageBox.Show("Missing the Information");
            }
            else
            {
                pres = Convert.ToInt32(PresTb.Text);
                Abs = Convert.ToInt32(AbsTb.Text);
                EXC = Convert.ToInt32(ExcusedTb.Text);
                DailyBase = Convert.ToInt32(BaseSalaryTb.Text) / 28;
                Total = ((DailyBase) * pres) + ((DailyBase / 2) * EXC);
                Double Tax = Total * 0.16;
                TotTax = Total - Tax;
               // GrdTot = TotTax + Convert.ToDouble(BonusTb.Text);
                GrdTot = TotTax + Convert.ToDouble(BonusTb.Text) + Convert.ToDouble(BaseSalaryTb.Text);
                BalanceTb.Text = "Rs" + GrdTot;
                
            }
        }
    }
}
