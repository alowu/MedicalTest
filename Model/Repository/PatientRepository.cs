using Model.Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model
{
	public class PatientRepository : IRepository<Patient>
	{
		private ConnectionDB DB = new ConnectionDB();
		private SqlDataReader dataReader = null;
		private SqlCommand sqlCommand = null;
		public Task<Patient> Create(Patient item)
		{
			throw new NotImplementedException();
		}

		public Task<Patient> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Patient>> GetAll()
		{
			List<Patient> patients = new List<Patient>();

			sqlCommand = new SqlCommand("SELECT * FROM [Patients]", DB._getConnection());

			try
			{
				dataReader = await sqlCommand.ExecuteReaderAsync();
				while (await dataReader.ReadAsync())
				{
					int id = (int)dataReader["id"];
					string firstName = (string)dataReader["firstName"];
					string middleName = (string)dataReader["middleName"];
					string lastName = (string)dataReader["lastName"];
					int age = (int)dataReader["age"];
					Sex sex = (Sex)dataReader["sex"];
					bool hasExam = (bool)dataReader["hasExam"];

					Patient patient = new Patient(id, firstName, middleName, lastName, age, sex, hasExam);

					patients.Add(patient);
				}
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Can't select from Patients!\n" + ex.ToString());
			}
			finally
			{
				if (dataReader != null)
				{
					dataReader.Close();
				}
			}
			return patients;
		}

		public Task<Patient> Update(Patient item)
		{
			throw new NotImplementedException();
		}
	}
}
