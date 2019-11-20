namespace CapaUsuario
{
    partial class FormTipoUsuario
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
            this.lblTipousu = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtTipousu = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlTipoUsu = new System.Windows.Forms.Panel();
            this.dgvTipoUsu = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnlTipoUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipousu
            // 
            this.lblTipousu.AutoSize = true;
            this.lblTipousu.Location = new System.Drawing.Point(8, 8);
            this.lblTipousu.Name = "lblTipousu";
            this.lblTipousu.Size = new System.Drawing.Size(80, 13);
            this.lblTipousu.TabIndex = 0;
            this.lblTipousu.Text = "Tipo de usuario";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(8, 37);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descripción";
            // 
            // txtTipousu
            // 
            this.txtTipousu.Location = new System.Drawing.Point(95, 8);
            this.txtTipousu.Name = "txtTipousu";
            this.txtTipousu.Size = new System.Drawing.Size(141, 20);
            this.txtTipousu.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(95, 34);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(141, 99);
            this.txtDesc.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(283, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(364, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(326, 276);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(326, 241);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(326, 207);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlTipoUsu
            // 
            this.pnlTipoUsu.Controls.Add(this.txtDesc);
            this.pnlTipoUsu.Controls.Add(this.txtTipousu);
            this.pnlTipoUsu.Controls.Add(this.lblDesc);
            this.pnlTipoUsu.Controls.Add(this.lblTipousu);
            this.pnlTipoUsu.Location = new System.Drawing.Point(12, 187);
            this.pnlTipoUsu.Name = "pnlTipoUsu";
            this.pnlTipoUsu.Size = new System.Drawing.Size(256, 143);
            this.pnlTipoUsu.TabIndex = 24;
            // 
            // dgvTipoUsu
            // 
            this.dgvTipoUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoUsu.Location = new System.Drawing.Point(12, 41);
            this.dgvTipoUsu.Name = "dgvTipoUsu";
            this.dgvTipoUsu.Size = new System.Drawing.Size(427, 129);
            this.dgvTipoUsu.TabIndex = 25;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(364, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(346, 20);
            this.txtBuscar.TabIndex = 26;
            // 
            // FormTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 343);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvTipoUsu);
            this.Controls.Add(this.pnlTipoUsu);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormTipoUsuario";
            this.Text = "FormTipoUsuario";
            this.pnlTipoUsu.ResumeLayout(false);
            this.pnlTipoUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipousu;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtTipousu;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel pnlTipoUsu;
        private System.Windows.Forms.DataGridView dgvTipoUsu;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}