namespace CapaUsuario
{
    partial class FormEntrega
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
            this.lblHecho = new System.Windows.Forms.Label();
            this.ckbHecho = new System.Windows.Forms.CheckBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblFecent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtmFecent = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHecho
            // 
            this.lblHecho.AutoSize = true;
            this.lblHecho.Location = new System.Drawing.Point(12, 9);
            this.lblHecho.Name = "lblHecho";
            this.lblHecho.Size = new System.Drawing.Size(39, 13);
            this.lblHecho.TabIndex = 0;
            this.lblHecho.Text = "Hecho";
            // 
            // ckbHecho
            // 
            this.ckbHecho.AutoSize = true;
            this.ckbHecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbHecho.Location = new System.Drawing.Point(57, 12);
            this.ckbHecho.Name = "ckbHecho";
            this.ckbHecho.Size = new System.Drawing.Size(12, 11);
            this.ckbHecho.TabIndex = 1;
            this.ckbHecho.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(9, 41);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción";
            // 
            // lblFecent
            // 
            this.lblFecent.AutoSize = true;
            this.lblFecent.Location = new System.Drawing.Point(9, 89);
            this.lblFecent.Name = "lblFecent";
            this.lblFecent.Size = new System.Drawing.Size(91, 13);
            this.lblFecent.TabIndex = 3;
            this.lblFecent.Text = "Fecha de entrega";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 45);
            this.textBox1.TabIndex = 4;
            // 
            // dtmFecent
            // 
            this.dtmFecent.Location = new System.Drawing.Point(107, 89);
            this.dtmFecent.Name = "dtmFecent";
            this.dtmFecent.Size = new System.Drawing.Size(200, 20);
            this.dtmFecent.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(383, 63);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(383, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 121);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtmFecent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFecent);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.ckbHecho);
            this.Controls.Add(this.lblHecho);
            this.Name = "FormEntrega";
            this.Text = "FormEntrega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHecho;
        private System.Windows.Forms.CheckBox ckbHecho;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblFecent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtmFecent;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}