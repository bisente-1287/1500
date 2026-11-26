using System;
using System.Windows.Forms;

namespace TRABAJO
{
    public partial class Mayor : Form
    {
        double[] numeros = new double[100];
        int contador = 0;

        public Mayor()
        {
            InitializeComponent();
        }

        private void BtnAgregarClick(object sender, EventArgs e)
        {
            if (contador >= numeros.Length)
            {
                MessageBox.Show("Se alcanzó el límite máximo de 100 números.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double numeroIngresado;
            if (double.TryParse(txtNumero.Text, out numeroIngresado))
            {
                numeros[contador] = numeroIngresado;
                contador++;
                txtNumero.Text = "";
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Tamalito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.SelectAll();
                txtNumero.Focus();
            }
        }

        private void BtnCalcularClick(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("Agrega al menos un número primero.", "Error404XD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
                return;
            }

            double mayor = numeros[0];
            double menor = numeros[0];

            for (int i = 1; i < contador; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            lblRespuesta.Text = "mayor = " + mayor;
            lblResultado.Text = "menor = " + menor;
        }
		
		void Label4Click(object sender, EventArgs e)
		{
			
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
