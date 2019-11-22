namespace CapaUsuario
{
    partial class FormReparacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEntrega = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecini = new System.Windows.Forms.Label();
            this.lblEquiporep = new System.Windows.Forms.Label();
            this.lblRep = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbEquiprep = new System.Windows.Forms.ComboBox();
            this.cmbRep = new System.Windows.Forms.ComboBox();
            this.cmbEntrega = new System.Windows.Forms.ComboBox();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvReparacion = new System.Windows.Forms.DataGridView();
            this.dtpFecInicio = new System.Windows.Forms.DateTimePicker();
            this.pnlReparacion = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparacion)).BeginInit();
            this.pnlReparacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Location = new System.Drawing.Point(17, 118);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(44, 13);
            this.lblEntrega.TabIndex = 0;
            this.lblEntrega.Text = "Entrega";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 14);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecini
            // 
            this.lblFecini.AutoSize = true;
            this.lblFecini.Location = new System.Drawing.Point(17, 37);
            this.lblFecini.Name = "lblFecini";
            this.lblFecini.Size = new System.Drawing.Size(79, 13);
            this.lblFecini.TabIndex = 2;
            this.lblFecini.Text = "Fecha de inicio";
            // 
            // lblEquiporep
            // 
            this.lblEquiporep.AutoSize = true;
            this.lblEquiporep.Location = new System.Drawing.Point(17, 65);
            this.lblEquiporep.Name = "lblEquiporep";
            this.lblEquiporep.Size = new System.Drawing.Size(85, 13);
            this.lblEquiporep.TabIndex = 3;
            this.lblEquiporep.Text = "Equipo a reparar";
            // 
            // lblRep
            // 
            this.lblRep.AutoSize = true;
            this.lblRep.Location = new System.Drawing.Point(17, 94);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(57, 13);
            this.lblRep.TabIndex = 4;
            this.lblRep.Text = "Reparador";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(17, 144);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(42, 13);
            this.lblArticulo.TabIndex = 5;
            this.lblArticulo.Text = "Articulo";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(108, 11);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(200, 21);
            this.cmbCliente.TabIndex = 6;
            // 
            // cmbEquiprep
            // 
            this.cmbEquiprep.FormattingEnabled = true;
            this.cmbEquiprep.Location = new System.Drawing.Point(108, 62);
            this.cmbEquiprep.Name = "cmbEquiprep";
            this.cmbEquiprep.Size = new System.Drawing.Size(200, 21);
            this.cmbEquiprep.TabIndex = 8;
            // 
            // cmbRep
            // 
            this.cmbRep.FormattingEnabled = true;
            this.cmbRep.Location = new System.Drawing.Point(108, 89);
            this.cmbRep.Name = "cmbRep";
            this.cmbRep.Size = new System.Drawing.Size(200, 21);
            this.cmbRep.TabIndex = 9;
            // 
            // cmbEntrega
            // 
            this.cmbEntrega.FormattingEnabled = true;
            this.cmbEntrega.Location = new System.Drawing.Point(108, 116);
            this.cmbEntrega.Name = "cmbEntrega";
            this.cmbEntrega.Size = new System.Drawing.Size(200, 21);
            this.cmbEntrega.TabIndex = 10;
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(108, 143);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(200, 21);
            this.cmbArticulo.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(354, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvReparacion
            // 
            this.dgvReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReparacion.Location = new System.Drawing.Point(12, 38);
            this.dgvReparacion.Name = "dgvReparacion";
            this.dgvReparacion.Size = new System.Drawing.Size(498, 166);
            this.dgvReparacion.TabIndex = 13;
            // 
            // dtpFecInicio
            // 
            this.dtpFecInicio.Location = new System.Drawing.Point(108, 36);
            this.dtpFecInicio.Name = "dtpFecInicio";
            this.dtpFecInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFecInicio.TabIndex = 14;
            // 
            // pnlReparacion
            // 
            this.pnlReparacion.Controls.Add(this.dtpFecInicio);
            this.pnlReparacion.Controls.Add(this.cmbArticulo);
            this.pnlReparacion.Controls.Add(this.cmbEntrega);
            this.pnlReparacion.Controls.Add(this.cmbRep);
            this.pnlReparacion.Controls.Add(this.cmbEquiprep);
            this.pnlReparacion.Controls.Add(this.cmbCliente);
            this.pnlReparacion.Controls.Add(this.lblArticulo);
            this.pnlReparacion.Controls.Add(this.lblRep);
            this.pnlReparacion.Controls.Add(this.lblEquiporep);
            this.pnlReparacion.Controls.Add(this.lblFecini);
            this.pnlReparacion.Controls.Add(this.lblCliente);
            this.pnlReparacion.Controls.Add(this.lblEntrega);
            this.pnlReparacion.Location = new System.Drawing.Point(12, 217);
            this.pnlReparacion.Name = "pnlReparacion";
            this.pnlReparacion.Size = new System.Drawing.Size(318, 178);
            this.pnlReparacion.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(390, 289);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(390, 254);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(390, 220);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(435, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(435, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(417, 20);
            this.txtBuscar.TabIndex = 24;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(354, 362);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(156, 33);
            this.btnAtras.TabIndex = 26;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 405);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlReparacion);
            this.Controls.Add(this.dgvReparacion);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormReparacion";
            this.Text = "FormReparacion";
            this.Load += new System.EventHandler(this.FormReparacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparacion)).EndInit();
            this.pnlReparacion.ResumeLayout(false);
            this.pnlReparacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecini;
        private System.Windows.Forms.Label lblEquiporep;
        private System.Windows.Forms.Label lblRep;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbEquiprep;
        private System.Windows.Forms.ComboBox cmbRep;
        private System.Windows.Forms.ComboBox cmbEntrega;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvReparacion;
        private System.Windows.Forms.DateTimePicker dtpFecInicio;
        private System.Windows.Forms.Panel pnlReparacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAtras;
    }
}