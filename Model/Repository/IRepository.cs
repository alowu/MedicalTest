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
		Task<T> Create(T item);
		Task<T> Update(T item);
		Task<T> Delete(int id);
	}
}
