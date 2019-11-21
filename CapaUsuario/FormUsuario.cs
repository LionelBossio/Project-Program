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
    public partial class FormUsuario : Form
    {
        private Usuario user;
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            //cmbRepde.DataSource = Reparador.Buscar();
            cmbTipousu.DataSource = Tipousu.Buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string buscado)
        {
            dgvUsuario.DataSource = Usuario.Buscar(buscado);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            user = new Usuario();
        }

        private void ZonaDatos(bool mostrar)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtContra.Text = "";
            txtNomusu.Text = "";
            nupDni.Value = 0;
            dtpFecnac.Value = DateTime.Now;
            txtEmail.Text = "";
            nupNumtel.Value = 0;
            cmbTipousu.Text = "";
            pnlUsuario.Enabled = mostrar;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow != null)
            {
                ZonaDatos(true);
                user = dgvUsuario.CurrentRow.DataBoundItem as Usuario;

                txtNombre.Text = user.Nombre;
                txtApellido.Text = user.Apellido;
                txtContra.Text = user.Contraseña;
                txtNomusu.Text = user.Nomusu;
                nupDni.Value = user.Dni;
                dtpFecnac.Value = user.Fecnac;
                txtEmail.Text = user.Email;
                nupNumtel.Value = user.Numtel;
                cmbTipousu.Text = user.Tipousu.ToString();
            }
            else
                MessageBox.Show("Seleccione un Usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow != null)
            {
                user = dgvUsuario.CurrentRow.DataBoundItem as Usuario;
                if (MessageBox.Show("¿Quiere eliminar" + user.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    user.Eliminar();
                }
            }
            else
                MessageBox.Show("Seleccione un articulo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                user.Nombre=txtNombre.Text;
                user.Apellido=txtApellido.Text;
                user.Contraseña=txtContra.Text;
                user.Nomusu=txtNomusu.Text;
                user.Dni=Convert.ToInt32(nupDni.Value);
                user.Fecnac= dtpFecnac.Value;
                user.Email=txtEmail.Text;
                user.Numtel= Convert.ToInt32(nupNumtel.Value);
                user.Tipousu=cmbTipousu.SelectedItem as Tipousu;
                user.Guardar();
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
            user = null;
        }
    }
}
