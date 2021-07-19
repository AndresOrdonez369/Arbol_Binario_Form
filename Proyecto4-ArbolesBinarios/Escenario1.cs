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
	public partial class Escenario1 : Form
	{
		public Escenario1()
		{
			InitializeComponent();
		}

		private void salireToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainMenu myMenu = new MainMenu();
			myMenu.Show();
			this.Hide();
		}
		//Método para diseñar la interfaz gráfica del árbol
		private void gráficaDelÁrbolToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Diseño de nodo raíz
			Graphics nodo;
			nodo = CreateGraphics();
			nodo.FillEllipse(Brushes.Cyan, 230, 30, 35, 35);
			nodo.DrawString("25", Font, Brushes.Purple, 240, 40);
			Pen myNodoRaiz = new Pen(Color.Orange, 3);
			nodo.DrawEllipse(myNodoRaiz, 230, 30, 35, 35);

			nodo.FillEllipse(Brushes.Cyan, 150, 80, 35, 35);
			nodo.DrawString("10", Font, Brushes.Purple, 160, 90);
			Pen myNodo1 = new Pen(Color.Orange, 3);
			nodo.DrawEllipse(myNodo1, 150, 80, 35, 35);

			//linea para conectar nodo izquierdo
			Pen myLinea1 = new Pen(Color.Orange, 2);
			nodo.DrawLine(myLinea1, 185, 90, 230, 50);

			nodo.FillEllipse(Brushes.Cyan, 310, 80, 35, 35);
			nodo.DrawString("35", Font, Brushes.Purple, 320, 90);
			Pen myNodo2 = new Pen(Color.Orange, 3);
			nodo.DrawEllipse(myNodo2, 310, 80, 35, 35);

			//linea para conectar nodo derecho
			Pen myLinea2 = new Pen(Color.Orange, 2);
			nodo.DrawLine(myLinea2, 310, 90, 265, 50);

			//Segunda Capa A

			nodo.FillEllipse(Brushes.Cyan, 100, 130, 35, 35);
			nodo.DrawString("7", Font, Brushes.Purple, 110, 140);
			Pen myNodo3 = new Pen(Color.Orange, 3);
			nodo.DrawEllipse(myNodo3, 100, 130, 35, 35);
			//linea para conectar nodo izquierdo
			Pen myLinea3 = new Pen(Color.Orange, 2);
			nodo.DrawLine(myLinea3, 135, 140, 155, 110);

			nodo.FillEllipse(Brushes.Cyan, 200, 130, 35, 35);
			nodo.DrawString("12", Font, Brushes.Purple, 210, 140);
			Pen myNodo4 = new Pen(Color.Orange, 3);
			nodo.DrawEllipse(myNodo4, 200, 130, 35, 35);
			//linea para conectar nodo derecho
			Pen myLinea4 = new Pen(Color.Orange, 2);
			nodo.DrawLine(myLinea4, 200, 140, 180, 110);


			//Segunda Capa B

			nodo.FillEllipse(Brushes.Cyan, 260, 130, 35, 35);
			nodo.DrawString("28", Font, Brushes.Purple, 270, 140);
			Pen myNodo5 = new Pen(Color.Orange, 3);
			nodo.DrawEllipse(myNodo5, 260, 130, 35, 35);
			
			Pen myLinea5 = new Pen(Color.Orange, 2);
			nodo.DrawLine(myLinea5, 290, 140, 315, 110);



			nodo.FillEllipse(Brushes.Cyan, 360, 130, 35, 35);
			nodo.DrawString("50", Font, Brushes.Purple, 370, 140);
			Pen myNodo6 = new Pen(Color.Orange, 3);
			nodo.DrawEllipse(myNodo6, 360, 130, 35, 35);

			Pen myLinea6 = new Pen(Color.Orange, 2);
			nodo.DrawLine(myLinea6, 360, 140, 340, 110);

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void recorridoEnPreordenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Graphics preorden;
			preorden = CreateGraphics();
			preorden.DrawString("Preorden :", Font, Brushes.Black, 30, 250);
			
			Pen myPreOrden1 = new Pen(Color.Green, 1);
			preorden.DrawEllipse(myPreOrden1, 90, 240, 35, 35);
			preorden.DrawString("25", Font, Brushes.Purple, 100, 250);

			Pen myPreOrden2 = new Pen(Color.Green, 1);
			preorden.DrawEllipse(myPreOrden2, 140, 240, 35, 35);
			preorden.DrawString("10", Font, Brushes.Purple, 150, 250);
			
			Pen myPreOrden3 = new Pen(Color.Green, 1);
			preorden.DrawEllipse(myPreOrden3, 190, 240, 35, 35);
			preorden.DrawString("7", Font, Brushes.Purple, 200, 250);

			Pen myPreOrden4 = new Pen(Color.Green, 1);
			preorden.DrawEllipse(myPreOrden4, 240, 240, 35, 35);
			preorden.DrawString("12", Font, Brushes.Purple, 250, 250);

			Pen myPreOrden5 = new Pen(Color.Green, 1);
			preorden.DrawEllipse(myPreOrden5, 290, 240, 35, 35);
			preorden.DrawString("35", Font, Brushes.Purple, 300, 250);

			Pen myPreOrden6 = new Pen(Color.Green, 1);
			preorden.DrawEllipse(myPreOrden6, 340, 240, 35, 35);
			preorden.DrawString("28", Font, Brushes.Purple, 350, 250);

			Pen myPreOrden7 = new Pen(Color.Green, 1);
			preorden.DrawEllipse(myPreOrden7, 390, 240, 35, 35);
			preorden.DrawString("50", Font, Brushes.Purple, 400, 250);
		}

		private void recorridoEnInordenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Graphics inorden;
			inorden = CreateGraphics();
			inorden.DrawString("Inorden :", Font, Brushes.Black, 30, 290);

			Pen myInOrden1 = new Pen(Color.Green, 1);
			inorden.DrawEllipse(myInOrden1, 90, 280, 35, 35);
			inorden.DrawString("7", Font, Brushes.Purple, 100, 290);

			Pen myInOrden2 = new Pen(Color.Green, 1);
			inorden.DrawEllipse(myInOrden2, 140, 280, 35, 35);
			inorden.DrawString("10", Font, Brushes.Purple, 150, 290);

			Pen myInOrden3 = new Pen(Color.Green, 1);
			inorden.DrawEllipse(myInOrden3, 190, 280, 35, 35);
			inorden.DrawString("12", Font, Brushes.Purple, 200, 290);

			Pen myInOrden4 = new Pen(Color.Green, 1);
			inorden.DrawEllipse(myInOrden4, 240, 280, 35, 35);
			inorden.DrawString("25", Font, Brushes.Purple, 250, 290);

			Pen myInOrden5 = new Pen(Color.Green, 1);
			inorden.DrawEllipse(myInOrden5, 290, 280, 35, 35);
			inorden.DrawString("28", Font, Brushes.Purple, 300, 290);

			Pen myInOrden6 = new Pen(Color.Green, 1);
			inorden.DrawEllipse(myInOrden6, 340, 280, 35, 35);
			inorden.DrawString("35", Font, Brushes.Purple, 350, 290);

			Pen myInOrden7 = new Pen(Color.Green, 1);
			inorden.DrawEllipse(myInOrden7, 390, 280, 35, 35);
			inorden.DrawString("50", Font, Brushes.Purple, 400, 290);
		}

		private void recorridoEnPostordenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Graphics postorden;
			postorden = CreateGraphics();
			postorden.DrawString("Postorden :", Font, Brushes.Black, 30, 330);

			Pen myPosOrden1 = new Pen(Color.Green, 1);
			postorden.DrawEllipse(myPosOrden1, 90, 320, 35, 35);
			postorden.DrawString("7", Font, Brushes.Purple, 100, 330);

			Pen myPosOrden2 = new Pen(Color.Green, 1);
			postorden.DrawEllipse(myPosOrden2, 140, 320, 35, 35);
			postorden.DrawString("12", Font, Brushes.Purple, 150, 330);

			Pen myPosOrden3 = new Pen(Color.Green, 1);
			postorden.DrawEllipse(myPosOrden3, 190, 320, 35, 35);
			postorden.DrawString("10", Font, Brushes.Purple, 200, 330);

			Pen myPosOrden4 = new Pen(Color.Green, 1);
			postorden.DrawEllipse(myPosOrden4, 240, 320, 35, 35);
			postorden.DrawString("28", Font, Brushes.Purple, 250, 330);

			Pen myPosOrden5 = new Pen(Color.Green, 1);
			postorden.DrawEllipse(myPosOrden5, 290, 320, 35, 35);
			postorden.DrawString("50", Font, Brushes.Purple, 300, 330);

			Pen myPosOrden6 = new Pen(Color.Green, 1);
			postorden.DrawEllipse(myPosOrden6, 340, 320, 35, 35);
			postorden.DrawString("35", Font, Brushes.Purple, 350, 330);

			Pen myPosOrden7 = new Pen(Color.Green, 1);
			postorden.DrawEllipse(myPosOrden7, 390, 320, 35, 35);
			postorden.DrawString("25", Font, Brushes.Purple, 400, 330);

		}

		private void recorridosToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
