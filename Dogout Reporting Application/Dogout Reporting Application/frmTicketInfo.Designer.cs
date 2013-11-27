namespace Dogout_Reporting_Application
{
    partial class frmTicketInfo
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CuboBusinessIntelligenceDataSet = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSet();
            this.LastTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LastTicketTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.LastTicketTableAdapter();
            this.DatosBancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosBancaTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter();
            this.TicketInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TicketInfoTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.TicketInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBancaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsTicketInfo";
            reportDataSource1.Value = this.TicketInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dogout_Reporting_Application.Pagos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(312, 279);
            this.reportViewer1.TabIndex = 0;
            // 
            // CuboBusinessIntelligenceDataSet
            // 
            this.CuboBusinessIntelligenceDataSet.DataSetName = "CuboBusinessIntelligenceDataSet";
            this.CuboBusinessIntelligenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LastTicketBindingSource
            // 
            this.LastTicketBindingSource.DataMember = "LastTicket";
            this.LastTicketBindingSource.DataSource = this.CuboBusinessIntelligenceDataSet;
            // 
            // LastTicketTableAdapter
            // 
            this.LastTicketTableAdapter.ClearBeforeFill = true;
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
            // TicketInfoBindingSource
            // 
            this.TicketInfoBindingSource.DataMember = "TicketInfo";
            this.TicketInfoBindingSource.DataSource = this.CuboBusinessIntelligenceDataSet;
            // 
            // TicketInfoTableAdapter
            // 
            this.TicketInfoTableAdapter.ClearBeforeFill = true;
            // 
            // frmTicketInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 275);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTicketInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTicketInfo";
            this.Load += new System.EventHandler(this.frmTicketInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBancaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LastTicketBindingSource;
        private CuboBusinessIntelligenceDataSet CuboBusinessIntelligenceDataSet;
        private System.Windows.Forms.BindingSource DatosBancaBindingSource;
        private CuboBusinessIntelligenceDataSetTableAdapters.LastTicketTableAdapter LastTicketTableAdapter;
        private CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter DatosBancaTableAdapter;
        private System.Windows.Forms.BindingSource TicketInfoBindingSource;
        private CuboBusinessIntelligenceDataSetTableAdapters.TicketInfoTableAdapter TicketInfoTableAdapter;
    }
}