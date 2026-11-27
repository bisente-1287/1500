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
	/// Description of Vocales_y_Consonantes.
	/// </summary>
	public partial class Vocales : Form
	{
		public Vocales()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string palabra = textBox1.Text.ToLower();
			
			int vocales = 0;
			int consonantes = 0;
			string listaVocales = "aeiouáéíóúü";
			
			foreach (char letra in palabra)
			{
				// Verificamos que el carácter sea una letra (ignora números, espacios o símbolos)
				if (char.IsLetter(letra))
				{
					if (listaVocales.Contains(letra.ToString()))
					{
						vocales++;
					}
					else
					{
						consonantes++;
					}
				}
			}
			
			// Mostramos los resultados en las etiquetas
			label1.Text = "Vocales: " + vocales;
			label2.Text = "Consonantes: " + consonantes;
		}
	}
}
