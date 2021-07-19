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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.dateTimePicker1.Value = DateTime.Now;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtPass.Text == "123")
			{
				MainMenu myMenu = new MainMenu();
				myMenu.Show();
				this.Hide();
			}
		}
	}
}
