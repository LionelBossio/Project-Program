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
        private string anterior;

        public FormEquipoRep()
        {
            InitializeComponent();
            pnlEquipoRep.Enabled = false;
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
                dgvEquipoRep.DataSource = Equiporep.Buscar(buscado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEquipoRep.CurrentRow!= null)
            {
                ZonaDatos(true);
                eqrep = dgvEquipoRep.CurrentRow.DataBoundItem as Equiporep;

                txtProblem.Text = eqrep.Problema;
                txtDesc.Text = eqrep.Desc;
            }
            else
                MessageBox.Show("Seleccione un Equipo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al extraer informacion para modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ZonaDatos(bool mostrar)
        {
            txtProblem.Text = "";
            txtDesc.Text = "";
            pnlEquipoRep.Enabled=mostrar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            eqrep = new Equiporep();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEquipoRep.CurrentRow != null)
            {
                eqrep = dgvEquipoRep.CurrentRow.DataBoundItem as Equiporep;
                if (MessageBox.Show("¿Quiere eliminar" + eqrep.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    eqrep.Eliminar();
                    Buscar(txtBuscar.Text);
                }
            }
            else
                MessageBox.Show("Seleccione un Equipo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al tratar de eliminar el equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                eqrep.Problema = txtProblem.Text;
                eqrep.Desc = txtDesc.Text;
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        public void Anterior(string ant)
        {
            anterior = ant;
        }

        private void FormEquipoRep_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (anterior == "r")
            {
                FormMenuRecepcion f = new FormMenuRecepcion();
                f.Show();
            }
            if (anterior == "a")
            {
                FormMenuAdmin f = new FormMenuAdmin();
                f.Show();
            }
            if (anterior == "re")
            {
                FormInicio f = new FormInicio();
                f.Show();
            }
        }

        private void FormEquipoRep_Load(object sender, EventArgs e)
        {
            ZonaDatos(false);
            Buscar(txtBuscar.Text);
        }
    }
}
