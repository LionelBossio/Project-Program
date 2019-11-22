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
        private Usuario backup;
        private Usuario original;
        private Reparador rep;
        private bool nuevo;
        public FormUsuario()
        {
            InitializeComponent();
            rep = null;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            cmbTipousu.DataSource = Tipousu.Buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string buscado)
        {
            try
            {
                dgvUsuario.DataSource = Usuario.Buscar(buscado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            nuevo = true;
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
            try
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

                    original = user;
                    nuevo = false;
                }
                else
                    MessageBox.Show("Seleccione un Usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al tratar de eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nuevo)
                {
                    if (user.Verificar(txtNomusu.Text,0,Convert.ToInt32(nupDni.Value)))
                    {
                        GuardarUsu();
                        if (cmbTipousu.Text == "Reparador") //------------------- Si es reparador lo crea--------------------------------
                        {
                            backup = backup.BuscarPorNomUsu(txtNomusu.Text);
                            rep = new Reparador();
                            rep.Cantcliente = 0;
                            rep.Cantrep = 0;
                            rep.Fkusuario = backup.Idusu;
                            rep.Guardar();
                        }
                    }
                    else
                        MessageBox.Show("Ya existe alguien con ese nombre de usuario o dni", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (user.Verificar(txtNomusu.Text, original.Idusu, Convert.ToInt32(nupDni.Value)))
                    {
                        if (original.Tipousu.Tipodeusu == cmbTipousu.Text)
                        {
                            GuardarUsu();
                        }
                        else
                        {
                            if (cmbTipousu.Text == "Reparador") //------------------- Si es reparador lo crea--------------------------------
                            {
                                backup = backup.BuscarPorNomUsu(original.Nombre);
                                rep = new Reparador();
                                rep.Cantcliente = 0;
                                rep.Cantrep = 0;
                                rep.Fkusuario = backup.Idusu;
                                rep.Guardar();
                                GuardarUsu();
                            }
                            else                                //------------------- Si era reparador y ya no, lo elimina------------------
                            {
                                rep = Reparador.BuscarPorIdUsu(original.Idusu);
                                rep.Eliminar();
                                GuardarUsu();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Ya existe alguien con ese nombre de usuario o dni", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                ZonaDatos(false);
                Buscar(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void GuardarUsu()
        {
            user.Nombre = txtNombre.Text;
            user.Apellido = txtApellido.Text;
            user.Contraseña = txtContra.Text;
            user.Nomusu = txtNomusu.Text;
            user.Dni = Convert.ToInt32(nupDni.Value);
            user.Fecnac = dtpFecnac.Value;
            user.Email = txtEmail.Text;
            user.Numtel = Convert.ToInt32(nupNumtel.Value);
            user.Tipousu = cmbTipousu.SelectedItem as Tipousu;
            user.Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ZonaDatos(false);
            nuevo = true;
            original = null;
            user = null;
            rep = null;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormMenuAdmin f = new FormMenuAdmin();
            f.Show();
            this.Close();
        }

    }
}
