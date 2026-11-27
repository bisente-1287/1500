/*
 * Creado por SharpDevelop.
 * Usuario: tcupl
 * Fecha: 26/11/2026
 * Hora: 08:45 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Contador_de_Vocales_y_Consonantes
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
