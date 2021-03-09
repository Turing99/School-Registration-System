using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SchoolRegistrationSystem;

namespace SistemScolarDeInregistrare_Proof_Elev_
{
    public partial class FrmProfessors : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Connection con = new Connection();
        public static int professorID;

        public FrmProfessors()
        {
            InitializeComponent();
            CountyDisplay();
            Experience();
            btn_pf_Delete.Enabled = false;
            btn_pf_Update.Enabled = false;
        }
        public void CountyDisplay()
        {
            dataAdpt = new SqlDataAdapter("select * from County", con.ConnectionOpening());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbPfCounty.DataSource = dt;
            cmbPfCounty.DisplayMember = "nameCounty";
            cmbPfCounty.ValueMember = "countyID";

            con.CloseConnection(); 


        }

        private void cmbPfCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;

            try
            {
                int.TryParse(cmbPfCounty.SelectedValue.ToString(), out value);
                dataAdpt = new SqlDataAdapter("select * from Municipality where countyID='" + value + "'",
                    con.ConnectionOpening());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbPfMunicipality.DataSource = dt;
                cmbPfMunicipality.DisplayMember = "nameMunicipality";
                cmbPfMunicipality.ValueMember = "municipalityID";
            }
            catch(Exception)
            {

            }
            con.CloseConnection();
        }

        private void cmbPfMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;

            try
            {
                int.TryParse(cmbPfMunicipality.SelectedValue.ToString(), out value);
                dataAdpt = new SqlDataAdapter("select * from Town where municipalityID='" + value + "'",
                    con.ConnectionOpening());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbPfTown.DataSource = dt;
                cmbPfTown.DisplayMember = "nameTown";
                cmbPfTown.ValueMember = "TownID";
            }
            catch (Exception)
            {

            }
            con.CloseConnection();
        }

        private void Experience()
        {
            dataAdpt = new SqlDataAdapter("select * from Experience", con.ConnectionOpening());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbPfExperience.DataSource = dt;
            cmbPfExperience.DisplayMember = "experience";
            cmbPfExperience.ValueMember = "experienceID";

            con.CloseConnection();
        }

        private void btn_pf_Save_Click(object sender, EventArgs e)
        {
            int experienceID = Convert.ToInt32(cmbPfExperience.SelectedValue);
            int countyID = Convert.ToInt32(cmbPfCounty.SelectedValue);
            int municipalityID = Convert.ToInt32(cmbPfCounty.SelectedValue);
            int TownID = Convert.ToInt32(cmbPfTown.SelectedValue);

            try
            {
                string sex = "Female";

                if (rdPfM.Checked)
                {
                    sex = "Male";
                }

                if (txtPfName.Text != "" && txtPfFirstName.Text != "" && txtPfAddress.Text != "" && txtPfPhone.Text != "" && txtPfEmail.Text != ""
                    && cmbPfCounty.Text != "" && cmbPfMunicipality.Text != "" && cmbPfTown.Text != "" && cmbPfExperience.Text != "")
                {
                    cmd = new SqlCommand("insert into Professors values('" + txtPfName.Text + "', '" + txtPfFirstName.Text + "', '" + txtPfAddress.Text + "'," +
                        " '" + txtPfPhone.Text + "', '" + txtPfEmail.Text + "', '" + sex + "', '" + dtPfDateofBirth.Text + "', '" + experienceID + "', '" + countyID + "', '" 
                        + municipalityID + "', '" + TownID + "')", con.ConnectionOpening());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("The data has been saved", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_pf_Add_Click(object sender, EventArgs e)
        {
            txtPfName.Clear();
            txtPfFirstName.Clear();
            txtPfAddress.Clear();
            txtPfPhone.Clear();
            txtPfEmail.Clear();
            cmbPfCounty.Text = "";
            cmbPfMunicipality.Text = "";
            cmbPfTown.Text = "";
            cmbPfExperience.Text = "";
        }

        private void btn_pf_Data_Click(object sender, EventArgs e)
        {
            FrmDisplayProfessorsData prof = new FrmDisplayProfessorsData();
            prof.Show();
            Hide();
        }

        private void btn_pf_Update_Click(object sender, EventArgs e)
        {

            string sex = "";
            if (rdPfM.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "Fenale";
            }

            try
            {
                //string DB = dtPfDateofBirth.Value.ToString("dd-MM-yyyy");
                int countyID = Convert.ToInt32(cmbPfCounty.SelectedValue);
                int municipalityID = Convert.ToInt32(cmbPfMunicipality.SelectedValue);
                int TownID = Convert.ToInt32(cmbPfTown.SelectedValue);
                int experienceID = Convert.ToInt32(cmbPfExperience.SelectedValue);

                if (txtPfName.Text != "" && txtPfFirstName.Text != "" && txtPfAddress.Text != "" && txtPfPhone.Text != "" && txtPfEmail.Text != ""
                    && cmbPfCounty.Text != "" && cmbPfMunicipality.Text != "" && cmbPfTown.Text != "")
                {
                    cmd = new SqlCommand("update Professors set name='" + txtPfName.Text +
                        "', firstname='" + txtPfFirstName.Text + "', address='" + txtPfAddress.Text + "', phone='" + txtPfPhone.Text +
                        "', email='" + txtPfEmail.Text + "', sex='"+ sex + "', dateofbirth= '" + dtPfDateofBirth.Text + "', experienceID='" + experienceID +
                        "', countyID='" + countyID + "', municipalityID='" + municipalityID +
                        "', TownID='" + TownID + "'where professorID='" + FrmDisplayProfessorsData.professorID + "'", con.ConnectionOpening());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("The data was successfully updated!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill in the blanks");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseConnection();
        }

        private void btn_pf_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from Professors where professorID='" + FrmDisplayProfessorsData.professorID + "'", con.ConnectionOpening());
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

