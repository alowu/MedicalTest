using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Servise
{
	public class ExaminationServise : IExaminationServise
	{
		private ExaminationRepository _examinationRepository;

		public ExaminationServise()
		{
			_examinationRepository = new ExaminationRepository();
		}
		public bool Create(Examination item)
		{
			bool isSelected = isSelectedAtLeastOne(item);
			if (isSelected)
			{
				return _examinationRepository.Create(item);
			}
			else
			{
				return isSelected;
			}			
		}

		public bool Delete(int id)
		{
			return _examinationRepository.Delete(id);
		}

		public List<Examination> GetAll()
		{
			return _examinationRepository.GetAll();
		}

		public bool Update(Examination item)
		{
			return _examinationRepository.Update(item);
		}

		private bool isSelectedAtLeastOne(Examination item)
		{
			return	item.stateChss		||
					item.stateHumidity	||
					item.statePresure	||
					item.stateResist	||
					item.stateTemperature;
		}
	}
}
