using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.Vista;


namespace Libreria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario=String.Empty;
            string contrasena= String.Empty;

            usuario = txtUsuario.Text;
            contrasena = txtContrasena.Text;

            if (usuario == "admin" && contrasena == "admin")
            {
                FrmDashboard oFrmDashboard = new FrmDashboard();
                this.Hide();
                oFrmDashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No nos hakeeen rasta", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
