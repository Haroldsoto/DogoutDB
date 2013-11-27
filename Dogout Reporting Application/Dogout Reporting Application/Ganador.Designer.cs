namespace Dogout_Reporting_Application
{
    partial class Ganador
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TicketInfoTableAdapter = new Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters.TicketInfoTableAdapter();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Ticket";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsTicketInfo";
            reportDataSource1.Value = this.TicketInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dogout_Reporting_Application.Pagos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(349, 241);
            this.reportViewer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBuscarTicket);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hacer Ganador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSetWinner);
            // 
            // TicketInfoTableAdapter
            // 
            this.TicketInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Ganador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ganador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganador";
            this.Load += new System.EventHandler(this.Ganador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboBusinessIntelligenceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource TicketInfoBindingSource;
        private CuboBusinessIntelligenceDataSet CuboBusinessIntelligenceDataSet;
        private CuboBusinessIntelligenceDataSetTableAdapters.TicketInfoTableAdapter TicketInfoTableAdapter;
    }
}