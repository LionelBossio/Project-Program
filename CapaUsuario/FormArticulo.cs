using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUsuario
{
    public partial class FormArticulo : Form
    {
        private Articulo art;
        private string anterior;

        public FormArticulo()
        {
            InitializeComponent();
            ZonadeDatos(false);
        }
        private void ZonadeDatos(bool mostrar)
        {
            txtNombre.Text = "";
            txtDesc.Text = "";
            nupCant.Value = 0;
            pnlDatos.Enabled = mostrar;
        }
        private void CargarSeleccionado()
        {
            txtNombre.Text = art.Nombre;
            txtDesc.Text = art.Desc;
            nupCant.Value = (int)art.Cant;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ZonadeDatos(false);
            art = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                art.Nombre = txtNombre.Text;
                art.Desc = txtDesc.Text;
                art.Cant = (int)nupCant.Value;
                art.Guardar();
                ZonadeDatos(false);
                Buscar(txtBuscar.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonadeDatos(true);
            art = new Articulo();
        }

        private void Buscar(string buscado)
        {
            dgvArticulo.DataSource = Articulo.Buscar(buscado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                art = dgvArticulo.CurrentRow.DataBoundItem as Articulo;
                if (MessageBox.Show("¿Quiere eliminar" + " " + art.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    art.Eliminar();
                    Buscar(txtBuscar.Text);
                }
            }
            else
                MessageBox.Show("Seleccione un articulo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvArticulo.CurrentRow != null)
            {
                ZonadeDatos(true);
                art = dgvArticulo.CurrentRow.DataBoundItem as Articulo;
                CargarSeleccionado();
            }
            else
                MessageBox.Show("Seleccione un artículo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void FormArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (anterior == "r")
            {
                FormMenuRecepcion f = new FormMenuRecepcion();
                f.Show();
                this.Close();
            }
            if (anterior == "a")
            {
                FormMenuAdmin f = new FormMenuAdmin();
                f.Show();
                this.Close();
            }
        }

        public void Anterior(string ant)
        {
            anterior = ant;
        }
    }
}
