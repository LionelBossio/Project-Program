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
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al bajar los reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Atras();
            }
        }
        private void Mostrar()
        {
            this.DTArticuloTableAdapter.Connection.ConnectionString = Conexion.DarConexion();
            this.DTArticuloTableAdapter.Fill(this.DataSet.DTArticulo);
            
            this.rv.RefreshReport();

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
    }
}
