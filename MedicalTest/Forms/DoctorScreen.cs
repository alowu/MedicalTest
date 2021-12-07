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
using Model.Entity;
using Presenter.Presenters;

namespace MedicalTest
{
	public partial class DoctorScreen : Form
	{
		DoctorPresenter presenter = new DoctorPresenter();
		public DoctorScreen()
		{
			InitializeComponent();
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button_start_exam_Click(object sender, EventArgs e)
		{
			TestScreen testScreen = new TestScreen();
			testScreen.ShowDialog();
		}

		private void DoctorScreen_Load(object sender, EventArgs e)
		{
			List<Patient> patients = new List<Patient>();
			patients = presenter.ShowDoctor();
			foreach (Patient patient in patients)
			{
				listBox1.Items.Add(patient.ToString());
			}
		}

		private void button_show_Click(object sender, EventArgs e)
		{
			label_first_name_st.Visible = false;
			label_first_name.Visible = false;
			label_middle_name_st.Visible = false;
			label_middle_name.Visible = false;
			label_last_name_st.Visible = false;
			label_last_name.Visible = false;
			label_sex_st.Visible = false;
			label_sex.Visible = false;
			label_age_st.Visible = false;
			label_age.Visible = false;
			label_activity_st.Visible = false;
			label_activity.Visible = false;
			label_time_st.Visible = false;
			label_time.Visible = false;

			int id = int.Parse(textBox_id.Text);

			Patient patient = presenter.GetPatient(id);

			if (patient == null)
			{
				label_common_state.Text = "Пациент не найден";
				label_common_state.Visible = true;
				label_common_state.ForeColor = Color.Red;
			}
			else
			{
				label_first_name_st.Visible = true;
				label_first_name.Text = patient.firstName;
				label_first_name.Visible = true;

				label_middle_name_st.Visible = true;
				label_middle_name.Text = patient.middleName;
				label_middle_name.Visible = true;


				label_last_name_st.Visible = true;
				label_last_name.Text = patient.lastName;
				label_last_name.Visible = true;

				label_sex_st.Visible = true;
				label_sex.Text = patient.sex.ToString();
				label_sex.Visible = true;

				label_age_st.Visible = true;
				label_age.Text = patient.age.ToString();
				label_age.Visible = true;

				if (!patient.hasExam)
				{
					label_common_state.Text = "У данного пациента нет обследований!!";
					label_common_state.Visible = true;
					label_common_state.ForeColor = Color.Indigo;
				}
				else
				{
					label_common_state.Visible = false;

					Examination examination = presenter.GetExamination(patient.id);

					label_activity_st.Visible = true;
					label_activity.Text = examination.physicalActive.ToString();
					label_activity.Visible = true;

					label_time_st.Visible = true;
					label_time.Text = examination.timeActive.ToString() + " mins";
					label_time.Visible = true;
				}
			}
		}
	}
}
