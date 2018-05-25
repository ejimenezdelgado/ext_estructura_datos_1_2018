using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Libreria.Controlador;
using Libreria.Entidades;

namespace Libreria.Vista
{
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();
            this.CargarDatos();
        }

        public void CargarDatos()
        {
            ControladorLibro oControladorLibro = new ControladorLibro();
            dtgLibros.DataSource = oControladorLibro.Todos().ToList();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControladorLibro oControladorLibro = new ControladorLibro();
            FrmAgregarLibro oFrmAgregarLibro = new FrmAgregarLibro();
            oFrmAgregarLibro.ShowDialog();
            int maximo = 0;
            try
            {
                maximo = Program.libros.Max(x => x.Id);
            }
            catch (Exception)
            {
            }
            if (oFrmAgregarLibro.txtAutor.Text != "" && oFrmAgregarLibro.txtTitulo.Text != "")
            {
                oControladorLibro.Agregar(new Libro()
                {
                    Id = maximo + 1,
                    Autor = oFrmAgregarLibro.txtAutor.Text,
                    Titulo = oFrmAgregarLibro.txtTitulo.Text
                });
                this.CargarDatos();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgLibros.SelectedRows.Count > 0)
            {
                ControladorLibro oControladorLibro = new ControladorLibro();
                DataGridViewRow datos = dtgLibros.SelectedRows[0];
                FrmEditarLibro oFrmEditarLibro = new FrmEditarLibro
                {
                    lblId = {Text = datos.Cells["Id"].Value.ToString()},
                    txtTitulo = {Text = datos.Cells["Titulo"].Value.ToString()},
                    txtAutor = {Text = datos.Cells["Autor"].Value.ToString()}
                };
                oFrmEditarLibro.ShowDialog();
                if (oFrmEditarLibro.txtAutor.Text != "" && oFrmEditarLibro.txtTitulo.Text != "")
                {
                    oControladorLibro.Editar(new Libro()
                    {
                        Id = Int32.Parse(oFrmEditarLibro.lblId.Text),
                        Autor = oFrmEditarLibro.txtAutor.Text,
                        Titulo = oFrmEditarLibro.txtTitulo.Text
                    });
                }
            }
            this.CargarDatos();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgLibros.SelectedRows.Count > 0)
            {
                ControladorLibro oControladorLibro = new ControladorLibro();
                DataGridViewRow datos = dtgLibros.SelectedRows[0];
                oControladorLibro.Eliminar(new Libro()
                {
                    Id = Int32.Parse(datos.Cells["Id"].Value.ToString()),
                    Titulo = datos.Cells["Titulo"].Value.ToString(),
                    Autor = datos.Cells["Autor"].Value.ToString()
                });
            }
            this.CargarDatos();
        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
        }
    }
}
