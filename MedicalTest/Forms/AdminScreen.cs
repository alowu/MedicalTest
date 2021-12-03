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
using Presenter.View;
using Presenter.Presenters;
using System.Collections;
using Model.Entity;

namespace MedicalTest
{
	public partial class AdminScreen : Form, IAdminView
	{
		//AdminPresenter presenter = new AdminPresenter();
		public Patient patient
		{ 
			get => throw new NotImplementedException(); 
			set => throw new NotImplementedException(); 
		}
		
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
			//presenter.ShowAdmin();
		}
	}
}
