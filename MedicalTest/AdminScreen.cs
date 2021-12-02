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
	public partial class AdminScreen : Form
	{
		SqlConnection sqlConnection;
		public AdminScreen()
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

		private async void AdminScreen_Load(object sender, EventArgs e)
		{
			string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\MedicalTest\MedicalTest\Database.mdf;Integrated Security=True";

			sqlConnection = new SqlConnection(connectionString);

			await sqlConnection.OpenAsync();

			SqlDataReader sqlDataReader = null;

			SqlCommand command = new SqlCommand("SELECT * FROM [Patients]", sqlConnection);

			listBox1.Items.Add("ID".PadRight(15) + 
				"Surname".PadRight(15) + 
				"Name".PadRight(15) + 
				"Dad name".PadRight(15) +
				"Sex".PadRight(15) + 
				"Age".PadRight(15));

			try
			{
				sqlDataReader = await command.ExecuteReaderAsync();

				while (await sqlDataReader.ReadAsync())
				{
					listBox1.Items.Add(Convert.ToString(sqlDataReader["Id"]).PadRight(15) +
									   Convert.ToString(sqlDataReader["name"]).PadRight(15) +
									   Convert.ToString(sqlDataReader["surname"]).PadRight(15) + 
									   Convert.ToString(sqlDataReader["dad_name"]).PadRight(15) +
									   Convert.ToString(sqlDataReader["sex"]).PadRight(15) +
									   Convert.ToString(sqlDataReader["age"]).PadRight(15));
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
