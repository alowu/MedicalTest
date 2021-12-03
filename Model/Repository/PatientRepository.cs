using Model.Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class PatientRepository : IRepository<Patient>
	{
		public Task<Patient> Create(Patient item)
		{
			throw new NotImplementedException();
		}

		public Task<Patient> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Patient> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Patient> Update(Patient item)
		{
			throw new NotImplementedException();
		}
	}
}
