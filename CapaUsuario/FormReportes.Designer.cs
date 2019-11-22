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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DTArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new CapaUsuario.DataSet();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DTArticuloTableAdapter = new CapaUsuario.DataSetTableAdapters.DTArticuloTableAdapter();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
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
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DTArticuloBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource2);
            this.rv.LocalReport.ReportEmbeddedResource = "CapaUsuario.ReporteArituculo.rdlc";
            this.rv.Location = new System.Drawing.Point(9, 12);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(367, 247);
            this.rv.TabIndex = 0;
            // 
            // DTArticuloTableAdapter
            // 
            this.DTArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(9, 265);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(367, 42);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 317);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rv);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource DTArticuloBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.DTArticuloTableAdapter DTArticuloTableAdapter;
        private System.Windows.Forms.Button btnAtras;
    }
}