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
    public partial class FormReparador : Form
    {
        private Reparador rep;
        public FormReparador()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string buscado)
        {
            dgvReparador.DataSource = Reparador.Buscar(buscado);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvReparador.CurrentRow != null)
            {
                ZonaDatos(true);
                rep = dgvReparador.CurrentRow.DataBoundItem as Reparador;
                nupCantcliente.Value = rep.Cantcliente;
                nupCantrep.Value = rep.Cantrep;
            }
            else
                MessageBox.Show("Seleccione un Reparador", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ZonaDatos(bool mostrar)
        {
            nupCantrep.Value = 0;
            nupCantcliente.Value = 0;
            pnlReparador.Enabled = mostrar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            rep = new Reparador();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvReparador.CurrentRow!=null)
            {
                rep = dgvReparador.CurrentRow.DataBoundItem as Reparador;
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
                rep.Cantcliente = Convert.ToInt32(nupCantcliente.Value);
                rep.Cantrep = Convert.ToInt32(nupCantrep.Value);
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
