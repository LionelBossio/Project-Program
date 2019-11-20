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
    public partial class FormTipoUsuario : Form
    {
        private Tipousu tip;
        public FormTipoUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string buscado)
        {
            dgvTipoUsu.DataSource = Tipousu.Buscar(buscado);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTipoUsu.CurrentRow!= null)
            {
                ZonaDatos(true);
                tip = dgvTipoUsu.CurrentRow.DataBoundItem as Tipousu;
                txtDesc.Text = tip.Desc;
                txtTipousu.Text = tip.Tipodeusu;
            }
            else
                MessageBox.Show("Seleccione un Tipo de usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ZonaDatos(bool mostrar)
        {
            txtDesc.Text = "";
            txtTipousu.Text = "";
            pnlTipoUsu.Enabled = mostrar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            tip = new Tipousu();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvTipoUsu.CurrentRow!=null)
            {
                tip = dgvTipoUsu.CurrentRow.DataBoundItem as Tipousu;
                if (MessageBox.Show("¿Quiere eliminar" + tip.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tip.Eliminar();
                }
            }
            else
                MessageBox.Show("Seleccione un Tipo de usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                tip.Desc = txtDesc.Text;
                tip.Tipodeusu = txtTipousu.Text;
                tip.Guardar();
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
            tip = null;
        }
    }
}
