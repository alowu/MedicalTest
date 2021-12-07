using Model.Entity;
using Model.Servise;
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
		private ExaminationServise examinationServise = new ExaminationServise();
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

		public bool Add(Examination examination)
		{
			return examinationServise.Create(examination);
		}

		public bool Udpate(Patient patient)
		{
			return patientServise.Update(patient);
		}

		public bool Delete(Patient patient)
		{
			return patientServise.Delete(patient.id);
		}

		public Patient GetPatient(int id)
		{
			return patientServise.GetPatient(id);
		}
	}
}
