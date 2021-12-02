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
	public partial class TestScreen : Form
	{
		public TestScreen()
		{
			InitializeComponent();
		}

		GraphicsScreen graphicsScreen = new GraphicsScreen();

		private void graphicsSreen_FormClosed(object sender, FormClosedEventArgs e) 
		{
			this.Close();
		}

		private void button_start_Click(object sender, EventArgs e)
		{
			graphicsScreen.ShowDialog();
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		bool flag = false;
		private void button_setup_Click(object sender, EventArgs e)
		{
			flag = !flag;
			pictureBox_css.Visible = flag;
			pictureBox_presure.Visible = flag;
			pictureBox_resist.Visible = flag;
			pictureBox_temp.Visible = flag;
			pictureBox_vlazh.Visible = flag;
		}
	}
}
