using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class ExaminationRepository : IRepository<Examination>
	{
		public Task<Examination> Create(Examination item)
		{
			throw new NotImplementedException();
		}

		public Task<Examination> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Examination>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Examination> Update(Examination item)
		{
			throw new NotImplementedException();
		}
	}
}
