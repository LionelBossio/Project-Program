﻿using System;
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
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void Mostrar()
        {
            this.DTArticuloTableAdapter.Connection.ConnectionString = Conexion.DarConexion();
            this.DTArticuloTableAdapter.Fill(this.DataSet.DTArticulo);
            
            this.rv.RefreshReport();

        }
    }
}
