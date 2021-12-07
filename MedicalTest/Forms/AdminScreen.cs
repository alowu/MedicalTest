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
using Presenter.Presenters;
using System.Collections;
using Model.Entity;

namespace MedicalTest
{
	public partial class AdminScreen : Form
	{
		AdminPresenter presenter = new AdminPresenter();
		public AdminScreen()
		{
			InitializeComponent();
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AdminScreen_Load(object sender, EventArgs e)
		{
			List<Patient> patients = new List<Patient>();
			patients = presenter.ShowAdmin();
			foreach (Patient patient in patients)
			{
				listBox1.Items.Add(patient.ToString());
			}
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			if (label_status_add.Visible)
			{
				label_status_add.Visible = false;
			}
			string firstName = textBox_surname.Text;
			string middleName = textBox_name.Text;
			string lastName = textBox_dad_name.Text;
			int age = (int)numericUpDown_age.Value;
			Sex sex;
			if (radioButton_male.Checked)
			{
				sex = Sex.Male;
			}
			else if (radioButton_female.Checked)
			{
				sex = Sex.Female;
			}
			else
			{
				sex = Sex.Error;
			}

			Patient patient = new Patient(firstName, middleName, lastName, age, sex);

			if (presenter.Add(patient))
			{
				label_status_add.Text = "Пациент добавлен!";
				label_status_add.Visible = true;
				label_status_add.ForeColor = Color.Green;

				textBox_surname.Text = string.Empty;
				textBox_name.Text = string.Empty;
				textBox_dad_name.Text = string.Empty;
				numericUpDown_age.Value = 18;
			}
			else
			{
				label_status_add.Text = "Неправильно введены данные";
				label_status_add.Visible = true;
				label_status_add.ForeColor = Color.Red;
			}
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			AdminScreen_Load(sender, e);
		}

		private void button_change_Click(object sender, EventArgs e)
		{
			int id = int.Parse(textBox_id_change.Text);
			string firstName = textBox_surname_change.Text;
			string middleName = textBox_name_change.Text;
			string lastName = textBox_dad_name_change.Text;
			int age = (int)numericUpDown_age_change.Value;
			Sex sex;
			if (radioButton_male_change.Checked)
			{
				sex = Sex.Male;
			}
			else if (radioButton_female_change.Checked)
			{
				sex = Sex.Female;
			}
			else
			{
				sex = Sex.Error;
			}

			Patient patient = new Patient(id, firstName, middleName, lastName, age, sex);

			if (presenter.Udpate(patient))
			{
				label_update_status.Text = "Пациент изменен!";
				label_update_status.Visible = true;
				label_update_status.ForeColor = Color.Green;
			}
			else
			{
				label_update_status.Text = "Неправильно введены данные";
				label_update_status.Visible = true;
				label_update_status.ForeColor = Color.Red;
			}
		}

		private void button_del_Click(object sender, EventArgs e)
		{
			int id = int.Parse(textBox_id_del.Text);

			Patient patient = new Patient(id);

			if (presenter.Delete(patient))
			{
				label_delete.Text = "Пациент удален!";
				label_delete.Visible = true;
				label_delete.ForeColor = Color.Green;
			}
			else
			{
				label_delete.Text = "Пациент не найден";
				label_delete.Visible = true;
				label_delete.ForeColor = Color.Red;
			}
		}

		private void button_view_del_Click(object sender, EventArgs e)
		{
			int id = int.Parse(textBox_id_del.Text);

			Patient patient = presenter.GetPatient(id);

			if (patient == null)
			{
				label_delete.Text = "Пациент не найден";
				label_delete.Visible = true;
				label_delete.ForeColor = Color.Red;
			}
			else
			{
				label_delete.Text = "Пациент найден!";
				label_delete.Visible = true;
				label_delete.ForeColor = Color.Indigo;

				label_familia.Text = patient.firstName;
				label_name.Text = patient.middleName;
				label_dad.Text = patient.lastName;
				label_sex.Text = patient.sex.ToString();
				label_age.Text = patient.age.ToString();
			}
		}

		private void button_add_test_Click(object sender, EventArgs e)
		{
			label_test_pat_status.Visible = false;

			int id = int.Parse(textBox_id_nazn.Text);

			Patient patient = presenter.GetPatient(id);

			if (patient == null)
			{
				label_test_pat_status.Text = "Пациент не найден";
				label_test_pat_status.Visible = true;
				label_test_pat_status.ForeColor = Color.Red;
			}
			else
			{
				if (patient.hasExam)
				{
					label_test_pat_status.Text = "Обследование уже назначено!";
					label_test_pat_status.Visible = true;
					label_test_pat_status.ForeColor = Color.Indigo;
				}
				else
				{
					int time = (int)numericUpDown_time.Value;
					TypePhysicalActive active = 0;
					switch (comboBox_activity.SelectedIndex)
					{
						case 0:
							{
								active = TypePhysicalActive.Running;
								break;
							}
						case 1:
							{
								active = TypePhysicalActive.Walking;
								break;
							}
						case 2:
							{
								active = TypePhysicalActive.Swimming;
								break;
							}
						case 3:
							{
								active = TypePhysicalActive.Сycling;
								break;
							}
					}
					bool css_state = checkBox_css.Checked;
					bool humidity_state = checkBox_vlazh.Checked;
					bool temp_state = checkBox_temp.Checked;
					bool resist_state = checkBox_resist.Checked;
					bool presure_state = checkBox_blood_pr.Checked;

					Examination examination = new Examination(id, active, time, presure_state, temp_state, humidity_state, resist_state, css_state);

					if (presenter.Add(examination))
					{
						label_test_pat_status.Text = "Обследование назначено";
						label_test_pat_status.Visible = true;
						label_test_pat_status.ForeColor = Color.Green;
					}
					else
					{
						label_test_pat_status.Text = "Проверьте настройки обследования";
						label_test_pat_status.Visible = true;
						label_test_pat_status.ForeColor = Color.Red;
					}
				}		
			}
		}
	}
}
