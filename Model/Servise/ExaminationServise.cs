using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Servise
{
	class ExaminationServise : IExaminationServise
	{
		private ExaminationRepository _examinationRepository;
		public bool Create(Examination item)
		{
			return _examinationRepository.Create(item);
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
	}
}
