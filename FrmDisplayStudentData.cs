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
using Microsoft.Office.Interop.Excel;
using SchoolRegistrationSystem;

namespace SchoolRegistrationSystem
{
    public partial class FrmDisplayStudentData : MaterialSkin.Controls.MaterialForm
    {
        Connection con = new Connection();
        SqlDataAdapter dataAdpt;
        System.Data.DataTable dt;
        SqlCommand cmd;

        public static int studentID;

        public FrmDisplayStudentData()
        {
            InitializeComponent();
        }

        private void FrmDisplayStudentData_Load(object sender, EventArgs e)
        {
            dataAdpt = new SqlDataAdapter("select Students.studentsID, Students.name, Students.firstName, Students.sex, " +
                "Students.address, Students.phone, Students.email,Students.dateOfBirth, Students.dateOfRegistration, " +
                "Class.nameClass, County.nameCounty, Municipality.nameMunicipality, Town.nameTown from Students " +
                "inner join Class on Students.classID = Class.classID inner join County on " +
                "Students.countyID = County.countyID inner join Municipality on " +
                "Students.municipalityID = Municipality.municipalityID inner join Town on " +
                "Students.TownID = Town.TownID",con.ConnectionOpening());
            dt = new System.Data.DataTable();
            dataAdpt.Fill(dt);
            DGridView.DataSource = dt;

            con.CloseConnection();
        }

        private void DGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmStudents uploadStudentData = new FrmStudents();
            studentID = Convert.ToInt32(DGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            uploadStudentData.txtName.Text = (DGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            uploadStudentData.txtFirstName.Text = (DGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            uploadStudentData.rdM.Checked = true;
            uploadStudentData.rdF.Checked = false;
            if (DGridView.Rows[e.RowIndex].Cells[3].Value.ToString() == "Female")
                {
                uploadStudentData.rdM.Checked = false;
                uploadStudentData.rdF.Checked = true;
            }
            uploadStudentData.txtAddress.Text = DGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            uploadStudentData.txtPhone.Text = DGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            uploadStudentData.txtEmail.Text = DGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            uploadStudentData.dtDateofBirth.CustomFormat = DGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            uploadStudentData.dtDateofRegistration.CustomFormat = DGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            uploadStudentData.cmbClass.Text = DGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            uploadStudentData.cmbCounty.Text = DGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
            uploadStudentData.cmbMunicipality.Text = DGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            uploadStudentData.cmbTown.Text = DGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
            uploadStudentData.Show();
            uploadStudentData.btnUpdate.Enabled = true;
            uploadStudentData.btnDelete.Enabled = true;

        }
        public void SearchgByName(string name)
        {
            string search = "select * from students where Name like '%" + name + "%'";
            cmd = new SqlCommand(search, con.ConnectionOpening());
            dataAdpt = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            dataAdpt.Fill(dt);
            DGridView.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchgByName(txtSearch.Text);
        }

        private void btn_Excel_Students_Click(object sender, EventArgs e)
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

                for(int i = 1; i < DGridView.Columns.Count + 1; i++)
                {
                    SpreadsheetEx.Cells[1, i] = DGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < DGridView.RowCount; i++)
                {
                    for (int j = 0; j < DGridView.ColumnCount; j++)
                    {
                        SpreadsheetEx.Cells[i + 2, j + 1] = DGridView.Rows[i].Cells[j].Value;
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
