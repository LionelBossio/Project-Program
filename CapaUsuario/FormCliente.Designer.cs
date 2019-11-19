namespace CapaUsuario
{
    partial class FormCliente
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnNombre = new System.Windows.Forms.Label();
            this.lblEquipRep = new System.Windows.Forms.Label();
            this.btnTel = new System.Windows.Forms.Label();
            this.nupCod = new System.Windows.Forms.NumericUpDown();
            this.nupTel = new System.Windows.Forms.NumericUpDown();
            this.cmbEquipRep = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnNombre
            // 
            this.btnNombre.AutoSize = true;
            this.btnNombre.Location = new System.Drawing.Point(13, 38);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(44, 13);
            this.btnNombre.TabIndex = 1;
            this.btnNombre.Text = "Nombre";
            // 
            // lblEquipRep
            // 
            this.lblEquipRep.AutoSize = true;
            this.lblEquipRep.Location = new System.Drawing.Point(12, 66);
            this.lblEquipRep.Name = "lblEquipRep";
            this.lblEquipRep.Size = new System.Drawing.Size(85, 13);
            this.lblEquipRep.TabIndex = 2;
            this.lblEquipRep.Text = "Equipo a reparar";
            // 
            // btnTel
            // 
            this.btnTel.AutoSize = true;
            this.btnTel.Location = new System.Drawing.Point(13, 95);
            this.btnTel.Name = "btnTel";
            this.btnTel.Size = new System.Drawing.Size(49, 13);
            this.btnTel.TabIndex = 3;
            this.btnTel.Text = "Telefóno";
            // 
            // nupCod
            // 
            this.nupCod.Location = new System.Drawing.Point(60, 13);
            this.nupCod.Name = "nupCod";
            this.nupCod.Size = new System.Drawing.Size(120, 20);
            this.nupCod.TabIndex = 4;
            // 
            // nupTel
            // 
            this.nupTel.Location = new System.Drawing.Point(68, 93);
            this.nupTel.Name = "nupTel";
            this.nupTel.Size = new System.Drawing.Size(120, 20);
            this.nupTel.TabIndex = 5;
            // 
            // cmbEquipRep
            // 
            this.cmbEquipRep.FormattingEnabled = true;
            this.cmbEquipRep.Location = new System.Drawing.Point(104, 66);
            this.cmbEquipRep.Name = "cmbEquipRep";
            this.cmbEquipRep.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipRep.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(197, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbEquipRep);
            this.Controls.Add(this.nupTel);
            this.Controls.Add(this.nupCod);
            this.Controls.Add(this.btnTel);
            this.Controls.Add(this.lblEquipRep);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)(this.nupCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label btnNombre;
        private System.Windows.Forms.Label lblEquipRep;
        private System.Windows.Forms.Label btnTel;
        private System.Windows.Forms.NumericUpDown nupCod;
        private System.Windows.Forms.NumericUpDown nupTel;
        private System.Windows.Forms.ComboBox cmbEquipRep;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
    }
}