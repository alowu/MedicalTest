using Model.Entity;
using Model.Servise;
using Presenter.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
	public class AdminPresenter
	{
		private PatientServise patientServise = new PatientServise();
		List<Patient> patients = null;

		public AdminPresenter()
		{
		}

		public List<Patient> ShowAdmin()
		{
			patients = patientServise.GetAll();
			return patients;
		}

		public bool Add(Patient patient)
		{
			return patientServise.Create(patient);
		}
	}
}
