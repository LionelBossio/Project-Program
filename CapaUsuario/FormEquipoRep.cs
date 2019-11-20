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
              //  cmbCliente.Text=eqrep.--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            }
        }

        private void ZonaDatos(bool mostrar)
        {
            txtProblem.Text = "";
            txtDesc.Text = "";
            cmbCliente.Text = "";
        }
    }
}
