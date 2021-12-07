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
		List<Examination> GetAll();
		Examination GetExamination(int Id);
		bool Create(Examination item);
		bool Update(Examination item);
		bool Delete(int id);
	}
}
