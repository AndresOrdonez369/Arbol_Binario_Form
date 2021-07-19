using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto4_ArbolesBinarios
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
		{

		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{
			Escenario1 esc1 = new Escenario1();
			esc1.Show();
			this.Hide();
		}

		private void toolStripLabel3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void toolStripLabel2_Click(object sender, EventArgs e)
		{
			Escenario2 esc2 = new Escenario2();
			esc2.Show();
			this.Hide();
		}
	}
}
