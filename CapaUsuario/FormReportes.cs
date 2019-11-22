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
    public partial class FormReportes : Form
    {
        private string anterior;
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al bajar los reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Atras();
            }
        }
        private void Mostrar(bool articulo)
        {
            if (articulo)
            {
                this.DTArticuloTableAdapter.Connection.ConnectionString = Conexion.DarConexion();
                this.DTArticuloTableAdapter.Fill(this.DataSet.DTArticulo);
                this.rv.RefreshReport();
                rv.Show();
                rvReparador.Hide();
            }
            else
            {
                this.ReparadorTableAdapter.Connection.ConnectionString = Conexion.DarConexion();
                this.ReparadorTableAdapter.Fill(this.DataSetReparador.Reparador);
                this.rvReparador.RefreshReport();
                rvReparador.Show();
                rv.Hide();
            }
            

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Atras();
        }

        public void Anterior(string ant)
        {
            anterior = ant;
        }
   
        public void Atras()
        {
            if (anterior == "r")
            {
                FormMenuRecepcion f = new FormMenuRecepcion();
                f.Show();
                this.Close();
            }
            if (anterior == "a")
            {
                FormMenuAdmin f = new FormMenuAdmin();
                f.Show();
                this.Close();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cbxReportes.SelectedIndex == 0)
            {
                Mostrar(true);
            }
            else
            {
                Mostrar(false);
            }
        }
    }
}
