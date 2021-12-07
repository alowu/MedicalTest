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
		private ExaminationServise examinationServise = new ExaminationServise();
		List<Patient> patients = null;

		public DoctorPresenter() { }

		public List<Patient> ShowDoctor()
		{
			patients = patientServise.GetAll();
			return patients;
		}

		public Patient GetPatient(int id)
		{
			return patientServise.GetPatient(id);
		}

		public Examination GetExamination(int id)
		{
			return examinationServise.GetExamination(id);
		}
	}
}
