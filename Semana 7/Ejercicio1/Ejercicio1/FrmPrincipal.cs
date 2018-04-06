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
                if (arregloNumeros[i] == null)
                {
                    arregloNumeros[i] = Convert.ToInt32(txtNumero.Value);
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            arregloNumeros=new int[Convert.ToInt32(txtIniciador.Value)];
        }
    }
}
