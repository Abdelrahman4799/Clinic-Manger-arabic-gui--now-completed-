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

namespace ClnMang
{
    public partial class ClinicMangForm : Form
    {
        static string sql = @"Data Source=DESKTOP-PAOLF9Q\SQLEXPRESS;Initial Catalog=Clinic_management_system;Integrated Security=True;User ID=' ' ;Password=' '";
        SqlConnection con = new SqlConnection(sql);
        private int count_medicine_name = 0;
        private int count_rays_name=0;
        private int count_analysis = 0;
        public void veiw_medicine_name()
        {
            try
            {
                //CREATING PLACES TABLE
                con.Open();
                SqlCommand cmd = new SqlCommand("view_main_data_of_@medicine_name", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable medicine_name_tbl = new DataTable();
                medicine_name_tbl.Columns.Add("medicine_name");
                DataRow row;
                while (reader.Read())
                {
                    row = medicine_name_tbl.NewRow();
                    row["medicine_name"] = reader["medicine_name"];
                    medicine_name_tbl.Rows.Add(row);
                }
                reader.Close();
                DGV_medical.DataSource = medicine_name_tbl;
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error :)");
                con.Close();
            }
        }
        public void veiw_rays()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("view_main_data_of_rays", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable medicine_name_tbl = new DataTable();
                medicine_name_tbl.Columns.Add("rays");
                DataRow row;
                while (reader.Read())
                {
                    row = medicine_name_tbl.NewRow();
                    row["rays"] = reader["rays"];
                    medicine_name_tbl.Rows.Add(row);
                }
                reader.Close();
                DGV_rays.DataSource = medicine_name_tbl;
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error :)");
                con.Close();
            }
        }

        public void veiw_analysis()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("view_main_data_of_analysis", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable medicine_name_tbl = new DataTable();
                medicine_name_tbl.Columns.Add("analysis");
                DataRow row;
                while (reader.Read())
                {
                    row = medicine_name_tbl.NewRow();
                    row["analysis"] = reader["analysis"];
                    medicine_name_tbl.Rows.Add(row);
                }
                reader.Close();
                DGV_anaysis.DataSource = medicine_name_tbl;
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error :)");
                con.Close();
            }
        }
        public ClinicMangForm()
        {
            InitializeComponent();
            veiw_medicine_name();
            veiw_rays();
            veiw_analysis();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ClinicMangForm_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void newExmBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void drugList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void deleteDrugBtn_Click(object sender, EventArgs e)
        {

        }

        private void addDrugBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void PrescriptionBtn_Click(object sender, EventArgs e)
        {
            PrescriptionForm b1 = new PrescriptionForm();
            b1.Show();
        }

        private void DGV_medical_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = DGV_medical.Rows[index];
                txt_medical.Text = selected_row.Cells[0].Value.ToString();
            }
            catch
            {

            }
            
        }

        private void btn_add_medical_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmmmd = new SqlCommand(@"count_main_data_of_@medicine_name  @medicine_name ='" + txt_medical.Text + "'", con);
                count_medicine_name = (int)cmmmd.ExecuteScalar();
                if (txt_medical.Text != "" && count_medicine_name == 0)
                {
                    SqlCommand cmd = new SqlCommand(@"execute insert_main_data_of_@medicine_name  @medicine_name ='" + txt_medical.Text.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //MessageBox.Show(txt_medical.Text);
                    MessageBox.Show("Successfuly inserted");
                    veiw_medicine_name();
                }
                else
                {
                    MessageBox.Show("Check your entered Data :) ");
                    con.Close();
                }


            }
            catch
            {
                MessageBox.Show("check your entered Data");
                con.Close();
            }

            
           
        }

        private void btn_delete_medical_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"delete_main_data_of_@medicine_name @medicine_name = '" + txt_medical.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("deleted");
                veiw_medicine_name();
            }
            catch
            {
                MessageBox.Show("check your entered Data");
                con.Close();
            }
        }

        private void DGV_rays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = DGV_rays.Rows[index];
                txt_rays.Text = selected_row.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btn_add_rays_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmmmd = new SqlCommand(@"execute count_main_data_of_rays  @rays ='" + txt_rays.Text + "'", con);
                count_rays_name = (int)cmmmd.ExecuteScalar();
                if (txt_rays.Text != "" && count_rays_name == 0)
                {
                    SqlCommand cmd = new SqlCommand(@"execute insert_main_data_of_rays  @rays ='" + txt_rays.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //MessageBox.Show(txt_medical.Text);
                    MessageBox.Show("Successfuly inserted");
                    veiw_rays();
                }
                else
                {
                    MessageBox.Show("Check your entered Data :) ");
                    con.Close();
                }


            }
            catch
            {
                MessageBox.Show("check your entered Data");
                con.Close();
            }

            
        }

        private void btn_delete_rays_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"execute delete_main_data_of_rays @rays = '" + txt_rays.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("deleted");
                veiw_rays();
            }
            catch
            {
                MessageBox.Show("check your entered Data");
                con.Close();
            }
        }

        private void DGV_anaysis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selected_row = DGV_anaysis.Rows[index];
                txt_analysis.Text = selected_row.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btn_add_analysis_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand cmmmd = new SqlCommand(@"execute count_main_data_of_analysis  @analysis ='" + txt_analysis.Text + "'", con);
                count_analysis = (int)cmmmd.ExecuteScalar();
                if (txt_analysis.Text != "" && count_rays_name == 0)
                {
                    SqlCommand cmd = new SqlCommand(@"execute insert_main_data_of_analysis  @analysis ='" + txt_analysis.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //MessageBox.Show(txt_medical.Text);
                    MessageBox.Show("Successfuly inserted");
                    veiw_analysis();
                }
                else
                {
                    MessageBox.Show("Check your entered Data :) ");
                    con.Close();
                }


            }
            catch
            {
                MessageBox.Show("check your entered Data");
                con.Close();
            }

        }

        private void btn_delete_analysis_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"execute delete_main_data_of_analysis @analysis = '" + txt_analysis.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("deleted");
                veiw_analysis();
            }
            catch
            {
                MessageBox.Show("check your entered Data");
                con.Close();
            }
        }
    }
}
