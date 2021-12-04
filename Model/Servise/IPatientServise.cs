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
		bool Create(Patient item);
		bool Update(Patient item);
		bool Delete(int id);
	}
}
