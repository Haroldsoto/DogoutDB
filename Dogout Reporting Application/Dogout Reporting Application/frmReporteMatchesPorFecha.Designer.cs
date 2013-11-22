//------------------------------------------------------------------
// <copyright company="Microsoft">
//     Copyright (c) Microsoft.  All rights reserved.
// </copyright>
//------------------------------------------------------------------
namespace Dogout_Reporting_Application
{
    partial class frmReporteMatchesPorFecha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cuboBusinessIntelligenceDataSet = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSet();
            this.datosBancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosBancaTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter();
            this.matchesPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchesPorFechaTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.MatchesPorFechaTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.matchesPorFechaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cuboBusinessIntelligenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBancaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesPorFechaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsHeader";
            reportDataSource1.Value = this.datosBancaBindingSource;
            reportDataSource2.Name = "dsMatchesPorFecha";
            reportDataSource2.Value = this.matchesPorFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dogout_Reporting_Application.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 386);
            this.reportViewer1.TabIndex = 0;
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
            // datosBancaTableAdapter
            // 
            this.datosBancaTableAdapter.ClearBeforeFill = true;
            // 
            // matchesPorFechaBindingSource
            // 
            this.matchesPorFechaBindingSource.DataMember = "MatchesPorFecha";
            this.matchesPorFechaBindingSource.DataSource = this.cuboBusinessIntelligenceDataSet;
            // 
            // matchesPorFechaTableAdapter
            // 
            this.matchesPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // matchesPorFechaBindingSource1
            // 
            this.matchesPorFechaBindingSource1.DataMember = "MatchesPorFecha";
            this.matchesPorFechaBindingSource1.DataSource = this.cuboBusinessIntelligenceDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 386);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuboBusinessIntelligenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBancaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesPorFechaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CuboBusinessIntelligenceDataSet cuboBusinessIntelligenceDataSet;
        private System.Windows.Forms.BindingSource datosBancaBindingSource;
        private CuboBusinessIntelligenceDataSetTableAdapters.DatosBancaTableAdapter datosBancaTableAdapter;
        private System.Windows.Forms.BindingSource matchesPorFechaBindingSource;
        private CuboBusinessIntelligenceDataSetTableAdapters.MatchesPorFechaTableAdapter matchesPorFechaTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource matchesPorFechaBindingSource1;
    }
}

