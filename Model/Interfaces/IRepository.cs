using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
	public interface IRepository<T> where T : class
	{
		Task<T> Get(Guid id);
		Task<T> Create(T item);
		Task<T> Update(T item);
		Task Delete(Guid id);
	}
}
