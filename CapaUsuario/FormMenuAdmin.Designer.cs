namespace CapaUsuario
{
    partial class FormMenuAdmin
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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnTipoUsu = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnReparacion = new System.Windows.Forms.Button();
            this.btnReparador = new System.Windows.Forms.Button();
            this.btnEquipoRep = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(12, 92);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(260, 23);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Administrar Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnTipoUsu
            // 
            this.btnTipoUsu.Location = new System.Drawing.Point(12, 121);
            this.btnTipoUsu.Name = "btnTipoUsu";
            this.btnTipoUsu.Size = new System.Drawing.Size(260, 23);
            this.btnTipoUsu.TabIndex = 1;
            this.btnTipoUsu.Text = "Administrar Tipos de Usuarios";
            this.btnTipoUsu.UseVisualStyleBackColor = true;
            this.btnTipoUsu.Click += new System.EventHandler(this.btnTipoUsu_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(12, 295);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(260, 23);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnReparacion
            // 
            this.btnReparacion.Location = new System.Drawing.Point(12, 150);
            this.btnReparacion.Name = "btnReparacion";
            this.btnReparacion.Size = new System.Drawing.Size(260, 23);
            this.btnReparacion.TabIndex = 3;
            this.btnReparacion.Text = "Administrar Reparaciones";
            this.btnReparacion.UseVisualStyleBackColor = true;
            this.btnReparacion.Click += new System.EventHandler(this.btnReparacion_Click);
            // 
            // btnReparador
            // 
            this.btnReparador.Location = new System.Drawing.Point(12, 266);
            this.btnReparador.Name = "btnReparador";
            this.btnReparador.Size = new System.Drawing.Size(260, 23);
            this.btnReparador.TabIndex = 4;
            this.btnReparador.Text = "Ver Reparadores";
            this.btnReparador.UseVisualStyleBackColor = true;
            this.btnReparador.Click += new System.EventHandler(this.btnReparador_Click);
            // 
            // btnEquipoRep
            // 
            this.btnEquipoRep.Location = new System.Drawing.Point(12, 237);
            this.btnEquipoRep.Name = "btnEquipoRep";
            this.btnEquipoRep.Size = new System.Drawing.Size(260, 23);
            this.btnEquipoRep.TabIndex = 5;
            this.btnEquipoRep.Text = "Ver Equipos a Reparar";
            this.btnEquipoRep.UseVisualStyleBackColor = true;
            this.btnEquipoRep.Click += new System.EventHandler(this.btnEquipoRep_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Location = new System.Drawing.Point(12, 179);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(260, 23);
            this.btnEntrega.TabIndex = 6;
            this.btnEntrega.Text = "Administrar Entregas";
            this.btnEntrega.UseVisualStyleBackColor = true;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 208);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(260, 23);
            this.btnCliente.TabIndex = 7;
            this.btnCliente.Text = "Administrar Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnArticulo
            // 
            this.btnArticulo.Location = new System.Drawing.Point(12, 63);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(260, 23);
            this.btnArticulo.TabIndex = 8;
            this.btnArticulo.Text = "Administrar Articulos";
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(260, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 330);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnEntrega);
            this.Controls.Add(this.btnEquipoRep);
            this.Controls.Add(this.btnReparador);
            this.Controls.Add(this.btnReparacion);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnTipoUsu);
            this.Controls.Add(this.btnUsuario);
            this.Name = "FormMenuAdmin";
            this.Text = "FormMenuAdmin";
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnTipoUsu;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnReparacion;
        private System.Windows.Forms.Button btnReparador;
        private System.Windows.Forms.Button btnEquipoRep;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Button btnCerrar;
    }
}