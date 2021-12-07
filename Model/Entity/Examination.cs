using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
	public class Examination
	{
		public Examination(int patientId, TypePhysicalActive physicalActive, int timeActive, bool statePresure, bool stateTemperature, bool stateHumidity, bool stateResist, bool stateChss)
		{
			this.patientId = patientId;
			this.physicalActive = physicalActive;
			this.timeActive = timeActive;
			this.statePresure = statePresure;
			this.stateTemperature = stateTemperature;
			this.stateHumidity = stateHumidity;
			this.stateResist = stateResist;
			this.stateChss = stateChss;
		}

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
