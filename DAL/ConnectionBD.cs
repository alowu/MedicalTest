using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionBD
    {
        private SqlConnection sqlConnection = null;
        public ConnectionBD()
        {
        }

        public async void ConnectDB()
		{
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MedicalTestDB"].ConnectionString);
            await sqlConnection.OpenAsync();
        }

        public void CloseDB()
        {
            
        }
    }
}
