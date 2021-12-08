using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
	public enum Sex
	{ 
		Female = 0,
		Male = 1,
		Error = 2
	}

	public enum TypePhysicalActive
	{
		Running,
		Walking,
		Swimming,
		Сycling
	}

	public enum SensorState
	{ 
		NotActive = 0,
		Busy = 1,
		Ready = 2 
	}

	//TODO add others constant enums
}
