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
using System.Windows.Forms.DataVisualization.Charting;
using Timer = System.Windows.Forms.Timer;

namespace MedicalTest
{
	public partial class GraphicsScreen : Form
	{
		private Patient patient;
		private Examination examination;
		private PlotPresenter presenter = new PlotPresenter();
		private Timer timer = new Timer();
		private List<Chart> charts = new List<Chart>();
		private List<bool> state = new List<bool>();

		private void AddState()
		{ 
			state.Add(examination.statePresure);
			state.Add(examination.stateChss);
			state.Add(examination.stateTemperature);
			state.Add(examination.stateHumidity);
			state.Add(examination.stateResist);

		}

		private void AddCharts()
		{
			charts.Add(chart_presure);
			charts.Add(chart_css);
			charts.Add(chart_temp);
			charts.Add(chart_humidity);
			charts.Add(chart_resist);
		}

		private void HideUnactive()
		{
			int current = 125;
			int step = 500;
			for (int i = 0; i < 5; i++)
			{
				if (state[i])
				{
					charts[i].Visible = true;
					Point point = new Point(25, current);
					charts[i].Location = point;
					current += step;
				}
			}
		}

		public GraphicsScreen(Patient patient, Examination examination)
		{
			InitializeComponent();
			this.patient = patient;
			this.examination = examination;
			AddState();
			AddCharts();
			HideUnactive();
		}

		private void button_exit_Click(object sender, EventArgs e)
		{
			presenter.Remove(patient.id);
			Close();
		}
		
		private void GraphicsScreen_Load(object sender, EventArgs e)
		{
			label_date.Text = presenter.GetDate();

			label_surname.Text = patient.firstName;
			label_name.Text = patient.middleName;
			label_dad_name.Text = patient.lastName;
			label_sex.Text = patient.sex.ToString();
			label_age.Text = patient.age.ToString();

			label_type.Text = examination.physicalActive.ToString();
			label_time.Text = examination.timeActive.ToString() + " min";

			chart_css.Series[0].Points.Clear();
			chart_humidity.Series[0].Points.Clear();
			chart_presure.Series[0].Points.Clear();
			chart_resist.Series[0].Points.Clear();
			chart_temp.Series[0].Points.Clear();

			timer.Interval = 500;
			timer.Start();
			timer.Tick += Timer_tick;	
		}
		private bool isFinish = false;
		private int current = 1;
		private void Timer_tick(object sender, EventArgs e)
		{
			int time = examination.timeActive;
			List<int> presure = presenter.GetValues(time, 'p');
			List<int> css = presenter.GetValues(time, 'c');
			List<int> humidity = presenter.GetValues(time, 'h');
			List<int> temp = presenter.GetValues(time, 't');
			List<int> resist = presenter.GetValues(time, 'r');
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
			if (current == time)
			{
				timer.Stop();
				isFinish = true;
			}
			current++;
		}

		private void button_pdf_Click(object sender, EventArgs e)
		{
			if (!isFinish)
			{
				MessageBox.Show("EXAM STILL RUNNING");
			}
			else
			{
				PDFCreator creator = new PDFCreator(patient, charts);
				if (creator.Create())
				{
					MessageBox.Show("PDF is created in H:\\MedicalTest\\PDF\\");
				}
			}			
		}
	}
}
