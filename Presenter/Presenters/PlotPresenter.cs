using Model.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
	public class PlotPresenter
	{
		private ExaminationServise examinationServise = new ExaminationServise();
		private PatientServise patientServise = new PatientServise();
		private PlotServise plotServise = new PlotServise();

		public List<int> GetValues(int time, char sensor)
		{
			return plotServise.Generate(time, sensor);
		}

		public void Remove(int id)
		{
			examinationServise.Delete(id);
			patientServise.UpdateStatus(id);
		}
	}
}
