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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        private User objUser;
        public Login()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UserData()
        {
            objUser.NameUser = textBoxUser.Text;
            objUser.Password = textBoxPassword.Text;
        }

        private void ClearControls()
        {
            textBoxUser.Clear();
            textBoxPassword.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            objUser = new User();
            UserData();
            try
            {
                FrmSystem objSchool = new FrmSystem();
                if (objUser.UserValid())
                {
                    this.Hide();
                    objSchool.Show();
                    objSchool.btnAdmin.Enabled = false;
                }
                else if (objUser.AdminValid())
                {
                    this.Hide();
                    objSchool.Show();
                    objSchool.btnAdmin.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Username/Password Unauthorized!", "Username/Admin Unauthorized!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
