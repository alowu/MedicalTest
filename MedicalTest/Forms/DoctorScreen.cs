﻿using System;
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
		public DoctorScreen()
		{
			InitializeComponent();
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TestScreen testScreen = new TestScreen();
			testScreen.ShowDialog();
		}

		private void DoctorScreen_Load(object sender, EventArgs e)
		{
			
		}
	}
}