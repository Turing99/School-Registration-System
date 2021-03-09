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

namespace SchoolRegistrationSystem
{
    public partial class FrmStudents : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Connection con = new Connection();
        public FrmStudents()
        {
            InitializeComponent();
            CountyDisplay();
            Class();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void CountyDisplay()
        {
            dataAdpt = new SqlDataAdapter("select * from County", con.ConnectionOpening());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbCounty.DataSource = dt;
            cmbCounty.DisplayMember = "nameCounty";
            cmbCounty.ValueMember = "countyID";

            con.CloseConnection();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;

            try
            {
                int.TryParse(cmbCounty.SelectedValue.ToString(), out value);
                dataAdpt = new SqlDataAdapter("select * from Municipality where countyID='" + value + "'", con.ConnectionOpening());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbMunicipality.DataSource = dt;
                cmbMunicipality.DisplayMember = "nameMunicipality";
                cmbMunicipality.ValueMember = "municipalityID";

            }
            catch (Exception)
            {

            }
            con.CloseConnection();
        }

        private void cmbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;

            try
            {
                int.TryParse(cmbMunicipality.SelectedValue.ToString(), out value);
                dataAdpt = new SqlDataAdapter("select * from Town where municipalityID='" + value + "'", con.ConnectionOpening());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbTown.DataSource = dt;
                cmbTown.DisplayMember = "nameTown";
                cmbTown.ValueMember = "TownID";
            }
            catch (Exception)
            {

            }
            con.CloseConnection();
        }

        public void Class()
        {
            try
            {
                dataAdpt = new SqlDataAdapter("select * from Class", con.ConnectionOpening());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbClass.DataSource = dt;
                cmbClass.DisplayMember = "nameClass";
                cmbClass.ValueMember = "classId";
            }
            catch (Exception)
            {

            }
            con.CloseConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int classID = Convert.ToInt32(cmbClass.SelectedValue);
            int countyID = Convert.ToInt32(cmbCounty.SelectedValue);
            int municipalityID = Convert.ToInt32(cmbMunicipality.SelectedValue);
            int TownID = Convert.ToInt32(cmbTown.SelectedValue);

            try
            {
                string sex = "Female";

                if (rdM.Checked)
                {
                    sex = "Male";
                }

                if (txtName.Text != "" && txtFirstName.Text != "" && txtAddress.Text != "" && txtPhone.Text != "" && txtEmail.Text != ""
                    && cmbCounty.Text != "" && cmbMunicipality.Text != "" && cmbTown.Text != "")
                {
                    cmd = new SqlCommand("insert into Students values('" + sex + "', '" + txtName.Text + "', '" + txtFirstName.Text + "', '" + txtAddress.Text + "'," +
                        " '" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + dtDateofBirth.Text + "', '" + dtDateofRegistration.Text + "'," +
                        "'" + classID + "', '" + countyID + "', '" + municipalityID + "', '" + TownID + "')", con.ConnectionOpening());

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbClass.Text = "";
            txtName.Clear();
            txtFirstName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cmbCounty.Text = "";
            cmbMunicipality.Text = "";
            cmbTown.Text = "";

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            FrmDisplayStudentData students = new FrmDisplayStudentData();
            students.Show();
            Hide();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (rdM.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }

            try
            {
                //string DB = dtDateofBirth.Value.ToString("dd-MM-yyyy");(la fiecare update imi prelua data curenta automat)
               // string DR = dtDateofRegistration.Value.ToString("dd-MM-yyyy");
                int countyID = Convert.ToInt32(cmbCounty.SelectedValue);
                int municipalityID = Convert.ToInt32(cmbMunicipality.SelectedValue);
                int TownID = Convert.ToInt32(cmbTown.SelectedValue);
                int classID = Convert.ToInt32(cmbClass.SelectedValue);

                if (txtName.Text != "" && txtFirstName.Text != "" && txtAddress.Text != "" && txtPhone.Text != "" && txtEmail.Text != ""
                    && cmbCounty.Text != "" && cmbMunicipality.Text != "" && cmbTown.Text != "")
                {
                    cmd = new SqlCommand("update students set sex='" + sex + "', name='" + txtName.Text + "'" +
                        ", firstname='" + txtFirstName.Text + "', address='" + txtAddress.Text + "', phone='" + txtPhone.Text + "'" +
                        ", email='" + txtEmail.Text + "', dateofbirth= '" + dtDateofBirth.Text + "', dateofregistration='" + dtDateofRegistration.Text + "'" +
                        ", classID='" + classID + "', countyID='" + countyID + "', municipalityID='" + municipalityID + "'" +
                        ", TownID='" + TownID + "'where StudentsID='" + FrmDisplayStudentData.studentID + "'", con.ConnectionOpening());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("The data was successfully updated!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill in the blanks");
                }      
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseConnection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from students where studentsID='" + FrmDisplayStudentData.studentID + "'", con.ConnectionOpening());
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
