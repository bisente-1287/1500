/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 25/11/2026
 * Time: 07:48 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TRABAJO
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(45, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "CONTRASEÑA:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(45, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "USUARIO:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-9, 212);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(554, 244);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(148, 40);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.PasswordChar = '*';
			this.txtContraseña.Size = new System.Drawing.Size(104, 20);
			this.txtContraseña.TabIndex = 4;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(128, 79);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(124, 20);
			this.txtUsuario.TabIndex = 5;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(45, 129);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(430, 67);
			this.btnRegistrar.TabIndex = 6;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnIniciarClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(314, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "123";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(314, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Germany";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 456);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Registrarse";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
