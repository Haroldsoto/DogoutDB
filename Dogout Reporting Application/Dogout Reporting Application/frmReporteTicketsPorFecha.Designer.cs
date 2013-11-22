namespace Dogout_Reporting_Application
{
    partial class frmReporteTicketsPorFecha
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
            this.ticketsPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuboBusinessIntelligenceDataSet = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSet();
            this.datosBancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ticketsPorFechaTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.TicketsPorFechaTableAdapter();
            this.datosBancaTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuboBusinessIntelligenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBancaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsPorFechaBindingSource
            // 
            this.ticketsPorFechaBindingSource.DataMember = "TicketsPorFecha";
            this.ticketsPorFechaBindingSource.DataSource = this.cuboBusinessIntelligenceDataSet;
            // 
            // cuboBusinessIntelligenceDataSet
            // 
            this.cuboBusinessIntelligenceDataSet.DataSetName = "CuboBusinessIntelligenceDataSet";
            this.cuboBusinessIntelligenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosBancaBindingSource
            // 
            this.datosBancaBindingSource.DataMember = "DatosBanca";
            this.datosBancaBindingSource.DataSource = this.cuboBusinessIntelligenceDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsTicketsPorFecha";
            reportDataSource1.Value = this.ticketsPorFechaBindingSource;
            reportDataSource2.Name = "dsDatosBanca";
            reportDataSource2.Value = this.datosBancaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dogout_Reporting_Application.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(807, 458);
            this.reportViewer1.TabIndex = 0;
            // 
            // ticketsPorFechaTableAdapter
            // 
            this.ticketsPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // datosBancaTableAdapter
            // 
            this.datosBancaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteTicketsPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteTicketsPorFecha";
            this.Text = "frmReporteTicketsPorFecha";
            this.Load += new System.EventHandler(this.frmReporteTicketsPorFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuboBusinessIntelligenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBancaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CuboBusinessIntelligenceDataSet cuboBusinessIntelligenceDataSet;
        private System.Windows.Forms.BindingSource ticketsPorFechaBindingSource;
        private CuboBusinessIntelligenceDataSetTableAdapters.TicketsPorFechaTableAdapter ticketsPorFechaTableAdapter;
        private System.Windows.Forms.BindingSource datosBancaBindingSource;
        private CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter datosBancaTableAdapter;
    }
}