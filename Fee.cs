using SchoolRegistrationSystem;
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

namespace SistemScolarDeInregistrare_Proof_Elev_
{
    public partial class FrmFee : MaterialSkin.Controls.MaterialForm

    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Connection con = new Connection();
        public FrmFee()
        {
            InitializeComponent();
            name();
            FirstName();
            ClassFee();
            Month();
            btn_fee_Update.Enabled = false;
            btn_fee_Delete.Enabled = false;
        }

        public void name()
        {
            dataAdpt = new SqlDataAdapter("select * from Students", con.ConnectionOpening());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbFeeName.DataSource = dt;
            cmbFeeName.DisplayMember = "name";
            cmbFeeName.ValueMember = "studentsID";

            con.CloseConnection();
        }
        public void FirstName()
        {
            dataAdpt = new SqlDataAdapter("select * from Students", con.ConnectionOpening());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbFeeFirstName.DataSource = dt;
            cmbFeeFirstName.DisplayMember = "firstName";
            cmbFeeFirstName.ValueMember = "studentsID";

            con.CloseConnection();
        }

        public void ClassFee()
        {
            try
            {
                dataAdpt = new SqlDataAdapter("select * from Class", con.ConnectionOpening());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbFeeClass.DataSource = dt;
                cmbFeeClass.DisplayMember = "nameClass";
                cmbFeeClass.ValueMember = "classID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.CloseConnection();
        }

        public void Month()
        {
            try
            {
                dataAdpt = new SqlDataAdapter("select * from Month", con.ConnectionOpening());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbMonth.DataSource = dt;
                cmbMonth.DisplayMember = "month";
                cmbMonth.ValueMember = "monthID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.CloseConnection();
        }

        private void btn_fee_Save_Click(object sender, EventArgs e)
        {
            int Class = Convert.ToInt32(cmbFeeClass.SelectedValue.ToString());
            int Name = Convert.ToInt32(cmbFeeName.SelectedValue.ToString());
            int firstName = Convert.ToInt32(cmbFeeFirstName.SelectedValue.ToString());
            int Month = Convert.ToInt32(cmbMonth.SelectedValue.ToString());
            try
            {
                if (cmbFeeClass.Text != "" && cmbFeeName.Text != "" && cmbFeeFirstName.Text != "" && cmbMonth.Text != "" && txtSum.Text != "")
                {
                    con.ConnectionOpening();
                    using (cmd = con.CreateCommand())
                    {


                        String sql = "INSERT INTO FEE ( classID,  nameID,  firstNameID,  dateOfAdmission,  monthKey, sum)" +
                 "VALUES          (@classID, @nameID, @firstNameID, @dateOfAdmission, @monthKey, @sum)";

                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Add(new SqlParameter("classID", SqlDbType.Int) { Value = Class });
                        cmd.Parameters.Add(new SqlParameter("nameID", SqlDbType.Int) { Value = Name });
                        cmd.Parameters.Add(new SqlParameter("firstnameID", SqlDbType.Int) { Value = firstName });
                        cmd.Parameters.Add(new SqlParameter("dateOfAdmission", SqlDbType.VarChar) { Value = dtDateOfAdmission.Text });
                        cmd.Parameters.Add(new SqlParameter("monthKey", SqlDbType.Int) { Value = Month });
                        cmd.Parameters.Add(new SqlParameter("sum", SqlDbType.VarChar) { Value = txtSum.Text });

                        //You are getting the error because you haven't specified the columns in the INSERT statement.
                        //  cmd = new SqlCommand("insert into Fee values('"+ Class + "', '" + Name + "', '" + firstName + "', " +
                        //      "'" + dtDateOfAdmission.Text + "', '" + Month + "', '" + "', '" + txtSum.Text + "')", con.ConnectionOpening());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("The data has been saved", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //}
                else
                {
                    MessageBox.Show("Please fill in all the fields!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseConnection();
        }

        private void btn_fee_Data_Click(object sender, EventArgs e)
        {
            FrmDisplayFeesData fees = new FrmDisplayFeesData();
            fees.Show();
            Hide();

        }

        private void btn_fee_Add_Click(object sender, EventArgs e)
        {
            cmbFeeClass.Text = "";
            cmbFeeName.Text = "";
            cmbFeeFirstName.Text = "";
            cmbMonth.Text = "";
            txtSum.Text = "";

        }

        private void btn_fee_Update_Click(object sender, EventArgs e)
        {
            int classID = Convert.ToInt32(cmbFeeClass.SelectedValue);
            int nameID = Convert.ToInt32(cmbFeeName.SelectedValue);
            int firstNameID = Convert.ToInt32(cmbFeeFirstName.SelectedValue);
            //string dataAdFee = dtDateOfAdmission.Value.ToString("dd-MM-yyyy");
            int monthID = Convert.ToInt32(cmbMonth.SelectedValue);

            try
            {
                if (cmbFeeClass.Text != "" && cmbFeeName.Text != "" && cmbFeeFirstName.Text != "" && cmbMonth.Text != "" && txtSum.Text != "")
                {
                    con.ConnectionOpening();
                    using (cmd = con.CreateCommand())
                    {

                        String sql = "UPDATE FEE SET classID = @classID,  nameID = @nameID,  firstNameID = @firstNameID,  " +
                            "dateOfAdmission = @dateOfAdmission,  monthKey = @monthKey, sum = @sum  WHERE feeID = '" + FrmDisplayFeesData.feeID + "'";

                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Add(new SqlParameter("classID", SqlDbType.Int) { Value = classID });
                        cmd.Parameters.Add(new SqlParameter("nameID", SqlDbType.Int) { Value = nameID });
                        cmd.Parameters.Add(new SqlParameter("firstnameID", SqlDbType.Int) { Value = firstNameID });
                        cmd.Parameters.Add(new SqlParameter("dateOfAdmission", SqlDbType.VarChar) { Value = dtDateOfAdmission.Text });
                        cmd.Parameters.Add(new SqlParameter("monthKey", SqlDbType.Int) { Value = monthID });
                        cmd.Parameters.Add(new SqlParameter("sum", SqlDbType.VarChar) { Value = txtSum.Text });


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("The data has been updated!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseConnection();

        }

        private void btn_fee_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from Fee WHERE feeID = '" + FrmDisplayFeesData.feeID + "'", con.ConnectionOpening());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data was deleted successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseConnection();
        }
    }
    
}
