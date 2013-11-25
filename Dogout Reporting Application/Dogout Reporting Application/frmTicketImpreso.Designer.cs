using System.Drawing;

namespace Dogout_Reporting_Application
{
    partial class frmTicketImpreso
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
            this.LastTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CuboBusinessIntelligenceDataSet = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSet();
            this.DatosBancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LastTicketTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.LastTicketTableAdapter();
            this.DatosBancaTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LastTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBancaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LastTicketBindingSource
            // 
            this.LastTicketBindingSource.DataMember = "LastTicket";
            this.LastTicketBindingSource.DataSource = this.CuboBusinessIntelligenceDataSet;
            // 
            // CuboBusinessIntelligenceDataSet
            // 
            this.CuboBusinessIntelligenceDataSet.DataSetName = "CuboBusinessIntelligenceDataSet";
            this.CuboBusinessIntelligenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatosBancaBindingSource
            // 
            this.DatosBancaBindingSource.DataMember = "DatosBanca";
            this.DatosBancaBindingSource.DataSource = this.CuboBusinessIntelligenceDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsLastTicket";
            reportDataSource1.Value = this.LastTicketBindingSource;
            reportDataSource2.Name = "dsDatosBanca";
            reportDataSource2.Value = this.DatosBancaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dogout_Reporting_Application.Ticket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(406, 574);
            this.reportViewer1.TabIndex = 0;
            // 
            // LastTicketTableAdapter
            // 
            this.LastTicketTableAdapter.ClearBeforeFill = true;
            // 
            // DatosBancaTableAdapter
            // 
            this.DatosBancaTableAdapter.ClearBeforeFill = true;
            // 
            // frmTicketImpreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 574);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTicketImpreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTicketImpreso";
            this.Load += new System.EventHandler(this.frmTicketImpreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LastTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBancaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LastTicketBindingSource;
        private CuboBusinessIntelligenceDataSet CuboBusinessIntelligenceDataSet;
        private System.Windows.Forms.BindingSource DatosBancaBindingSource;
        private CuboBusinessIntelligenceDataSetTableAdapters.LastTicketTableAdapter LastTicketTableAdapter;
        private CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter DatosBancaTableAdapter;
    }
}