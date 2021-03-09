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
    public partial class UserRegistration : MaterialSkin.Controls.MaterialForm
    {
        private User objUser = new User();
        private static int userID;

        public UserRegistration()
        {
            InitializeComponent();
        }

        private bool InputDataValidation()
        {
            const int minPasswordLength = 8;
            
            if(textNameUser.Text.Length == 0)
            {
                MessageBox.Show("Please enter the username", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textNameUser.Focus();

                return false;
            }

            if (textPasswowd.Text.Length == 0)
            {
                MessageBox.Show("Please enter the password", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textPasswowd.Focus();

                return false;
            }
            else
            {
                if (textPasswowd.Text.Length < minPasswordLength || LargeCharracters(textPasswowd.Text) < 1 ||
                    SmallCharacters(textPasswowd.Text) < 1 || CheckNumbers(textPasswowd.Text) < 1)
                {
                    MessageBox.Show("Please enter a valid password\n" +
                        "The password must contain 8 letters, at least one uppercase letter, one lowercase letter and at least one number.", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textPasswowd.Focus();
                    return false;
                }
            }
            if (textPosition.Text.Length == 0)
            {
                MessageBox.Show("Please enter the position", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textPosition.Focus();

                return false;
            }

            return true;
        }

        private int CheckNumbers(string password)
        {
            int numbers = 0;
            
            foreach(char ch in password)
            {
                if (char.IsNumber(ch))
                {
                    numbers++;
                }
            }
            return numbers;
        }

        private int SmallCharacters(string password)
        {
            int smallCharacters = 0;

            foreach (char ch in password)
            {
                if (char.IsLower(ch))
                {
                    smallCharacters++;
                }
            }
            return smallCharacters;
        }

        private int LargeCharracters(string password)
        {
            int largeCharacters = 0;

            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                {
                    largeCharacters++;
                }
            }
            return largeCharacters;
        }

        private void Clear()
        {
            textNameUser.Clear();
            textPasswowd.Clear();
            textConf.Clear();
            textPosition.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Clear();
            textNameUser.Focus();
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.UserData();

            if (InputDataValidation())
            {
                // MessageBox.Show("The data were successfully validated");

                objUser.Add();
            }
            // TODO: This line of code loads data into the 'schoolSystemDataSet3.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.schoolSystemDataSet3.Users);
            Clear();
        }

        private void UserData()
        {
            objUser.NameUser = textNameUser.Text;
            objUser.Password = textPasswowd.Text;
            objUser.Position = textPosition.Text;

          /*  MessageBox.Show($"Name User: {objUser.NameUser}.\n" +
                $"Password:{objUser.Password}.\n" +
                $"Position:{objUser.Position}");*/

        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolSystemDataSet3.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.schoolSystemDataSet3.Users);

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = dataGridView1.CurrentRow.Cells;
            userID = Convert.ToInt32(cells[0].Value.ToString());
            textNameUser.Text = cells[1].Value.ToString();
            textPasswowd.Text = cells[2].Value.ToString();
            textConf.Text = cells[2].Value.ToString();
            textPosition.Text = cells[3].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.UserData();

            if (InputDataValidation())
            {
                objUser.Update(userID);
            }
            // TODO: This line of code loads data into the 'schoolSystemDataSet3.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.schoolSystemDataSet3.Users);
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.UserData();

            if (InputDataValidation())
            {
                objUser.Delete(userID);
            }
            // TODO: This line of code loads data into the 'schoolSystemDataSet3.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.schoolSystemDataSet3.Users);
            Clear();
        }
    }
}
