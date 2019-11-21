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
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet = new CapaUsuario.DataSet();
            this.DTArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTArticuloTableAdapter = new CapaUsuario.DataSetTableAdapters.DTArticuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTArticuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rv
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DTArticuloBindingSource;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "CapaUsuario.ReporteArituculo.rdlc";
            this.rv.Location = new System.Drawing.Point(9, 12);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(367, 247);
            this.rv.TabIndex = 0;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTArticuloBindingSource
            // 
            this.DTArticuloBindingSource.DataMember = "DTArticulo";
            this.DTArticuloBindingSource.DataSource = this.DataSet;
            // 
            // DTArticuloTableAdapter
            // 
            this.DTArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.rv);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTArticuloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.BindingSource DTArticuloBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.DTArticuloTableAdapter DTArticuloTableAdapter;
    }
}