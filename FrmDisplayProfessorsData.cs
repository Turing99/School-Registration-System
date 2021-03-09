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
using Microsoft.Office.Interop.Excel;

namespace SistemScolarDeInregistrare_Proof_Elev_
{
    public partial class FrmDisplayProfessorsData : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        System.Data.DataTable dt;
        SqlCommand cmd;
        Connection con = new Connection();
        public static int professorID;

        public FrmDisplayProfessorsData()
        {
            InitializeComponent();
        }

        private void FrmDisplayProfessorsData_Load(object sender, EventArgs e)
        {
            try
            {
                dataAdpt = new SqlDataAdapter("select Professors.professorID, Professors.name, Professors.firstName, " +
                    "Professors.address, Professors.phone, Professors.email, Professors.dateOfBirth, Professors.sex, " +
                    "Experience.experience, County.nameCounty, Municipality.nameMunicipality, Town.nameTown from Professors " +
                    "inner join Experience on Experience.experienceID = Professors.experienceID " +
                    "inner join County on County.countyID = Professors.countyID " +
                    "inner join Municipality on Municipality.municipalityID = Professors.municipalityID " +
                    "inner join Town on Town.TownID = Professors.TownID", con.ConnectionOpening());
                dt = new System.Data.DataTable();
                dataAdpt.Fill(dt);
                DGridView_Pf.DataSource = dt;

                con.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGridView_Pf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            FrmProfessors uploadProfData = new FrmProfessors();
            professorID = Convert.ToInt32(DGridView_Pf.Rows[e.RowIndex].Cells[0].Value.ToString());

            uploadProfData.txtPfName.Text = (DGridView_Pf.Rows[e.RowIndex].Cells[1].Value.ToString());
            uploadProfData.txtPfFirstName.Text = (DGridView_Pf.Rows[e.RowIndex].Cells[2].Value.ToString());
            uploadProfData.txtPfAddress.Text = DGridView_Pf.Rows[e.RowIndex].Cells[3].Value.ToString();
            uploadProfData.txtPfPhone.Text = DGridView_Pf.Rows[e.RowIndex].Cells[4].Value.ToString();
            uploadProfData.txtPfEmail.Text = DGridView_Pf.Rows[e.RowIndex].Cells[5].Value.ToString();
            uploadProfData.dtPfDateofBirth.CustomFormat = DGridView_Pf.Rows[e.RowIndex].Cells[6].Value.ToString();

            uploadProfData.rdPfM.Checked = true;
            uploadProfData.rdPfF.Checked = false;
            if (DGridView_Pf.Rows[e.RowIndex].Cells[7].Value.ToString() == "Female")
            {
                uploadProfData.rdPfM.Checked = false;
                uploadProfData.rdPfF.Checked = true;
            }

            uploadProfData.cmbPfExperience.Text = DGridView_Pf.Rows[e.RowIndex].Cells[8].Value.ToString();
            uploadProfData.cmbPfCounty.Text = DGridView_Pf.Rows[e.RowIndex].Cells[9].Value.ToString();
            uploadProfData.cmbPfMunicipality.Text = DGridView_Pf.Rows[e.RowIndex].Cells[10].Value.ToString();
            uploadProfData.cmbPfTown.Text = DGridView_Pf.Rows[e.RowIndex].Cells[11].Value.ToString();
            uploadProfData.Show();
            uploadProfData.btn_pf_Update.Enabled = true;
            uploadProfData.btn_pf_Delete.Enabled = true;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SearchgByName(string name)
        {
            string search = "select * from Professors where Name like '%" + name + "%'";
            cmd = new SqlCommand(search, con.ConnectionOpening());
            dataAdpt = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            dataAdpt.Fill(dt);
            DGridView_Pf.DataSource = dt;
        }

        private void txtSearch_Pf_TextChanged(object sender, EventArgs e)
        {
            SearchgByName(txtSearch_Pf.Text);
        }

        private void btn_Excel_Professors_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelExport;
            Workbook ExcelRegister;
            Worksheet SpreadsheetEx;

            try
            {
                ExcelExport = new Microsoft.Office.Interop.Excel.Application();
                ExcelRegister = ExcelExport.Workbooks.Add(Type.Missing);
                SpreadsheetEx = null;

                SpreadsheetEx = ExcelRegister.Sheets["Sheet1"];
                SpreadsheetEx = ExcelRegister.ActiveSheet;
                SpreadsheetEx.Name = "DataStudents";

                ExcelExport.Visible = true;

                for (int i = 1; i < DGridView_Pf.Columns.Count + 1; i++)
                {
                    SpreadsheetEx.Cells[1, i] = DGridView_Pf.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < DGridView_Pf.RowCount; i++)
                {
                    for (int j = 0; j < DGridView_Pf.ColumnCount; j++)
                    {
                        SpreadsheetEx.Cells[i + 2, j + 1] = DGridView_Pf.Rows[i].Cells[j].Value;
                    }
                }
                ExcelExport.Columns.AutoFit();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
