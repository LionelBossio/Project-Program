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
    public partial class FormInicio : Form
    {
        private Usuario user;
        private List<Usuario> Usuarios = new List<Usuario>();
        public FormInicio()
        {
            InitializeComponent();
            user = null;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                user = VerificarUsuario();
                if (user != null)
                {
                    if (user.Tipousu.Tipodeusu.ToLower() == "administrador")
                    {
                        FormMenuAdmin f = new FormMenuAdmin();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (user.Tipousu.Tipodeusu.ToLower() == "reparador")
                        {
                            FormEquipoRep f = new FormEquipoRep();
                            f.Anterior("re");
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            FormMenuRecepcion f = new FormMenuRecepcion();
                            f.Show();
                            this.Hide();
                        }
                    }
                }
                else
                    MessageBox.Show("Usuario o contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al iniciar sesion, vuelva a intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            user = null;
        }

        public Usuario VerificarUsuario()
        {
            Usuarios = Usuario.Buscar();
            var res = from x in Usuarios
                      where x.Nomusu == txtUsuario.Text
                      && x.Contraseña == txtContra.Text
                      select x;

            if (res != null)
            {
                var x = res.First();
                return new Usuario(x.Idusu, x.Nombre, x.Apellido, x.Dni, x.Fecnac, x.Email, x.Fktipousu, x.Numtel, x.Nomusu, x.Contraseña);
            }
            else
            {
                return null;
            }
        }

        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
