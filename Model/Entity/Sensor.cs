using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
	public class Sensor
	{
		public bool isEnable
		{
			get;
			set;
		}

		public SensorState state
		{
			get;
			set;
		}
	}
}
