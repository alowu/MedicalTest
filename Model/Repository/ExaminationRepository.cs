using Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class ExaminationRepository : IRepository<Examination>
	{
		private ConnectionDB DB = new ConnectionDB();
		private SqlDataReader dataReader = null;
		private SqlCommand sqlCommand = null;

		public ExaminationRepository()
		{
			DB.ConnectDB();
		}
		public bool Create(Examination item)
		{
			bool result = false;
			try
			{
				sqlCommand = new SqlCommand("INSERT INTO [Examinations] (patientId, physicalActive, timeActive, statePresure, stateTemperature, stateHumidity, stateResist, stateChss) VALUES (@id, @active, @time, @presure_state, @temp_state, @humidity_state, @resist_state, @css_state)", DB._getConnection());

				sqlCommand.Parameters.AddWithValue("id", item.patientId);
				sqlCommand.Parameters.AddWithValue("active", item.physicalActive);
				sqlCommand.Parameters.AddWithValue("time", item.timeActive);
				sqlCommand.Parameters.AddWithValue("presure_state", item.statePresure);
				sqlCommand.Parameters.AddWithValue("temp_state", item.stateTemperature);
				sqlCommand.Parameters.AddWithValue("humidity_state", item.stateHumidity);
				sqlCommand.Parameters.AddWithValue("resist_state", item.stateResist);
				sqlCommand.Parameters.AddWithValue("css_state", item.stateChss);

				sqlCommand.ExecuteNonQuery();

				result = true;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Can't INSERT INTO Examinations!\n" + ex.ToString());
			}

			try
			{
				sqlCommand = new SqlCommand("UPDATE [Patients] SET [hasExam]=@hasExam WHERE [id]=@id", DB._getConnection());

				sqlCommand.Parameters.AddWithValue("id", item.patientId);
				sqlCommand.Parameters.AddWithValue("hasExam", 1);

				sqlCommand.ExecuteNonQuery();

				result = true;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Can't UPDATE Examination INTO PATIENTS!\n" + ex.ToString());
			}

			return result;
		}

		public bool Delete(int id)
		{
			bool result = false;

			try
			{
				sqlCommand = new SqlCommand("DELETE FROM [Examinations] WHERE [patientId]=@id", DB._getConnection());

				sqlCommand.Parameters.AddWithValue("id", id);

				sqlCommand.ExecuteNonQuery();

				result = true;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Can't DELETE Examination!\n" + ex.ToString());
			}

			return result;
		}

		public bool Update(Examination item)
		{
			throw new NotImplementedException();
		}

		public List<Examination> GetAll()
		{
			throw new NotImplementedException();
		}

		public Examination FindById(int Id)
		{
			throw new NotImplementedException();
		}

		public Examination GetT(int Id)
		{
			Examination examination = null;

			string command = "SELECT * FROM [Examinations] WHERE patientId=";
			command += Id;

			sqlCommand = new SqlCommand(command, DB._getConnection());

			try
			{
				dataReader = sqlCommand.ExecuteReader();
				dataReader.Read();

				int id = (int)dataReader["patientId"];
				TypePhysicalActive physicalActive = (TypePhysicalActive)dataReader["physicalActive"];
				int time = (int)dataReader["timeActive"];
				bool p = (bool)dataReader["statePresure"];
				bool t = (bool)dataReader["stateTemperature"];
				bool h = (bool)dataReader["stateHumidity"];
				bool r = (bool)dataReader["stateResist"];
				bool c = (bool)dataReader["stateChss"];

				examination = new Examination(id, physicalActive, time, p, t, h, r, c);

			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Can't GET_T Examinations!\n" + ex.ToString());
			}
			finally
			{
				if (dataReader != null)
				{
					dataReader.Close();
				}
			}
			return examination;
		}
	}
}
