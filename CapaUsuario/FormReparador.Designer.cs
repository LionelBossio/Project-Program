namespace CapaUsuario
{
    partial class FormReparador
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
            this.lblCantrep = new System.Windows.Forms.Label();
            this.lblCantcliante = new System.Windows.Forms.Label();
            this.nupCantrep = new System.Windows.Forms.NumericUpDown();
            this.nupCantcliente = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlReparador = new System.Windows.Forms.Panel();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvReparador = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantcliente)).BeginInit();
            this.pnlReparador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantrep
            // 
            this.lblCantrep.AutoSize = true;
            this.lblCantrep.Location = new System.Drawing.Point(14, 20);
            this.lblCantrep.Name = "lblCantrep";
            this.lblCantrep.Size = new System.Drawing.Size(94, 13);
            this.lblCantrep.TabIndex = 0;
            this.lblCantrep.Text = "Cantidad reparada";
            // 
            // lblCantcliante
            // 
            this.lblCantcliante.AutoSize = true;
            this.lblCantcliante.Location = new System.Drawing.Point(14, 48);
            this.lblCantcliante.Name = "lblCantcliante";
            this.lblCantcliante.Size = new System.Drawing.Size(139, 13);
            this.lblCantcliante.TabIndex = 1;
            this.lblCantcliante.Text = "Cantidad Cliente antendidos";
            // 
            // nupCantrep
            // 
            this.nupCantrep.Location = new System.Drawing.Point(156, 19);
            this.nupCantrep.Name = "nupCantrep";
            this.nupCantrep.Size = new System.Drawing.Size(120, 20);
            this.nupCantrep.TabIndex = 2;
            // 
            // nupCantcliente
            // 
            this.nupCantcliente.Location = new System.Drawing.Point(156, 47);
            this.nupCantcliente.Name = "nupCantcliente";
            this.nupCantcliente.Size = new System.Drawing.Size(120, 20);
            this.nupCantcliente.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(384, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(303, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlReparador
            // 
            this.pnlReparador.Controls.Add(this.cmbUsuario);
            this.pnlReparador.Controls.Add(this.lblUsuario);
            this.pnlReparador.Controls.Add(this.nupCantcliente);
            this.pnlReparador.Controls.Add(this.nupCantrep);
            this.pnlReparador.Controls.Add(this.lblCantcliante);
            this.pnlReparador.Controls.Add(this.lblCantrep);
            this.pnlReparador.Location = new System.Drawing.Point(12, 240);
            this.pnlReparador.Name = "pnlReparador";
            this.pnlReparador.Size = new System.Drawing.Size(288, 105);
            this.pnlReparador.TabIndex = 6;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(156, 73);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(120, 21);
            this.cmbUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(14, 78);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(343, 287);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(343, 256);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvReparador
            // 
            this.dgvReparador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReparador.Location = new System.Drawing.Point(12, 44);
            this.dgvReparador.Name = "dgvReparador";
            this.dgvReparador.Size = new System.Drawing.Size(447, 169);
            this.dgvReparador.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(384, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(366, 20);
            this.txtBuscar.TabIndex = 25;
            // 
            // FormReparador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 379);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvReparador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pnlReparador);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FormReparador";
            this.Text = "FormReparador";
            this.Load += new System.EventHandler(this.FormReparador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCantrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantcliente)).EndInit();
            this.pnlReparador.ResumeLayout(false);
            this.pnlReparador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantrep;
        private System.Windows.Forms.Label lblCantcliante;
        private System.Windows.Forms.NumericUpDown nupCantrep;
        private System.Windows.Forms.NumericUpDown nupCantcliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlReparador;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvReparador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblUsuario;
    }
}