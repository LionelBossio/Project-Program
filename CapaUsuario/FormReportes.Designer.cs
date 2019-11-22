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
            this.rv.Location = new System.Drawing.Point(10, 14);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(428, 285);
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
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 366);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rv);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormReportes";
            this.Text = "Reportes";
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