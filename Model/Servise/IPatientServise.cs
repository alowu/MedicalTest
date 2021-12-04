using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Servise
{
	public interface IPatientServise
	{
		List<Patient> GetAll();
		Task<Patient> Create(Patient item);
		Task<Patient> Update(Patient item);
		Task<Patient> Delete(int id);
	}
}
