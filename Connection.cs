using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SchoolRegistrationSystem
{
    class Connection
    {
        SqlConnection connection; 

        public Connection()
        {
            connection = new SqlConnection("Data Source=DESKTOP-8BU7795; Initial Catalog=SchoolSystem; Integrated Security =True");           
        
        }

        public SqlCommand CreateCommand()
        {        
               return connection.CreateCommand();

        }

        public SqlConnection ConnectionOpening()
        {
            try
            {
                connection.Open();
            }
            catch(Exception)
            {

            }
            return connection;
        }


        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {

            }
            
        }
    }
}
