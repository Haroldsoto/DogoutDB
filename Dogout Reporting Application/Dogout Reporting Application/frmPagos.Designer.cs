namespace Dogout_Reporting_Application
{
    partial class frmPagos
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
            this.TicketInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CuboBusinessIntelligenceDataSet = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSet();
            this.txtIdTicket = new System.Windows.Forms.TextBox();
            this.lblIdTicket = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPago = new System.Windows.Forms.Button();
            this.TicketInfoTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.TicketInfoTableAdapter();
            this.btnBuscarTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TicketInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketInfoBindingSource
            // 
            this.TicketInfoBindingSource.DataMember = "TicketInfo";
            this.TicketInfoBindingSource.DataSource = this.CuboBusinessIntelligenceDataSet;
            // 
            // CuboBusinessIntelligenceDataSet
            // 
            this.CuboBusinessIntelligenceDataSet.DataSetName = "CuboBusinessIntelligenceDataSet";
            this.CuboBusinessIntelligenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdTicket
            // 
            this.txtIdTicket.Location = new System.Drawing.Point(108, 14);
            this.txtIdTicket.Name = "txtIdTicket";
            this.txtIdTicket.Size = new System.Drawing.Size(100, 20);
            this.txtIdTicket.TabIndex = 0;
            // 
            // lblIdTicket
            // 
            this.lblIdTicket.AutoSize = true;
            this.lblIdTicket.Location = new System.Drawing.Point(12, 17);
            this.lblIdTicket.Name = "lblIdTicket";
            this.lblIdTicket.Size = new System.Drawing.Size(90, 13);
            this.lblIdTicket.TabIndex = 1;
            this.lblIdTicket.Text = "Código del Ticket";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsTicketInfo";
            reportDataSource1.Value = this.TicketInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dogout_Reporting_Application.Pagos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(312, 279);
            this.reportViewer1.TabIndex = 2;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(233, 336);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(91, 37);
            this.btnPago.TabIndex = 3;
            this.btnPago.Text = "Generar Pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // TicketInfoTableAdapter
            // 
            this.TicketInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscarTicket
            // 
            this.btnBuscarTicket.Location = new System.Drawing.Point(213, 7);
            this.btnBuscarTicket.Name = "btnBuscarTicket";
            this.btnBuscarTicket.Size = new System.Drawing.Size(112, 32);
            this.btnBuscarTicket.TabIndex = 4;
            this.btnBuscarTicket.Text = "Buscar Ticket";
            this.btnBuscarTicket.UseVisualStyleBackColor = true;
            this.btnBuscarTicket.Click += new System.EventHandler(this.btnBuscarTicket_Click);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 385);
            this.Controls.Add(this.btnBuscarTicket);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblIdTicket);
            this.Controls.Add(this.txtIdTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdTicket;
        private System.Windows.Forms.Label lblIdTicket;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.BindingSource TicketInfoBindingSource;
        private CuboBusinessIntelligenceDataSet CuboBusinessIntelligenceDataSet;
        private CuboBusinessIntelligenceDataSetTableAdapters.TicketInfoTableAdapter TicketInfoTableAdapter;
        private System.Windows.Forms.Button btnBuscarTicket;
    }
}