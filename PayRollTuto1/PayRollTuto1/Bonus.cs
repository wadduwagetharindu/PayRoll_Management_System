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
    public partial class Bonus : Form
    {
        public Bonus()
        {
            InitializeComponent();
            ShowBonus();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     /*   SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\DB\PayRoll1.mdf"";Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            BNameTb.Text = "";
            BAmountTb.Text = "";
          
            Key = 0;
        }

        private void ShowBonus()
        {
            Con.Open();
            string Query = "Select * from BounasTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BonusDGV.DataSource = ds.Tables[0];
            Con.Close();
        }*/
      /*  private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAmountTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BonusTb1(BName,BAmt) values(@BN,@BA)", Con);
                    cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                    cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus saved");

                    Con.Close();
                    ShowBonus();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }*/
       int Key = 0;
        private void BonusDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BNameTb.Text = BonusDGV.SelectedRows[0].Cells[1].Value.ToString();
            BAmountTb.Text = BonusDGV.SelectedRows[0].Cells[2].Value.ToString();
            if(BNameTb.Text=="")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BonusDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update BonusTb1 Set BName=@BN,BAmt=@BA where BID=@Key", Con);
                    cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                    cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);
                    cmd.Parameters.AddWithValue("@Key",Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus Update");

                    Con.Close();
                    ShowBonus();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Bonus");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete BonusTb1 Where BId=@BKey", Con);
                    cmd.Parameters.AddWithValue("@BKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus Deleted");

                    Con.Close();
                    ShowBonus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\DB\PayRoll1.mdf"";Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            BNameTb.Text = "";
            BAmountTb.Text = "";

           Key = 0;
        }

        private void ShowBonus()
        {
            Con.Open();
            string Query = "Select * from BonusTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BonusDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
            private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BonusTb1(BName,BAmt)values(@BN,@BA)", Con);
                    cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                    cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus saved");

                    Con.Close();
                    ShowBonus();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
   
  
}
