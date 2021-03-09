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
    public partial class ProfReports : Form
    {
        public ProfReports()
        {
            InitializeComponent();
        }

        private void ProfReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SchoolSystemDataSet.Professors' table. You can move, or remove it, as needed.
            this.ProfessorsTableAdapter.Fill(this.SchoolSystemDataSet.Professors);

            this.reportViewer1.RefreshReport();
        }
    }
}
