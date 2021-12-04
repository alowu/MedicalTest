using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConnectionDB
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\MedicalTest\\Model\\MedicalTestDB.mdf;Integrated Security=True";

        //private PatientRepository patientRepository;
        //private ExaminationRepository examinationRepository;
        private SqlConnection sqlConnection = new SqlConnection(connectionString);

        public ConnectionDB()
        {
        }

        public SqlConnection _getConnection()
		{
            return sqlConnection;
		}

        public void ConnectDB()
        {
			try
			{
                sqlConnection.Open();
            }
			catch (Exception ex)
			{
                Console.Error.WriteLine("!WARNING!\nCan not establish connection!\n" + ex.ToString());
			}
            if (sqlConnection.State == ConnectionState.Open)
            {
                Console.WriteLine("Connection is good");
            }
        }

        public void CloseDB()
        {
            sqlConnection.Close();
        }
    }
}
