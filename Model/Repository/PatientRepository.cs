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

		public PatientRepository()
		{
			DB.ConnectDB();
		}

		public bool Create(Patient item)
		{
			bool result = false;
			try
			{
				sqlCommand = new SqlCommand("INSERT INTO [Patients] (firstName, middleName, lastName, age, sex) VALUES (@firstName, @middleName, @lastName, @age, @sex)", DB._getConnection());

				sqlCommand.Parameters.AddWithValue("firstName", item.firstName);
				sqlCommand.Parameters.AddWithValue("middleName", item.middleName);
				sqlCommand.Parameters.AddWithValue("lastName", item.lastName);
				sqlCommand.Parameters.AddWithValue("age", item.age);
				sqlCommand.Parameters.AddWithValue("sex", item.sex);

				sqlCommand.ExecuteNonQuery();

				result = true;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Can't INSERT INTO Patients!\n" + ex.ToString());
			}

			return result;
		}

		public bool Delete(int id)
		{
			bool result = false;

			try
			{
				sqlCommand = new SqlCommand("DELETE FROM [Patients] WHERE [id]=@id", DB._getConnection());

				sqlCommand.Parameters.AddWithValue("id", id);

				sqlCommand.ExecuteNonQuery();

				result = true;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Can't DELETE Patients!\n" + ex.ToString());
			}

			return result;
		}

		public bool Update(Patient item)
		{
			bool result = false;

			try
			{
				sqlCommand = new SqlCommand("UPDATE [Patients] SET [firstName]=@firstName, [middleName]=@middleName, [lastName]=@lastName, [age]=@age, [sex]=@sex WHERE [id]=@id", DB._getConnection());

				sqlCommand.Parameters.AddWithValue("id", item.id);
				sqlCommand.Parameters.AddWithValue("firstName", item.firstName);
				sqlCommand.Parameters.AddWithValue("middleName", item.middleName);
				sqlCommand.Parameters.AddWithValue("lastName", item.lastName);
				sqlCommand.Parameters.AddWithValue("age", item.age);
				sqlCommand.Parameters.AddWithValue("sex", item.sex);

				sqlCommand.ExecuteNonQuery();

				result = true;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Can't UPDATE Patients!\n" + ex.ToString());
			}

			return result;
		}

		public List<Patient> GetAll()
		{
			List<Patient> patients = new List<Patient>();

			sqlCommand = new SqlCommand("SELECT * FROM [Patients]", DB._getConnection());

			try
			{
				dataReader = sqlCommand.ExecuteReader();
				while (dataReader.Read())
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
				Console.Error.WriteLine("Can't SELECT FROM Patients!\n" + ex.ToString());
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

		public Patient FindById(int Id)
		{
			Patient patient = null;
			string body = "SELECT id FROM[Patients] WHERE id =";
			body += Id;
			sqlCommand = new SqlCommand(body, DB._getConnection());
			try
			{
				dataReader = sqlCommand.ExecuteReader();
				dataReader.Read();

				int id = (int)dataReader["id"];
				/*string firstName = (string)dataReader["firstName"];
				string middleName = (string)dataReader["middleName"];
				string lastName = (string)dataReader["lastName"];
				int age = (int)dataReader["age"];
				Sex sex = (Sex)dataReader["sex"];
				bool hasExam = (bool)dataReader["hasExam"];*/

				patient = new Patient(id);//, firstName, middleName, lastName, age, sex, hasExam);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Can't FIND Patient!\n" + ex.ToString());
			}
			finally
			{
				if (dataReader != null)
				{
					dataReader.Close();
				}
			}

			return patient;
		}
	}
}
