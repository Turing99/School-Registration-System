using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolRegistrationSystem;

namespace SistemScolarDeInregistrare_Proof_Elev_
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        ProfReports objProfRep = null;
        private void ProfessorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(objProfRep == null)
            { 
            objProfRep = new ProfReports();
            objProfRep.MdiParent = this;
                objProfRep.FormClosed += ObjProfRep_FormClosed;
            objProfRep.Show();
            }
            else
            {
                objProfRep.Activate();
            }

        }

        private void ObjProfRep_FormClosed(object sender, FormClosedEventArgs e)
        {
            objProfRep = null;
        }

        StudentsReports objStudRep = null;
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(objStudRep == null)
            { 
            objStudRep = new StudentsReports();
            objStudRep.MdiParent = this;
                objStudRep.FormClosed += ObjStudRep_FormClosed;
            objStudRep.Show();
            }
           else
            {
                objStudRep.Activate();
            }
        }

        private void ObjStudRep_FormClosed(object sender, FormClosedEventArgs e)
        {
            objStudRep = null;
        }

        FeeReports objFeeRep = null;
        private void feeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(objFeeRep == null)
            {
            objFeeRep = new FeeReports();
            objFeeRep.MdiParent = this;
                objFeeRep.FormClosed += ObjFeeRep_FormClosed;
            objFeeRep.Show();
            }
            else
            {
                objFeeRep.Activate();
            }
        }

        private void ObjFeeRep_FormClosed(object sender, FormClosedEventArgs e)
        {
            objFeeRep = null;
        }

        private void professorsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisplayProfessorsData objProfData = new FrmDisplayProfessorsData();
            objProfData.Show();
            Hide();
        }

        private void studentsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisplayStudentData objStudData = new FrmDisplayStudentData();
            objStudData.Show();
            Hide();
        }

        private void feeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDisplayFeesData objFeeData = new FrmDisplayFeesData();
            objFeeData.Show();
            Hide();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form allForms in this.MdiChildren)
            {
                allForms.Close();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
