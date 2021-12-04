using Model;
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
	public partial class StartScreen : Form
	{
	
		public StartScreen()
		{
			InitializeComponent();
		}

		private void button_admin_Click(object sender, EventArgs e)
		{
			AdminScreen adminScreen = new AdminScreen();
			adminScreen.ShowDialog();
		}

		private void button_doctor_Click(object sender, EventArgs e)
		{
			DoctorScreen doctorScreen = new DoctorScreen();
			doctorScreen.ShowDialog();
		}

		private void StartScreen_Load(object sender, EventArgs e)
		{
		}
	}
}
