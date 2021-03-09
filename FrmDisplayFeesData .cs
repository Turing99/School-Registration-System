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
    public partial class FrmDisplayFeesData : MaterialSkin.Controls.MaterialForm
    {
        Connection con = new Connection();
        SqlDataAdapter dataAdpt;
        System.Data.DataTable dt;
        SqlCommand cmd;
        public static int feeID;

        public FrmDisplayFeesData()
        {
            InitializeComponent();
        }

        private void FrmDisplayFeesData_Load(object sender, EventArgs e)
        {
            try
            {
                dataAdpt = new SqlDataAdapter("select Fee.feeID, Class.nameClass, Students.name, " +
                    "Students.firstName, Fee.dateOfAdmission, Month.month, Fee.sum from Fee " +
                    "inner join Class on Class.classID = Fee.classID " +
                    "inner join Students on Students.studentsID = Fee.nameID " +
                    "inner join Month on Month.monthID = Fee.monthKey", con.ConnectionOpening());
                dt = new System.Data.DataTable();
                dataAdpt.Fill(dt);
                DGridView_Fees.DataSource = dt;

                con.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGridView_Fees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmFee dtFee = new FrmFee();

            feeID = Convert.ToInt32(DGridView_Fees.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtFee.cmbFeeClass.Text = DGridView_Fees.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtFee.cmbFeeName.Text = DGridView_Fees.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtFee.cmbFeeFirstName.Text = DGridView_Fees.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtFee.cmbMonth.Text = DGridView_Fees.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtFee.dtDateOfAdmission.Text = DGridView_Fees.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtFee.txtSum.Text = DGridView_Fees.Rows[e.RowIndex].Cells[6].Value.ToString();

            dtFee.Show();

            dtFee.btn_fee_Update.Enabled = true;
            dtFee.btn_fee_Delete.Enabled = true;

        }

        private void txtSearch_Fee_TextChanged(object sender, EventArgs e)
        {
            SearchgByFirstName(txtSearch_Fee.Text);
        }

        public void SearchgByFirstName(string FirstName)
        {
            string search = "select Fee.feeID, Class.nameClass, Students.name, " +
                    "Students.firstName, Fee.dateOfAdmission, Month.month, Fee.sum from Fee " +
                    "inner join Class on Class.classID = Fee.classID " +
                    "inner join Students on Students.studentsID = Fee.nameID " +
                    "inner join Month on Month.monthID = Fee.monthKey where firstName like '%" + FirstName + "%'";
            cmd = new SqlCommand(search, con.ConnectionOpening());
            dataAdpt = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            dataAdpt.Fill(dt);
            DGridView_Fees.DataSource = dt;
        }

        private void btn_Excel_Fees_Click(object sender, EventArgs e)
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

                for (int i = 1; i < DGridView_Fees.Columns.Count + 1; i++)
                {
                    SpreadsheetEx.Cells[1, i] = DGridView_Fees.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < DGridView_Fees.RowCount; i++)
                {
                    for (int j = 0; j < DGridView_Fees.ColumnCount; j++)
                    {
                        SpreadsheetEx.Cells[i + 2, j + 1] = DGridView_Fees.Rows[i].Cells[j].Value;
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
