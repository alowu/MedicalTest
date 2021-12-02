using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedicalTest
{
	public partial class DoctorScreen : Form
	{
		SqlConnection sqlConnection;
		public DoctorScreen()
		{
			InitializeComponent();
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
			{
				sqlConnection.Close();
			}
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TestScreen testScreen = new TestScreen();
			testScreen.ShowDialog();
		}

		private async void DoctorScreen_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Patients". При необходимости она может быть перемещена или удалена.
			this.patientsTableAdapter.Fill(this.databaseDataSet.Patients);
			string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\MedicalTest\MedicalTest\Database.mdf;Integrated Security=True";

			sqlConnection = new SqlConnection(connectionString);

			await sqlConnection.OpenAsync();

			SqlDataReader sqlDataReader = null;

			SqlCommand command = new SqlCommand("SELECT * FROM [Patients]", sqlConnection);

			try
			{
				sqlDataReader = await command.ExecuteReaderAsync();

				while (await sqlDataReader.ReadAsync())
				{
					
					listBox1.Items.Add(Convert.ToString(sqlDataReader["Id"]) + " " + Convert.ToString(sqlDataReader["name"]) + " " +
									   Convert.ToString(sqlDataReader["surname"]) + " " + Convert.ToString(sqlDataReader["dad_name"]) + " " +
									   Convert.ToString(sqlDataReader["sex"]) + " " + Convert.ToString(sqlDataReader["age"]));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (sqlDataReader != null)
				{
					sqlDataReader.Close();
				}

			}
		}
	}
}
