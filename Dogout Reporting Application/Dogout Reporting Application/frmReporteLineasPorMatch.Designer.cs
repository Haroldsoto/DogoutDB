namespace Dogout_Reporting_Application
{
    partial class frmReporteLineasPorMatch
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
            this.LinesPorMatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CuboBusinessIntelligenceDataSet = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LinesPorMatchTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.LinesPorMatchTableAdapter();
            this.DatosBancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosBancaTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LinesPorMatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBancaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LinesPorMatchBindingSource
            // 
            this.LinesPorMatchBindingSource.DataMember = "LinesPorMatch";
            this.LinesPorMatchBindingSource.DataSource = this.CuboBusinessIntelligenceDataSet;
            // 
            // CuboBusinessIntelligenceDataSet
            // 
            this.CuboBusinessIntelligenceDataSet.DataSetName = "CuboBusinessIntelligenceDataSet";
            this.CuboBusinessIntelligenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsLinesPorMatch";
            reportDataSource1.Value = this.LinesPorMatchBindingSource;
            reportDataSource2.Name = "dsDatosBanca";
            reportDataSource2.Value = this.DatosBancaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dogout_Reporting_Application.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(861, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // LinesPorMatchTableAdapter
            // 
            this.LinesPorMatchTableAdapter.ClearBeforeFill = true;
            // 
            // DatosBancaBindingSource
            // 
            this.DatosBancaBindingSource.DataMember = "DatosBanca";
            this.DatosBancaBindingSource.DataSource = this.CuboBusinessIntelligenceDataSet;
            // 
            // DatosBancaTableAdapter
            // 
            this.DatosBancaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteLineasPorMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 464);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReporteLineasPorMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteLineasPorMatch";
            this.Load += new System.EventHandler(this.frmReporteLineasPorMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LinesPorMatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBancaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LinesPorMatchBindingSource;
        private CuboBusinessIntelligenceDataSet CuboBusinessIntelligenceDataSet;
        private CuboBusinessIntelligenceDataSetTableAdapters.LinesPorMatchTableAdapter LinesPorMatchTableAdapter;
        private System.Windows.Forms.BindingSource DatosBancaBindingSource;
        private CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter DatosBancaTableAdapter;
    }
}