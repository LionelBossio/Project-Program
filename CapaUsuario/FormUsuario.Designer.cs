namespace CapaUsuario
{
    partial class FormUsuario
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFecnac = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumtel = new System.Windows.Forms.Label();
            this.lblTipousu = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nupDni = new System.Windows.Forms.NumericUpDown();
            this.dtpFecnac = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.nupNumtel = new System.Windows.Forms.NumericUpDown();
            this.cmbTipousu = new System.Windows.Forms.ComboBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblNomusu = new System.Windows.Forms.Label();
            this.txtNomusu = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumtel)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(376, 472);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(403, 272);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(403, 303);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(403, 334);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(13, 45);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(519, 172);
            this.dgvUsuario.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(66, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(66, 45);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(84, 124);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "DNI";
            // 
            // lblFecnac
            // 
            this.lblFecnac.AutoSize = true;
            this.lblFecnac.Location = new System.Drawing.Point(4, 151);
            this.lblFecnac.Name = "lblFecnac";
            this.lblFecnac.Size = new System.Drawing.Size(106, 13);
            this.lblFecnac.TabIndex = 8;
            this.lblFecnac.Text = "Fecha de nacimiento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(78, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblNumtel
            // 
            this.lblNumtel.AutoSize = true;
            this.lblNumtel.Location = new System.Drawing.Point(61, 202);
            this.lblNumtel.Name = "lblNumtel";
            this.lblNumtel.Size = new System.Drawing.Size(49, 13);
            this.lblNumtel.TabIndex = 10;
            this.lblNumtel.Text = "Telefóno";
            // 
            // lblTipousu
            // 
            this.lblTipousu.AutoSize = true;
            this.lblTipousu.Location = new System.Drawing.Point(30, 229);
            this.lblTipousu.Name = "lblTipousu";
            this.lblTipousu.Size = new System.Drawing.Size(80, 13);
            this.lblTipousu.TabIndex = 11;
            this.lblTipousu.Text = "Tipo de usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(116, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // nupDni
            // 
            this.nupDni.Location = new System.Drawing.Point(116, 117);
            this.nupDni.Name = "nupDni";
            this.nupDni.Size = new System.Drawing.Size(200, 20);
            this.nupDni.TabIndex = 15;
            // 
            // dtpFecnac
            // 
            this.dtpFecnac.Location = new System.Drawing.Point(116, 144);
            this.dtpFecnac.Name = "dtpFecnac";
            this.dtpFecnac.Size = new System.Drawing.Size(200, 20);
            this.dtpFecnac.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // nupNumtel
            // 
            this.nupNumtel.Location = new System.Drawing.Point(117, 194);
            this.nupNumtel.Name = "nupNumtel";
            this.nupNumtel.Size = new System.Drawing.Size(199, 20);
            this.nupNumtel.TabIndex = 18;
            // 
            // cmbTipousu
            // 
            this.cmbTipousu.FormattingEnabled = true;
            this.cmbTipousu.Location = new System.Drawing.Point(116, 221);
            this.cmbTipousu.Name = "cmbTipousu";
            this.cmbTipousu.Size = new System.Drawing.Size(200, 21);
            this.cmbTipousu.TabIndex = 19;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(49, 72);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 21;
            this.lblContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(116, 65);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(200, 20);
            this.txtContra.TabIndex = 22;
            // 
            // lblNomusu
            // 
            this.lblNomusu.AutoSize = true;
            this.lblNomusu.Location = new System.Drawing.Point(14, 98);
            this.lblNomusu.Name = "lblNomusu";
            this.lblNomusu.Size = new System.Drawing.Size(96, 13);
            this.lblNomusu.TabIndex = 23;
            this.lblNomusu.Text = "Nombre de usuario";
            // 
            // txtNomusu
            // 
            this.txtNomusu.Location = new System.Drawing.Point(116, 91);
            this.txtNomusu.Name = "txtNomusu";
            this.txtNomusu.Size = new System.Drawing.Size(200, 20);
            this.txtNomusu.TabIndex = 24;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(457, 472);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.txtNomusu);
            this.pnlUsuario.Controls.Add(this.lblNomusu);
            this.pnlUsuario.Controls.Add(this.txtContra);
            this.pnlUsuario.Controls.Add(this.lblContra);
            this.pnlUsuario.Controls.Add(this.cmbTipousu);
            this.pnlUsuario.Controls.Add(this.nupNumtel);
            this.pnlUsuario.Controls.Add(this.txtEmail);
            this.pnlUsuario.Controls.Add(this.dtpFecnac);
            this.pnlUsuario.Controls.Add(this.nupDni);
            this.pnlUsuario.Controls.Add(this.txtApellido);
            this.pnlUsuario.Controls.Add(this.txtNombre);
            this.pnlUsuario.Controls.Add(this.lblTipousu);
            this.pnlUsuario.Controls.Add(this.lblNumtel);
            this.pnlUsuario.Controls.Add(this.lblEmail);
            this.pnlUsuario.Controls.Add(this.lblFecnac);
            this.pnlUsuario.Controls.Add(this.lblDni);
            this.pnlUsuario.Controls.Add(this.lblApellido);
            this.pnlUsuario.Controls.Add(this.lblNombre);
            this.pnlUsuario.Location = new System.Drawing.Point(23, 237);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(324, 258);
            this.pnlUsuario.TabIndex = 26;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(457, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(439, 20);
            this.txtBuscar.TabIndex = 27;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 509);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumtel)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFecnac;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumtel;
        private System.Windows.Forms.Label lblTipousu;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nupDni;
        private System.Windows.Forms.DateTimePicker dtpFecnac;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.NumericUpDown nupNumtel;
        private System.Windows.Forms.ComboBox cmbTipousu;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblNomusu;
        private System.Windows.Forms.TextBox txtNomusu;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}

