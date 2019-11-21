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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(260, 23);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Administrar Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnTipoUsu
            // 
            this.btnTipoUsu.Location = new System.Drawing.Point(12, 41);
            this.btnTipoUsu.Name = "btnTipoUsu";
            this.btnTipoUsu.Size = new System.Drawing.Size(260, 23);
            this.btnTipoUsu.TabIndex = 1;
            this.btnTipoUsu.Text = "Administrar Tipos de Usuarios";
            this.btnTipoUsu.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(12, 218);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(260, 23);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnReparacion
            // 
            this.btnReparacion.Location = new System.Drawing.Point(12, 70);
            this.btnReparacion.Name = "btnReparacion";
            this.btnReparacion.Size = new System.Drawing.Size(260, 23);
            this.btnReparacion.TabIndex = 3;
            this.btnReparacion.Text = "Administrar Reparacion";
            this.btnReparacion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Administrar Tipos de Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReparacion);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnTipoUsu);
            this.Controls.Add(this.btnUsuario);
            this.Name = "FormMenuAdmin";
            this.Text = "FormMenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnTipoUsu;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnReparacion;
        private System.Windows.Forms.Button button1;
    }
}