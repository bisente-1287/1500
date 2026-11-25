/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 25/11/2026
 * Time: 07:48 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TRABAJO
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnIniciarClick(object sender, EventArgs e)
		{
			string con;
			string usu;
			con="123";
			usu="Germany";
			
			
			if(txtContraseña.Text == con && txtUsuario.Text == usu)
			{
				frmMenu f= new frmMenu();
				f.Show();
				this.Hide();
			}
		}
	}
}
