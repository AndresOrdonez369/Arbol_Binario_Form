namespace Proyecto4_ArbolesBinarios
{
	partial class Escenario2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.gráficaDelÁrbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recorridoEnPreordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recorridoEnInordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recorridoEnPostordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recorridosToolStripMenuItem,
            this.gráficaDelÁrbolToolStripMenuItem,
            this.salireToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// gráficaDelÁrbolToolStripMenuItem
			// 
			this.gráficaDelÁrbolToolStripMenuItem.Name = "gráficaDelÁrbolToolStripMenuItem";
			this.gráficaDelÁrbolToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.gráficaDelÁrbolToolStripMenuItem.Text = "Gráfica del árbol";
			this.gráficaDelÁrbolToolStripMenuItem.Click += new System.EventHandler(this.gráficaDelÁrbolToolStripMenuItem_Click);
			// 
			// recorridosToolStripMenuItem
			// 
			this.recorridosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recorridoEnPreordenToolStripMenuItem,
            this.recorridoEnInordenToolStripMenuItem,
            this.recorridoEnPostordenToolStripMenuItem});
			this.recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
			this.recorridosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.recorridosToolStripMenuItem.Text = "Recorridos";
			// 
			// recorridoEnPreordenToolStripMenuItem
			// 
			this.recorridoEnPreordenToolStripMenuItem.Name = "recorridoEnPreordenToolStripMenuItem";
			this.recorridoEnPreordenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.recorridoEnPreordenToolStripMenuItem.Text = "Recorrido en Preorden";
			this.recorridoEnPreordenToolStripMenuItem.Click += new System.EventHandler(this.recorridoEnPreordenToolStripMenuItem_Click);
			// 
			// recorridoEnInordenToolStripMenuItem
			// 
			this.recorridoEnInordenToolStripMenuItem.Name = "recorridoEnInordenToolStripMenuItem";
			this.recorridoEnInordenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.recorridoEnInordenToolStripMenuItem.Text = "Recorrido en Inorden";
			this.recorridoEnInordenToolStripMenuItem.Click += new System.EventHandler(this.recorridoEnInordenToolStripMenuItem_Click);
			// 
			// recorridoEnPostordenToolStripMenuItem
			// 
			this.recorridoEnPostordenToolStripMenuItem.Name = "recorridoEnPostordenToolStripMenuItem";
			this.recorridoEnPostordenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.recorridoEnPostordenToolStripMenuItem.Text = "Recorrido en Postorden";
			this.recorridoEnPostordenToolStripMenuItem.Click += new System.EventHandler(this.recorridoEnPostordenToolStripMenuItem_Click);
			// 
			// salireToolStripMenuItem
			// 
			this.salireToolStripMenuItem.Name = "salireToolStripMenuItem";
			this.salireToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
			this.salireToolStripMenuItem.Text = "Volver al menú";
			this.salireToolStripMenuItem.Click += new System.EventHandler(this.salireToolStripMenuItem_Click);
			// 
			// Escenario2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Escenario2";
			this.Text = "Escenario2";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem gráficaDelÁrbolToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recorridosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recorridoEnPreordenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recorridoEnInordenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recorridoEnPostordenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salireToolStripMenuItem;
	}
}