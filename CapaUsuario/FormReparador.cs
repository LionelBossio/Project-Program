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
    public partial class FormReparador : Form
    {
        private Reparador rep;
        public FormReparador()
        {
            InitializeComponent();
            pnlReparador.Enabled = false;
            Buscar(txtBuscar.Text);
            rep = new Reparador();
        }

        private void FormReparador_Load(object sender, EventArgs e)
        {
            cmbUsuario.DataSource = Usuario.Buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string buscado)
        {
            dgvReparador.DataSource = Reparador.Buscar(buscado);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvReparador.CurrentRow != null)
            {
                ZonaDatos(true);
                rep = dgvReparador.CurrentRow.DataBoundItem as Reparador;
                nupCantcliente.Value = rep.Cantcliente;
                nupCantrep.Value = rep.Cantrep;
                cmbUsuario.Text = rep.Usuario.Nombre;
            }
            else
                MessageBox.Show("Seleccione un Reparador", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ZonaDatos(bool mostrar)
        {
            nupCantrep.Value = 0;
            nupCantcliente.Value = 0;
            cmbUsuario.Text = "";
            pnlReparador.Enabled = mostrar;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvReparador.CurrentRow!=null)
            {
                rep = dgvReparador.CurrentRow.DataBoundItem as Reparador;
                if (MessageBox.Show("¿Quiere eliminar el Reparador " + rep.ToString() + "? Si lo elimina, su usuario tambien se eliminara", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    rep.Usuario.Eliminar();
                    rep.Eliminar();
                    Buscar(txtBuscar.Text);
                }
            }
            else
                MessageBox.Show("Seleccione un reparador", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                rep.Cantcliente = Convert.ToInt32(nupCantcliente.Value);
                rep.Cantrep = Convert.ToInt32(nupCantrep.Value);
                rep.Usuario = cmbUsuario.SelectedItem as Usuario;
                rep.Guardar();
                ZonaDatos(false);
                Buscar(txtBuscar.Text);
                rep = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ZonaDatos(false);
            rep = null;
        }
    }
}
