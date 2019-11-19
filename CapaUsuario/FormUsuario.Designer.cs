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
            this.lblRepde = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nupDni = new System.Windows.Forms.NumericUpDown();
            this.dtpFecnac = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.nupNumtel = new System.Windows.Forms.NumericUpDown();
            this.cmbTipousu = new System.Windows.Forms.ComboBox();
            this.cmbRepde = new System.Windows.Forms.ComboBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblNomusu = new System.Windows.Forms.Label();
            this.txtNomusu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumtel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(413, 404);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(413, 50);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(413, 79);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(413, 108);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(13, 13);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(379, 172);
            this.dgvUsuario.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 204);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 228);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(14, 299);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "DNI";
            // 
            // lblFecnac
            // 
            this.lblFecnac.AutoSize = true;
            this.lblFecnac.Location = new System.Drawing.Point(14, 324);
            this.lblFecnac.Name = "lblFecnac";
            this.lblFecnac.Size = new System.Drawing.Size(106, 13);
            this.lblFecnac.TabIndex = 8;
            this.lblFecnac.Text = "Fecha de nacimiento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 346);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblNumtel
            // 
            this.lblNumtel.AutoSize = true;
            this.lblNumtel.Location = new System.Drawing.Point(14, 374);
            this.lblNumtel.Name = "lblNumtel";
            this.lblNumtel.Size = new System.Drawing.Size(49, 13);
            this.lblNumtel.TabIndex = 10;
            this.lblNumtel.Text = "Telefóno";
            // 
            // lblTipousu
            // 
            this.lblTipousu.AutoSize = true;
            this.lblTipousu.Location = new System.Drawing.Point(19, 400);
            this.lblTipousu.Name = "lblTipousu";
            this.lblTipousu.Size = new System.Drawing.Size(80, 13);
            this.lblTipousu.TabIndex = 11;
            this.lblTipousu.Text = "Tipo de usuario";
            // 
            // lblRepde
            // 
            this.lblRepde.AutoSize = true;
            this.lblRepde.Location = new System.Drawing.Point(19, 429);
            this.lblRepde.Name = "lblRepde";
            this.lblRepde.Size = new System.Drawing.Size(77, 13);
            this.lblRepde.TabIndex = 12;
            this.lblRepde.Text = "Reparación de";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 197);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(60, 223);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // nupDni
            // 
            this.nupDni.Location = new System.Drawing.Point(69, 297);
            this.nupDni.Name = "nupDni";
            this.nupDni.Size = new System.Drawing.Size(120, 20);
            this.nupDni.TabIndex = 15;
            // 
            // dtpFecnac
            // 
            this.dtpFecnac.Location = new System.Drawing.Point(126, 324);
            this.dtpFecnac.Name = "dtpFecnac";
            this.dtpFecnac.Size = new System.Drawing.Size(200, 20);
            this.dtpFecnac.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(52, 346);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // nupNumtel
            // 
            this.nupNumtel.Location = new System.Drawing.Point(69, 374);
            this.nupNumtel.Name = "nupNumtel";
            this.nupNumtel.Size = new System.Drawing.Size(120, 20);
            this.nupNumtel.TabIndex = 18;
            // 
            // cmbTipousu
            // 
            this.cmbTipousu.FormattingEnabled = true;
            this.cmbTipousu.Location = new System.Drawing.Point(106, 401);
            this.cmbTipousu.Name = "cmbTipousu";
            this.cmbTipousu.Size = new System.Drawing.Size(121, 21);
            this.cmbTipousu.TabIndex = 19;
            // 
            // cmbRepde
            // 
            this.cmbRepde.FormattingEnabled = true;
            this.cmbRepde.Location = new System.Drawing.Point(106, 428);
            this.cmbRepde.Name = "cmbRepde";
            this.cmbRepde.Size = new System.Drawing.Size(121, 21);
            this.cmbRepde.TabIndex = 20;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(11, 253);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 21;
            this.lblContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(78, 250);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 22;
            // 
            // lblNomusu
            // 
            this.lblNomusu.AutoSize = true;
            this.lblNomusu.Location = new System.Drawing.Point(14, 278);
            this.lblNomusu.Name = "lblNomusu";
            this.lblNomusu.Size = new System.Drawing.Size(96, 13);
            this.lblNomusu.TabIndex = 23;
            this.lblNomusu.Text = "Nombre de usuario";
            // 
            // txtNomusu
            // 
            this.txtNomusu.Location = new System.Drawing.Point(116, 276);
            this.txtNomusu.Name = "txtNomusu";
            this.txtNomusu.Size = new System.Drawing.Size(100, 20);
            this.txtNomusu.TabIndex = 24;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 453);
            this.Controls.Add(this.txtNomusu);
            this.Controls.Add(this.lblNomusu);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.cmbRepde);
            this.Controls.Add(this.cmbTipousu);
            this.Controls.Add(this.nupNumtel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpFecnac);
            this.Controls.Add(this.nupDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblRepde);
            this.Controls.Add(this.lblTipousu);
            this.Controls.Add(this.lblNumtel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFecnac);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormUsuario";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumtel)).EndInit();
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
        private System.Windows.Forms.Label lblRepde;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nupDni;
        private System.Windows.Forms.DateTimePicker dtpFecnac;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.NumericUpDown nupNumtel;
        private System.Windows.Forms.ComboBox cmbTipousu;
        private System.Windows.Forms.ComboBox cmbRepde;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblNomusu;
        private System.Windows.Forms.TextBox txtNomusu;
    }
}

