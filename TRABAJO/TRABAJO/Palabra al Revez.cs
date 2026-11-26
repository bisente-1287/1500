/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 25/11/2026
 * Time: 08:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TRABAJO
{
	/// <summary>
	/// Description of Palabra_al_Revez.
	/// </summary>
	public partial class PALABRA : Form
	{
		public PALABRA()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncambiarClick(object sender, EventArgs e)
		{
			string palabra="", invertida="";
			palabra=txtpalabra.Text;
			int l=palabra.Length;
			for(int i=l-1; i>=0; i--)
			{
				invertida=invertida+ palabra.Substring(i, 1);
			}
			lblnormal.Text=palabra;
			lblrevez.Text=invertida;
		}
		
		void BtnregresaClick(object sender, EventArgs e)
		{
			frmMenu mmm = new frmMenu();
			mmm.Show();
			this.Hide();
		}
	}
}
