/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 25/11/2026
 * Time: 08:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TRABAJO
{
	partial class PALABRA
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtpalabra = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblnormal = new System.Windows.Forms.Label();
			this.lblrevez = new System.Windows.Forms.Label();
			this.btncambiar = new System.Windows.Forms.Button();
			this.btnregresa = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingresa tu palabra";
			// 
			// txtpalabra
			// 
			this.txtpalabra.Location = new System.Drawing.Point(258, 27);
			this.txtpalabra.Name = "txtpalabra";
			this.txtpalabra.Size = new System.Drawing.Size(326, 22);
			this.txtpalabra.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 193);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "palabra normal";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(398, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Palabra al revez";
			// 
			// lblnormal
			// 
			this.lblnormal.Location = new System.Drawing.Point(25, 284);
			this.lblnormal.Name = "lblnormal";
			this.lblnormal.Size = new System.Drawing.Size(247, 23);
			this.lblnormal.TabIndex = 5;
			// 
			// lblrevez
			// 
			this.lblrevez.Location = new System.Drawing.Point(326, 284);
			this.lblrevez.Name = "lblrevez";
			this.lblrevez.Size = new System.Drawing.Size(273, 23);
			this.lblrevez.TabIndex = 6;
			// 
			// btncambiar
			// 
			this.btncambiar.Location = new System.Drawing.Point(194, 118);
			this.btncambiar.Name = "btncambiar";
			this.btncambiar.Size = new System.Drawing.Size(156, 59);
			this.btncambiar.TabIndex = 7;
			this.btncambiar.Text = "Cambiar";
			this.btncambiar.UseVisualStyleBackColor = true;
			this.btncambiar.Click += new System.EventHandler(this.BtncambiarClick);
			// 
			// btnregresa
			// 
			this.btnregresa.Location = new System.Drawing.Point(25, 98);
			this.btnregresa.Name = "btnregresa";
			this.btnregresa.Size = new System.Drawing.Size(109, 57);
			this.btnregresa.TabIndex = 8;
			this.btnregresa.Text = "regresar";
			this.btnregresa.UseVisualStyleBackColor = true;
			this.btnregresa.Click += new System.EventHandler(this.BtnregresaClick);
			// 
			// PALABRA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 421);
			this.Controls.Add(this.btnregresa);
			this.Controls.Add(this.btncambiar);
			this.Controls.Add(this.lblrevez);
			this.Controls.Add(this.lblnormal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtpalabra);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PALABRA";
			this.Text = "Palabra_al_Revez";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnregresa;
		private System.Windows.Forms.Button btncambiar;
		private System.Windows.Forms.Label lblrevez;
		private System.Windows.Forms.Label lblnormal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtpalabra;
		private System.Windows.Forms.Label label1;
	}
}
