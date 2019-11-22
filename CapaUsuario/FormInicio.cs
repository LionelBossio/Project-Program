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

        private void FormInicio_Load(object sender, EventArgs e)
        {

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
                        this.Hide();
                        f.Show();
                    }
                    else
                    {
                        if (user.Tipousu.Tipodeusu.ToLower() == "reparador")
                        {
                            FormEquipoRep f = new FormEquipoRep();
                            this.Hide();
                            f.Show();
                        }
                        else
                        {
                            FormMenuRecepcion f = new FormMenuRecepcion();
                            this.Hide();
                            f.Show();
                        }
                    }
                }
                else
                    MessageBox.Show("Usuario o contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public Usuario VerificarUsuario()
        {
            Usuarios = Usuario.Buscar();
            var res = from x in Usuarios
                      where x.Nombre == txtUsuario.Text
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
    }
}
