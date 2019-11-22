using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            FormArticulo f = new FormArticulo();
            f.Anterior("a");
            f.Show();
            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario f = new FormUsuario();
            f.Show();
            this.Hide();
        }

        private void btnTipoUsu_Click(object sender, EventArgs e)
        {
            FormTipoUsuario f = new FormTipoUsuario();
            f.Show();
            this.Hide();
        }

        private void btnReparacion_Click(object sender, EventArgs e)
        {
            FormReparacion f = new FormReparacion();
            f.Anterior("a");
            f.Show();
            this.Hide();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            FormEntrega f = new FormEntrega();
            f.Anterior("a");
            f.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente();
            f.Anterior("a");
            f.Show();
            this.Hide();
        }

        private void btnEquipoRep_Click(object sender, EventArgs e)
        {
            FormEquipoRep f = new FormEquipoRep();
            f.Anterior("a");
            f.Show();
            this.Hide();
        }

        private void btnReparador_Click(object sender, EventArgs e)
        {
            FormReparador f = new FormReparador();
            f.Anterior("a");
            f.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes f = new FormReportes();
            f.Anterior("a");
            f.Show();
            this.Hide();
        }

        private void FormMenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormInicio login = new FormInicio();
            login.Show();
        }
    }
}
