using System;
using System.Windows.Forms;

namespace TRABAJO
{
    public partial class Mayor_a_Menor : Form
    {
        int limite = 100;
        double[] numeros;
        int contador = 0;

        public Mayor_a_Menor()
        {
            InitializeComponent();
            numeros = new double[limite];
        }

        private void BtnAgregarClick(object sender, EventArgs e)
        {
            if (contador >= numeros.Length)
            {
                MessageBox.Show("Se alcanzó el límite máximo de 100 números.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double numeroIngresado;
            if (double.TryParse(txtNumero.Text.Trim(), out numeroIngresado))
            {
                numeros[contador] = numeroIngresado;
                contador++;
                
                txtNumero.Clear();
                txtNumero.Focus();
                this.Text = "Mayor a Menor - Guardados: " + contador;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.SelectAll();
                txtNumero.Focus();
            }
        }

        private void BtnOrdenarClick(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("Agrega al menos un número primero.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
                return;
            }

            // Ordenar de Mayor a Menor
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = 0; j < contador - 1 - i; j++)
                {
                    if (numeros[j] < numeros[j + 1])
                    {
                        double temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }

            // Mostrar los números ordenados en el ListBox
            lstResultado.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                lstResultado.Items.Add(numeros[i]);
            }
        }
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void RegresarToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmMenu mmm = new frmMenu();
			mmm.Show();
			this.Hide();
		}
    }
}
