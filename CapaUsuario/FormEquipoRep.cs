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
    public partial class FormEquipoRep : Form
    {
        private Equiporep eqrep;
        public FormEquipoRep()
        {
            InitializeComponent();
        }

        private void FormEquipoRep_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = Cliente.Buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string buscado)
        {
            dgvEquipoRep.DataSource = Equiporep.Buscar(buscado);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEquipoRep.CurrentRow!= null)
            {
                ZonaDatos(true);
                eqrep = dgvEquipoRep.CurrentRow.DataBoundItem as Equiporep;

                txtProblem.Text = eqrep.Problema;
                txtDesc.Text = eqrep.Desc;
                cmbCliente.Text = eqrep.Cliente.ToString();
            }
            else
                MessageBox.Show("Seleccione un Equipo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ZonaDatos(bool mostrar)
        {
            txtProblem.Text = "";
            txtDesc.Text = "";
            cmbCliente.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            eqrep = new Equiporep();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquipoRep.CurrentRow != null)
            {
                eqrep = dgvEquipoRep.CurrentRow.DataBoundItem as Equiporep;
                if (MessageBox.Show("¿Quiere eliminar" + eqrep.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    eqrep.Eliminar();
                }
            }
            else
                MessageBox.Show("Seleccione un Equipo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                eqrep.Problema = txtProblem.Text;
                eqrep.Desc = txtDesc.Text;
                eqrep.Cliente = cmbCliente.SelectedItem as Cliente;
                eqrep.Guardar();
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
            eqrep = null;
        }
    }
}
