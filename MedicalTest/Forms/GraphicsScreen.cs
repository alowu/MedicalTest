using Model.Entity;
using Presenter.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MedicalTest
{
	public partial class GraphicsScreen : Form
	{
		private Patient patient;
		private Examination examination;
		private PlotPresenter presenter = new PlotPresenter();

		public GraphicsScreen(Patient patient, Examination examination)
		{
			InitializeComponent();
			this.patient = patient;
			this.examination = examination;
		}

		private void button_exit_Click(object sender, EventArgs e)
		{
			presenter.Remove(patient.id);
			Close();
		}

		private void GraphicsScreen_Load(object sender, EventArgs e)
		{
			label_surname.Text = patient.firstName;
			label_name.Text = patient.middleName;
			label_dad_name.Text = patient.lastName;
			label_sex.Text = patient.sex.ToString();
			label_age.Text = patient.age.ToString();

			label_type.Text = examination.physicalActive.ToString();
			label_time.Text = examination.timeActive.ToString() + " min";

			int time = examination.timeActive;

			List<int> presure = presenter.GetValues(time, 'p');
			List<int> css = presenter.GetValues(time, 'c');
			List<int> humidity = presenter.GetValues(time, 'h');
			List<int> temp = presenter.GetValues(time, 't');
			List<int> resist = presenter.GetValues(time, 'r');

			chart_css.Series[0].Points.Clear();
			chart_humidity.Series[0].Points.Clear();
			chart_presure.Series[0].Points.Clear();
			chart_resist.Series[0].Points.Clear();
			chart_temp.Series[0].Points.Clear();

			for (int current = 1; current <= time; current++)
			{
				if (examination.stateChss)
				{
					chart_css.Series[0].Points.AddXY(current, css[current - 1]);
				}
				if (examination.stateHumidity)
				{
					chart_humidity.Series[0].Points.AddXY(current, humidity[current - 1]);
				}
				if (examination.statePresure)
				{
					chart_presure.Series[0].Points.AddXY(current, presure[current - 1]);
				}
				if (examination.stateResist)
				{
					chart_resist.Series[0].Points.AddXY(current, resist[current - 1]);
				}
				if (examination.stateTemperature)
				{
					chart_temp.Series[0].Points.AddXY(current, temp[current - 1]);
				}
			}
		}
	}
}
