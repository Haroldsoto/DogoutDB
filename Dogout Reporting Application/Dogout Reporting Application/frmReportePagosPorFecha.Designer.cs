namespace Dogout_Reporting_Application
{
    partial class frmReportePagosPorFecha
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
            this.DatosBancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CuboBusinessIntelligenceDataSet = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSet();
            this.PagosEstadoPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosBancaTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter();
            this.PagosEstadoPorFechaTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.PagosEstadoPorFechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBancaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagosEstadoPorFechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosBancaBindingSource
            // 
            this.DatosBancaBindingSource.DataMember = "DatosBanca";
            this.DatosBancaBindingSource.DataSource = this.CuboBusinessIntelligenceDataSet;
            // 
            // CuboBusinessIntelligenceDataSet
            // 
            this.CuboBusinessIntelligenceDataSet.DataSetName = "CuboBusinessIntelligenceDataSet";
            this.CuboBusinessIntelligenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PagosEstadoPorFechaBindingSource
            // 
            this.PagosEstadoPorFechaBindingSource.DataMember = "PagosEstadoPorFecha";
            this.PagosEstadoPorFechaBindingSource.DataSource = this.CuboBusinessIntelligenceDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "dsDatosBanca";
            reportDataSource1.Value = this.DatosBancaBindingSource;
            reportDataSource2.Name = "dsPagosPorFecha";
            reportDataSource2.Value = this.PagosEstadoPorFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dogout_Reporting_Application.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(907, 782);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosBancaTableAdapter
            // 
            this.DatosBancaTableAdapter.ClearBeforeFill = true;
            // 
            // PagosEstadoPorFechaTableAdapter
            // 
            this.PagosEstadoPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportePagosPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 779);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportePagosPorFecha";
            this.Text = "frmReportePagosPorFecha";
            this.Load += new System.EventHandler(this.frmReportePagosPorFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosBancaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagosEstadoPorFechaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DatosBancaBindingSource;
        private CuboBusinessIntelligenceDataSet CuboBusinessIntelligenceDataSet;
        private System.Windows.Forms.BindingSource PagosEstadoPorFechaBindingSource;
        private CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter DatosBancaTableAdapter;
        private CuboBusinessIntelligenceDataSetTableAdapters.PagosEstadoPorFechaTableAdapter PagosEstadoPorFechaTableAdapter;
    }
}