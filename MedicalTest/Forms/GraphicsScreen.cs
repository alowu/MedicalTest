using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalTest
{
	public partial class GraphicsScreen : Form
	{

		public GraphicsScreen()
		{
			InitializeComponent();
		}

		private void button_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void GraphicsScreen_Load(object sender, EventArgs e)
		{
			double a = 0;
			double b = 30;
			double h = 0.1;
			double x, y;

			this.chart1.Series[0].Points.Clear();
			this.chart2.Series[0].Points.Clear();
			this.chart3.Series[0].Points.Clear();
			this.chart4.Series[0].Points.Clear();
			this.chart5.Series[0].Points.Clear();

			x = a;
			while (x <= b)
			{
				y = Math.Sin(x);
				this.chart1.Series[0].Points.AddXY(x, y);
				this.chart2.Series[0].Points.AddXY(x, y);
				this.chart3.Series[0].Points.AddXY(x, y);
				this.chart4.Series[0].Points.AddXY(x, y);
				this.chart5.Series[0].Points.AddXY(x, y);
				x += h;
			}
		}
	}
}
