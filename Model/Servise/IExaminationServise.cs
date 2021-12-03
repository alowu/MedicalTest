using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Servise
{
	public interface IExaminationServise
	{
		Task<Examination> GetAll();
		Task<Examination> Create(Examination item);
		Task<Examination> Update(Examination item);
		Task<Examination> Delete(int id);
	}
}
