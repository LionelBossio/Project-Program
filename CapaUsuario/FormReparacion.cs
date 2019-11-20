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
    public partial class FormReparacion : Form
    {
        private Reparacion rep;
        public FormReparacion()
        {
            InitializeComponent();
        }

        private void FormReparacion_Load(object sender, EventArgs e)
        {
            cmbArticulo.DataSource = Articulo.Buscar();
            cmbCliente.DataSource = Cliente.Buscar();
            cmbEntrega.DataSource = Entrega.Buscar();
            cmbEquiprep.DataSource = Equiporep.Buscar();
            cmbRep.DataSource = Reparador.Buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string buscado)
        {
            dgvReparacion.DataSource = Reparacion.Buscar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvReparacion.CurrentRow!= null)
            {
                ZonaDatos(true);
                rep = dgvReparacion.CurrentRow.DataBoundItem as Reparacion;

                cmbArticulo.Text = rep.Articulo.ToString();
                cmbCliente.Text = rep.Cliente.ToString();
                cmbEntrega.Text = rep.Entrega.ToString();
                cmbEquiprep.Text = rep.Equiporep.ToString();
                cmbRep.Text = rep.Reparador.ToString();
                dtpFecInicio.Value = rep.Fecini;
            }
            else
                MessageBox.Show("Seleccione una Reparacion", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void ZonaDatos(bool mostrar)
        {
            cmbArticulo.Text = "";
            cmbCliente.Text = "";
            cmbEntrega.Text = "";
            cmbEquiprep.Text = "";
            cmbRep.Text = "";
            dtpFecInicio.Value = DateTime.Now;
            pnlReparacion.Enabled = mostrar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            rep = new Reparacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvReparacion.CurrentRow!=null)
            {
                rep = dgvReparacion.CurrentRow.DataBoundItem as Reparacion;
                if (MessageBox.Show("¿Quiere eliminar" + rep.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rep.Eliminar();
                }
            }
            else
                MessageBox.Show("Seleccione un artículo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                rep.Articulo = cmbArticulo.SelectedItem as Articulo;
                rep.Cliente = cmbCliente.SelectedItem as Cliente;
                rep.Entrega = cmbEntrega.SelectedItem as Entrega;
                rep.Equiporep = cmbEquiprep.SelectedItem as Equiporep;
                rep.Reparador = cmbRep.SelectedItem as Reparador;
                rep.Fecini = dtpFecInicio.Value;
                rep.Guardar();
                ZonaDatos(false);
                Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ZonaDatos(false);
            rep = null;
        }
    }
}
