using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FrmPrincipal : Form
    {
        private int[] arregloNumeros;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                if (arregloNumeros[i] == 0)
                {
                    arregloNumeros[i] = Convert.ToInt32(txtNumero.Value);
                    break;
                }
            }
            txtImpresionNumero.Items.Clear();
            int suma = 0;
            int promedio = 0;
            int max = 0;
            int min = arregloNumeros[0];
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                suma = suma + arregloNumeros[i];
                if (arregloNumeros[i]>max)
                {
                    max = arregloNumeros[i];
                }
                if (arregloNumeros[i] != 0)
                {
                    if (arregloNumeros[i] < min)
                    {
                        min = arregloNumeros[i];
                    }
                }
                txtImpresionNumero.Items.Add(arregloNumeros[i]);
            }
            txtSuma.Text = suma.ToString();
            txtPromedio.Text = (suma/arregloNumeros.Length).ToString();
            txtMaximo.Text = max.ToString();
            txtMinimo.Text = min.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            arregloNumeros=new int[Convert.ToInt32(txtIniciador.Value)];
        }

    }
}
