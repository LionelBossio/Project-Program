namespace CapaUsuario
{
    partial class FormMenuRecepcion
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
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.btnEquipoRep = new System.Windows.Forms.Button();
            this.btnReparador = new System.Windows.Forms.Button();
            this.btnReparacion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArticulo
            // 
            this.btnArticulo.Location = new System.Drawing.Point(12, 57);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(260, 23);
            this.btnArticulo.TabIndex = 36;
            this.btnArticulo.Text = "Administrar Articulos";
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 144);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(260, 23);
            this.btnCliente.TabIndex = 35;
            this.btnCliente.Text = "Administrar Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Location = new System.Drawing.Point(12, 115);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(260, 23);
            this.btnEntrega.TabIndex = 34;
            this.btnEntrega.Text = "Administrar Entregas";
            this.btnEntrega.UseVisualStyleBackColor = true;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // btnEquipoRep
            // 
            this.btnEquipoRep.Location = new System.Drawing.Point(12, 173);
            this.btnEquipoRep.Name = "btnEquipoRep";
            this.btnEquipoRep.Size = new System.Drawing.Size(260, 23);
            this.btnEquipoRep.TabIndex = 33;
            this.btnEquipoRep.Text = "Ver Equipos a Reparar";
            this.btnEquipoRep.UseVisualStyleBackColor = true;
            this.btnEquipoRep.Click += new System.EventHandler(this.btnEquipoRep_Click);
            // 
            // btnReparador
            // 
            this.btnReparador.Location = new System.Drawing.Point(12, 202);
            this.btnReparador.Name = "btnReparador";
            this.btnReparador.Size = new System.Drawing.Size(260, 23);
            this.btnReparador.TabIndex = 32;
            this.btnReparador.Text = "Ver Reparadores";
            this.btnReparador.UseVisualStyleBackColor = true;
            this.btnReparador.Click += new System.EventHandler(this.btnReparador_Click);
            // 
            // btnReparacion
            // 
            this.btnReparacion.Location = new System.Drawing.Point(12, 86);
            this.btnReparacion.Name = "btnReparacion";
            this.btnReparacion.Size = new System.Drawing.Size(260, 23);
            this.btnReparacion.TabIndex = 31;
            this.btnReparacion.Text = "Administrar Reparaciones";
            this.btnReparacion.UseVisualStyleBackColor = true;
            this.btnReparacion.Click += new System.EventHandler(this.btnReparacion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(12, 231);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(260, 23);
            this.btnReportes.TabIndex = 30;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(260, 23);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormMenuRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnEntrega);
            this.Controls.Add(this.btnEquipoRep);
            this.Controls.Add(this.btnReparador);
            this.Controls.Add(this.btnReparacion);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormMenuRecepcion";
            this.Text = "FormMenuRecepcion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnEquipoRep;
        private System.Windows.Forms.Button btnReparador;
        private System.Windows.Forms.Button btnReparacion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCerrar;
    }
}