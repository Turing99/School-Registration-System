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
    public partial class FeeReports : Form
    {
        public FeeReports()
        {
            InitializeComponent();
        }

        private void FeeReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SchoolSystemDataSet2.FeeReports' table. You can move, or remove it, as needed.
            this.FeeReportsTableAdapter.Fill(this.SchoolSystemDataSet2.FeeReports);

            this.reportViewer1.RefreshReport();
        }
    }
}
