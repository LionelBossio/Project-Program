namespace CapaUsuario
{
    partial class FormReportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DTArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new CapaUsuario.DataSet();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DTArticuloTableAdapter = new CapaUsuario.DataSetTableAdapters.DTArticuloTableAdapter();
            this.btnAtras = new System.Windows.Forms.Button();
            this.DataSetReparador = new CapaUsuario.DataSetReparador();
            this.ReparadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReparadorTableAdapter = new CapaUsuario.DataSetReparadorTableAdapters.ReparadorTableAdapter();
            this.cbxReportes = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.rvReparador = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DTArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReparador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReparadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DTArticuloBindingSource
            // 
            this.DTArticuloBindingSource.DataMember = "DTArticulo";
            this.DTArticuloBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv
            // 
            this.rv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            reportDataSource1.Name = "DataSetArticulo";
            reportDataSource1.Value = this.DTArticuloBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "CapaUsuario.ReporteArticulo.rdlc";
            this.rv.Location = new System.Drawing.Point(10, 46);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(428, 253);
            this.rv.TabIndex = 0;
            // 
            // DTArticuloTableAdapter
            // 
            this.DTArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(10, 306);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(428, 48);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // DataSetReparador
            // 
            this.DataSetReparador.DataSetName = "DataSetReparador";
            this.DataSetReparador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReparadorBindingSource
            // 
            this.ReparadorBindingSource.DataMember = "Reparador";
            this.ReparadorBindingSource.DataSource = this.DataSetReparador;
            // 
            // ReparadorTableAdapter
            // 
            this.ReparadorTableAdapter.ClearBeforeFill = true;
            // 
            // cbxReportes
            // 
            this.cbxReportes.FormattingEnabled = true;
            this.cbxReportes.Items.AddRange(new object[] {
            "Reporte de articulos",
            "Reporte de reparador"});
            this.cbxReportes.Location = new System.Drawing.Point(12, 12);
            this.cbxReportes.Name = "cbxReportes";
            this.cbxReportes.Size = new System.Drawing.Size(121, 23);
            this.cbxReportes.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(157, 11);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // rvReparador
            // 
            this.rvReparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            reportDataSource2.Name = "DatasetReparador";
            reportDataSource2.Value = this.ReparadorBindingSource;
            this.rvReparador.LocalReport.DataSources.Add(reportDataSource2);
            this.rvReparador.LocalReport.ReportEmbeddedResource = "CapaUsuario.ReporteReparador.rdlc";
            this.rvReparador.Location = new System.Drawing.Point(10, 46);
            this.rvReparador.Name = "rvReparador";
            this.rvReparador.Size = new System.Drawing.Size(428, 253);
            this.rvReparador.TabIndex = 4;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(453, 366);
            this.Controls.Add(this.rvReparador);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cbxReportes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rv);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReparador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReparadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource DTArticuloBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.DTArticuloTableAdapter DTArticuloTableAdapter;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.BindingSource ReparadorBindingSource;
        private DataSetReparador DataSetReparador;
        private DataSetReparadorTableAdapters.ReparadorTableAdapter ReparadorTableAdapter;
        private System.Windows.Forms.ComboBox cbxReportes;
        private System.Windows.Forms.Button btnMostrar;
        private Microsoft.Reporting.WinForms.ReportViewer rvReparador;
    }
}