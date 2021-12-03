using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
	public class Examination
	{
		public int id
		{
			get;
			set;
		}

		public int patientId
		{
			get;
			set;
		}

		public TypePhysicalActive physicalActive
		{
			get;
			set;
		}

		public int timeActive
		{
			get;
			set;
		}

		public bool statePresure
		{
			get;
			set;
		}
		public bool stateTemperature
		{
			get;
			set;
		}
		public bool stateHumidity
		{
			get;
			set;
		}
		public bool stateResist
		{
			get;
			set;
		}
		public bool stateChss
		{
			get;
			set;
		}
	}
}
