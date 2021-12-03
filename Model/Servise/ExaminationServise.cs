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
		public Task<Examination> Create(Examination item)
		{
			return _examinationRepository.Create(item);
		}

		public Task<Examination> Delete(int id)
		{
			return _examinationRepository.Delete(id);
		}

		public Task<List<Examination>> GetAll()
		{
			return _examinationRepository.GetAll();
		}

		public Task<Examination> Update(Examination item)
		{
			throw new NotImplementedException();
		}
	}
}
