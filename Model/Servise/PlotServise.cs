using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Servise
{
	public class PlotServise : IPlotServise
	{
		public List<int> Generate(int time, char sensor)
		{
			List<int> values = new List<int>(time);
			Random random = new Random();

			for (int i = 0; i < time; ++i)
			{
				switch (sensor)
				{
					case 'p':
						values.Add(150 - random.Next(36));
						break;
					case 'c':
						values.Add(170 - random.Next(101));
						break;
					case 't':
						values.Add(41 - random.Next(7));
						break;
					case 'h':
						values.Add(200 - random.Next(51));
						break;
					case 'r':
						values.Add(300 - random.Next(151));
						break;
				}
			}
			return values;
		}

		public string GetDate()
		{
			DateTime dateTime = DateTime.Now;
			return dateTime.ToShortDateString();
		}
	}
}
