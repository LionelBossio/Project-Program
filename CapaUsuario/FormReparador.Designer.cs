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
            this.nupCantcliante = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantcliante)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantrep
            // 
            this.lblCantrep.AutoSize = true;
            this.lblCantrep.Location = new System.Drawing.Point(13, 13);
            this.lblCantrep.Name = "lblCantrep";
            this.lblCantrep.Size = new System.Drawing.Size(94, 13);
            this.lblCantrep.TabIndex = 0;
            this.lblCantrep.Text = "Cantidad reparada";
            // 
            // lblCantcliante
            // 
            this.lblCantcliante.AutoSize = true;
            this.lblCantcliante.Location = new System.Drawing.Point(13, 53);
            this.lblCantcliante.Name = "lblCantcliante";
            this.lblCantcliante.Size = new System.Drawing.Size(139, 13);
            this.lblCantcliante.TabIndex = 1;
            this.lblCantcliante.Text = "Cantidad Cliente antendidos";
            // 
            // nupCantrep
            // 
            this.nupCantrep.Location = new System.Drawing.Point(16, 30);
            this.nupCantrep.Name = "nupCantrep";
            this.nupCantrep.Size = new System.Drawing.Size(120, 20);
            this.nupCantrep.TabIndex = 2;
            // 
            // nupCantcliante
            // 
            this.nupCantcliante.Location = new System.Drawing.Point(16, 69);
            this.nupCantcliante.Name = "nupCantcliante";
            this.nupCantcliante.Size = new System.Drawing.Size(120, 20);
            this.nupCantcliante.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormReparador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 99);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.nupCantcliante);
            this.Controls.Add(this.nupCantrep);
            this.Controls.Add(this.lblCantcliante);
            this.Controls.Add(this.lblCantrep);
            this.Name = "FormReparador";
            this.Text = "FormReparador";
            ((System.ComponentModel.ISupportInitialize)(this.nupCantrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantcliante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantrep;
        private System.Windows.Forms.Label lblCantcliante;
        private System.Windows.Forms.NumericUpDown nupCantrep;
        private System.Windows.Forms.NumericUpDown nupCantcliante;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
    }
}