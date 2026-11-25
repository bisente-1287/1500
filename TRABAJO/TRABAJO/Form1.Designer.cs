/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 25/11/2026
 * Time: 07:56 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TRABAJO
{
	partial class frmMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.pROGRAMASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deMayorAMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mayorYElMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.palabraAlrevezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vocalesYConsonantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.pROGRAMASToolStripMenuItem,
									this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(478, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// pROGRAMASToolStripMenuItem
			// 
			this.pROGRAMASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.deMayorAMenorToolStripMenuItem,
									this.mayorYElMenorToolStripMenuItem,
									this.palabraAlrevezToolStripMenuItem,
									this.vocalesYConsonantesToolStripMenuItem});
			this.pROGRAMASToolStripMenuItem.Name = "pROGRAMASToolStripMenuItem";
			this.pROGRAMASToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.pROGRAMASToolStripMenuItem.Text = "&PROGRAMAS";
			// 
			// deMayorAMenorToolStripMenuItem
			// 
			this.deMayorAMenorToolStripMenuItem.Name = "deMayorAMenorToolStripMenuItem";
			this.deMayorAMenorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.deMayorAMenorToolStripMenuItem.Text = "De mayor a menor";
			this.deMayorAMenorToolStripMenuItem.Click += new System.EventHandler(this.DeMayorAMenorToolStripMenuItemClick);
			// 
			// mayorYElMenorToolStripMenuItem
			// 
			this.mayorYElMenorToolStripMenuItem.Name = "mayorYElMenorToolStripMenuItem";
			this.mayorYElMenorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.mayorYElMenorToolStripMenuItem.Text = "el mayor y el menor";
			this.mayorYElMenorToolStripMenuItem.Click += new System.EventHandler(this.MayorYElMenorToolStripMenuItemClick);
			// 
			// palabraAlrevezToolStripMenuItem
			// 
			this.palabraAlrevezToolStripMenuItem.Name = "palabraAlrevezToolStripMenuItem";
			this.palabraAlrevezToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.palabraAlrevezToolStripMenuItem.Text = "Palabra al revez";
			this.palabraAlrevezToolStripMenuItem.Click += new System.EventHandler(this.PalabraAlrevezToolStripMenuItemClick);
			// 
			// vocalesYConsonantesToolStripMenuItem
			// 
			this.vocalesYConsonantesToolStripMenuItem.Name = "vocalesYConsonantesToolStripMenuItem";
			this.vocalesYConsonantesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.vocalesYConsonantesToolStripMenuItem.Text = "Vocales y consonantes";
			this.vocalesYConsonantesToolStripMenuItem.Click += new System.EventHandler(this.VocalesYConsonantesToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.salirToolStripMenuItem.Text = "&Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(478, 395);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 434);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMenu";
			this.Text = "Menu Principal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vocalesYConsonantesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem palabraAlrevezToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mayorYElMenorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deMayorAMenorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pROGRAMASToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
