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
    public partial class FormMenuRecepcion : Form
    {
        public FormMenuRecepcion()
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
            f.Anterior("r");
            f.Show();
            this.Hide();
        }

        private void btnReparacion_Click(object sender, EventArgs e)
        {
            FormReparacion f = new FormReparacion();
            f.Anterior("r");
            f.Show();
            this.Hide();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            FormEntrega f = new FormEntrega();
            f.Anterior("r");
            f.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente();
            f.Anterior("r");
            f.Show();
            this.Hide();
        }

        private void btnEquipoRep_Click(object sender, EventArgs e)
        {
            FormEquipoRep f = new FormEquipoRep();
            f.Anterior("r");
            f.Show();
            this.Hide();
        }

        private void btnReparador_Click(object sender, EventArgs e)
        {
            FormReparador f = new FormReparador();
            f.Anterior("r");
            f.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes f = new FormReportes();
            f.Anterior("r");
            f.Show();
            this.Hide();
        }

        private void FormMenuRecepcion_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormInicio login = new FormInicio();
            login.Show();
        }
    }
}
