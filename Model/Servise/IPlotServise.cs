using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Servise
{
	public interface IPlotServise
	{
		List<int> Generate(int time, char sensor);
		string GetDate();
	}
}
