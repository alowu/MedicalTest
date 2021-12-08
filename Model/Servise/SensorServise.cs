using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Servise
{
	public class SensorServise : ISensorServise
	{
		public bool checkState(List<Sensor> list)
		{
			bool result = false;
			int expected = 0;
			int current = 0;
			foreach (Sensor item in list)
			{
				if (item.isEnable)
				{
					expected++;
				}
			}

			foreach (Sensor item in list)
			{
				if (item.isEnable)
				{
					if (item.state == SensorState.Ready)
					{
						current++;
					}
				}
			}
			if (expected == current)
			{
				result = true;
			}
			return result;
		}

		public List<Sensor> setState(List<Sensor> list)
		{
			Random random = new Random();
			int state;
			foreach (Sensor sensor in list)
			{
				if (sensor.isEnable)
				{
					state = random.Next(0, 31);
					if (state <= 20)
					{
						sensor.state = SensorState.Ready;
					} 
					else if (state > 20 && state <= 25)
					{
						sensor.state = SensorState.Busy;
					}
					else
					{
						sensor.state = SensorState.NotActive;
					}
				}
			}
			return list;
		}
	}
}
