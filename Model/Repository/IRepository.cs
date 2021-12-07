using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public interface IRepository<T> where T : class
	{
		List<T> GetAll();
		T FindById(int Id);
		T GetT(int Id);
		bool Create(T item);
		bool Update(T item);
		bool Delete(int id);
	}
}
