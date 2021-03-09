using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemScolarDeInregistrare_Proof_Elev_
{
   public class User
    {
        SqlDataAdapter adapter;
        DataSet ds; 

        private string nameUser;
        private string password;
        private string position;

        public User()
        {

        }

        public string NameUser {
            get { return nameUser; }
            set { nameUser = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }


        string con = ConfigurationManager.ConnectionStrings["SchoolSystemConnectionString"].ConnectionString;
        public void Add()
        {

            SqlConnection objCon = new SqlConnection(con);

            try { 
            SqlCommand objCom = new SqlCommand("UsersCheck", objCon);
            objCom.CommandType = CommandType.StoredProcedure;
            objCom.Parameters.AddWithValue("@NameUser", NameUser);
            objCom.Parameters.AddWithValue("@Password", Password);
                objCon.Open();
                objCom.ExecuteNonQuery();

                adapter = new SqlDataAdapter(objCom);
                ds = new DataSet();
                adapter.Fill(ds);

                if(ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Username/Password exists in the database");
                }
                else
                {
                    SqlCommand objCom2 = new SqlCommand("AddUser", objCon);
                    objCom2.CommandType = CommandType.StoredProcedure;
                    objCom2.Parameters.AddWithValue("@NameUser", NameUser);
                    objCom2.Parameters.AddWithValue("@Password", Password);
                    objCom2.Parameters.AddWithValue("@Position", Position);
                    objCom2.ExecuteNonQuery();

                    MessageBox.Show("User added successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            

            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message, "Sql values insertion error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally
            {
                objCon.Close();
            }
            MessageBox.Show("User added successfully. ", "Success", MessageBoxButtons.OK);
        }

        public void Update(int id)
        {

            SqlConnection objCon = new SqlConnection(con);

            try
            {
                SqlCommand objCom = new SqlCommand("UsersCheck", objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@NameUser", NameUser);
                objCom.Parameters.AddWithValue("@Password", Password);
                objCon.Open();
                objCom.ExecuteNonQuery();

                adapter = new SqlDataAdapter(objCom);
                ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Username/Password exists in the database");
                }
                else
                {
                    SqlCommand objCom2 = new SqlCommand("UsersUpdate", objCon);
                    objCom2.CommandType = CommandType.StoredProcedure;
                    objCom2.Parameters.AddWithValue("@UserID", id);
                    objCom2.Parameters.AddWithValue("@NameUser", NameUser);
                    objCom2.Parameters.AddWithValue("@Password", Password);
                    objCom2.Parameters.AddWithValue("@Position", Position);
                    objCom2.ExecuteNonQuery();

                    MessageBox.Show("User uptated successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sql values uptade error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objCon.Close();
            }
            MessageBox.Show("User added successfully. ", "Success", MessageBoxButtons.OK);
        }
        public void Delete(int id)
        {

            SqlConnection objCon = new SqlConnection(con);

            try
            {
                objCon.Open();

                    SqlCommand objCom2 = new SqlCommand("DeleteUser", objCon);
                    objCom2.CommandType = CommandType.StoredProcedure;
                    objCom2.Parameters.AddWithValue("@UserID", id);
                    objCom2.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sql values delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objCon.Close();
            }
            MessageBox.Show("User deleted successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool UserValid()
        {
            bool isUserValid = false;

            SqlConnection objCon = new SqlConnection(con);

          
                SqlCommand objCom = new SqlCommand("UserValid", objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@NameUser", NameUser);
                objCom.Parameters.AddWithValue("@Password", Password);

                try
                {
                    objCon.Open();
                    isUserValid = (bool)objCom.ExecuteScalar();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Unauthorized user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objCon.Close();
                }
                return isUserValid;
            }

        public bool AdminValid()
        {
            bool isAdminValid = false;

            SqlConnection objCon = new SqlConnection(con);

                SqlCommand objCom = new SqlCommand("AdminValid", objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@Admin", nameUser);
                objCom.Parameters.AddWithValue("@Password", Password);

                try
                {
                    objCon.Open();
                    isAdminValid = (bool)objCom.ExecuteScalar();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Unauthorized Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objCon.Close();
                }
                return isAdminValid;
            }
            


    }
}
