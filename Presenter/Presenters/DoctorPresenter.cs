using Model.Entity;
using Model.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
	public class DoctorPresenter
	{
		private PatientServise patientServise = new PatientServise();
		List<Patient> patients = null;

		public DoctorPresenter() { }

		public List<Patient> ShowDoctor()
		{
			patients = patientServise.GetAll();
			return patients;
		}
	}
}
