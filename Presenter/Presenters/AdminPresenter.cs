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
		private IPatientServise patientServise;

		public AdminPresenter(IAdminView view)
		{
			//adminView = view;
		}

		public void ShowAdmin()
		{

		}
	}
}
