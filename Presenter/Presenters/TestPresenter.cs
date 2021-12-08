using Model.Entity;
using Model.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
	public class TestPresenter
	{
		private SensorServise sensorServise = new SensorServise();
		private ExaminationServise examinationServise = new ExaminationServise();
		private PatientServise patientServise = new PatientServise();

		public Examination GetExamination(int id)
		{
			return examinationServise.GetExamination(id);
		}

		public Patient GetPatient(int id)
		{
			return patientServise.GetPatient(id);
		}

		public bool isReady(List<Sensor> list)
		{
			return sensorServise.checkState(list);
		}

		public List<Sensor> setSensors(List<Sensor> list)
		{
			return sensorServise.setState(list);
		}
	}
}
