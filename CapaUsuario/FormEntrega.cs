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
    public partial class FormEntrega : Form
    {
        private Entrega entr;
        public FormEntrega()
        {
            InitializeComponent();
            pnlEntrega.Enabled = false;
            Buscar(txtBuscar.Text);
        }

        private void FormEntrega_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string buscado)
        {
            dgvEntrega.DataSource = Entrega.Buscar(buscado);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvEntrega.CurrentRow!=null)
            {
                ZonaDatos(true);
                entr = dgvEntrega.CurrentRow.DataBoundItem as Entrega;
                txtDescripcion.Text = entr.Desc;
                ckbHecho.Checked = entr.Hecho;
                dtmFecent.Value = entr.Fecent;
            }
            else
                MessageBox.Show("Seleccione una Entrega", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ZonaDatos(bool mostrar)
        {
            txtDescripcion.Text = "";
            ckbHecho.Checked = false;
            dtmFecent.Value = DateTime.Now;
            pnlEntrega.Enabled = mostrar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            entr = new Entrega();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEntrega.CurrentRow!=null)
            {
                entr = dgvEntrega.CurrentRow.DataBoundItem as Entrega;
                if(MessageBox.Show("¿Quiere eliminar la entrega Nro " + entr.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    entr.Eliminar();
                    Buscar(txtBuscar.Text);
                }
            }
            else
                MessageBox.Show("Seleccione una Entrega", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entr.Desc = txtDescripcion.Text;
                entr.Fecent = dtmFecent.Value;
                entr.Hecho = ckbHecho.Checked;

                entr.Guardar();
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
            entr = null;
        }
    }
}
