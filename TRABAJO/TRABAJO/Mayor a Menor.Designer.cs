/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 25/11/2026
 * Time: 08:20 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TRABAJO
{
	partial class Mayor_a_Menor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mayor_a_Menor));
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lstResultado = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(13, 60);
			this.txtNumero.Multiline = true;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 23);
			this.txtNumero.TabIndex = 2;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(139, 42);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(139, 82);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
			this.btnOrdenar.TabIndex = 4;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Numero:";
			// 
			// lstResultado
			// 
			this.lstResultado.FormattingEnabled = true;
			this.lstResultado.Location = new System.Drawing.Point(13, 147);
			this.lstResultado.Name = "lstResultado";
			this.lstResultado.Size = new System.Drawing.Size(201, 108);
			this.lstResultado.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(220, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 32);
			this.label2.TabIndex = 8;
			this.label2.Text = "Los de abajo son los menores y los de arriba los mayores...";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.opcionesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(444, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem,
									this.regresarToolStripMenuItem});
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.opcionesToolStripMenuItem.Text = "&Opciones";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// regresarToolStripMenuItem
			// 
			this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
			this.regresarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.regresarToolStripMenuItem.Text = "Regresar";
			this.regresarToolStripMenuItem.Click += new System.EventHandler(this.RegresarToolStripMenuItemClick);
			// 
			// Mayor_a_Menor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(444, 338);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstResultado);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Mayor_a_Menor";
			this.Text = "Mayor_a_Menor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstResultado;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOrdenar;
		//private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.TextBox txtNumero;
		
	}
}
