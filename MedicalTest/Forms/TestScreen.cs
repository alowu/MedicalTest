using Model.Entity;
using Presenter.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalTest
{
	public partial class TestScreen : Form
	{
		private int patientId;
		private Examination examination = new Examination();
		private Patient patient = new Patient();
		private bool state = false;
		private bool check = false;
		private List<Sensor> sensors = new List<Sensor>();
		private List<PictureBox> pictures = new List<PictureBox>();
		private List<Label> labels = new List<Label>();

		TestPresenter presenter = new TestPresenter();
		public TestScreen(int patid)
		{
			InitializeComponent();
			patientId = patid;
			pictures.Add(pictureBox_presure_state);
			pictures.Add(pictureBox_css_state);
			pictures.Add(pictureBox_temp_state);
			pictures.Add(pictureBox_resist_state);
			pictures.Add(pictureBox_vlazh_state);

			labels.Add(label_presure_value);
			labels.Add(label_css_value);
			labels.Add(label_temp_value);
			labels.Add(label_resist_value);
			labels.Add(label_vlazh_value);

			patient = presenter.GetPatient(patientId);
		}

		private void button_start_Click(object sender, EventArgs e)
		{
			label_state.ForeColor = Color.Red;
			if (state)
			{
				if (check)
				{
					GraphicsScreen graphicsScreen = new GraphicsScreen(patient, examination);
					if (graphicsScreen.ShowDialog() == DialogResult.Cancel)
					{
						this.Close();
					}
				}
				else
				{
					label_state.Text = "Не активированы датчики";
				}				
			}
			else
			{
				label_state.Text = "Не установлены датчики";
			}
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button_setup_Click(object sender, EventArgs e)
		{
			if (!state)
			{
				examination = presenter.GetExamination(patientId);

				pictureBox_css.Visible = examination.stateChss;
				pictureBox_presure.Visible = examination.statePresure;
				pictureBox_resist.Visible = examination.stateResist;
				pictureBox_temp.Visible = examination.stateTemperature;
				pictureBox_vlazh.Visible = examination.stateHumidity;

				state = true;

				foreach (PictureBox item in pictures)
				{
					item.BackColor = Color.Fuchsia;
				}

				Sensor sensor_c = new Sensor(examination.stateChss);
				Sensor sensor_p = new Sensor(examination.statePresure);
				Sensor sensor_r = new Sensor(examination.stateResist);
				Sensor sensor_t = new Sensor(examination.stateTemperature);
				Sensor sensor_h = new Sensor(examination.stateHumidity);

				sensors.Add(sensor_p);
				sensors.Add(sensor_c);
				sensors.Add(sensor_t);
				sensors.Add(sensor_r);
				sensors.Add(sensor_h);
			}
		}

		private void TestScreen_Load(object sender, EventArgs e)
		{

		}

		private void button_check_Click(object sender, EventArgs e)
		{
			if (state && !check)
			{
				List<Sensor> new_sensors = presenter.setSensors(sensors);
				check = presenter.isReady(new_sensors);
				for (int i = 0; i < 5; i++)
				{
					if (new_sensors[i].isEnable)
					{
						switch (new_sensors[i].state)
						{
							case SensorState.NotActive:
								pictures[i].BackColor = Color.Red;
								labels[i].Visible = true;
								labels[i].Text = "Not active";
								break;
							case SensorState.Busy:
								pictures[i].BackColor = Color.Yellow;
								labels[i].Visible = true;
								labels[i].Text = "Busy";
								break;
							case SensorState.Ready:
								pictures[i].BackColor = Color.Green;
								labels[i].Visible = true;
								labels[i].Text = "Ready";
								break;
						}
					}
				}
				sensors = new_sensors;
			}
		}
	}
}
