using SistemScolarDeInregistrare_Proof_Elev_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolRegistrationSystem
{
    public partial class FrmSystem : MaterialSkin.Controls.MaterialForm
    {
        public FrmSystem()
        {
            InitializeComponent();
        }

        private void FrmSistem_Load(object sender, EventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            FrmStudents students = new FrmStudents();

            students.Show();

        }

        private void btnProfessors_Click(object sender, EventArgs e)
        {
            FrmProfessors pf = new FrmProfessors();
            pf.Show();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            FrmFee fee = new FrmFee();
            fee.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports objRep = new Reports();
            objRep.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            UserRegistration objRegistration = new UserRegistration();
            objRegistration.Show();
        }


    }
}
