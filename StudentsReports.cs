using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemScolarDeInregistrare_Proof_Elev_
{
    public partial class StudentsReports : Form
    {
        public StudentsReports()
        {
            InitializeComponent();
        }

        private void StudentsReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SchoolSystemDataSet1.StudentsReports' table. You can move, or remove it, as needed.
            this.StudentsReportsTableAdapter.Fill(this.SchoolSystemDataSet1.StudentsReports);

            this.reportViewer1.RefreshReport();
        }
    }
}
