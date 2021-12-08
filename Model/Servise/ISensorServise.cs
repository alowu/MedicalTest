using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Servise
{
	public interface ISensorServise
	{
		List<Sensor> setState(List<Sensor> list);
		bool checkState(List<Sensor> list);
	}
}
