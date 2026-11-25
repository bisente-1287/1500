/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 25/11/2026
 * Time: 07:56 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TRABAJO
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class frmMenu : Form
	{
		public frmMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void DeMayorAMenorToolStripMenuItemClick(object sender, EventArgs e)
		{
			Mayor_a_Menor m = new Mayor_a_Menor();
			m.Show();
			this.Hide();
		}
		
		void MayorYElMenorToolStripMenuItemClick(object sender, EventArgs e)
		{
			Mayor T = new Mayor();
			T.Show();
			this.Hide();
			
		}
		
		void PalabraAlrevezToolStripMenuItemClick(object sender, EventArgs e)
		{
			PALABRA r = new PALABRA();
			r.Show();
			this.Hide();
		}
		
		void VocalesYConsonantesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Vocales y = new Vocales();
			y.Show();
			this.Hide();
		}
	}
}
