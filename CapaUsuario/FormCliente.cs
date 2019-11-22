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
    public partial class FormCliente : Form
    {
        private Cliente cli;
        private string anterior;

        public FormCliente()
        {
            InitializeComponent();
            pnlCliente.Enabled = false;
            Buscar(txtBuscar.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string buscado)
        {
            try
            {
                dgvClientes.DataSource = Cliente.Buscar(buscado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            cli = new Cliente();
        }

        private void ZonaDatos(bool mostrar)
        {
            txtNombre.Text = "";
            nupTel.Value = 0;
            pnlCliente.Enabled = mostrar;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    ZonaDatos(true);
                    cli = dgvClientes.CurrentRow.DataBoundItem as Cliente;

                    txtNombre.Text = cli.Nombre;
                    nupTel.Value = cli.Telefono;
                }
                else
                    MessageBox.Show("Seleccione un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al extraer informacion para modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    cli = dgvClientes.CurrentRow.DataBoundItem as Cliente;
                    if (MessageBox.Show("¿Quiere eliminar a " + cli.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cli.Eliminar();
                        Buscar(txtBuscar.Text);
                    }
                }
                else
                    MessageBox.Show("Seleccione un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al tratar de eliminar el cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ZonaDatos(false);
            cli = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cli.Nombre = txtNombre.Text;
                cli.Telefono = Convert.ToInt32(nupTel.Value);
                cli.Guardar();
                ZonaDatos(false);
                Buscar(txtBuscar.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
