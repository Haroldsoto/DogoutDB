namespace Dogout_Reporting_Application
{
    partial class frmVentas
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
            this.lbPayments = new System.Windows.Forms.ListBox();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblLeyenda1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPayments
            // 
            this.lbPayments.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbPayments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbPayments.Enabled = false;
            this.lbPayments.FormattingEnabled = true;
            this.lbPayments.Location = new System.Drawing.Point(12, 82);
            this.lbPayments.Name = "lbPayments";
            this.lbPayments.Size = new System.Drawing.Size(735, 225);
            this.lbPayments.TabIndex = 0;
            this.lbPayments.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbPayments_DrawItem);
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.BackColor = System.Drawing.Color.Blue;
            this.lblRojo.ForeColor = System.Drawing.Color.Blue;
            this.lblRojo.Location = new System.Drawing.Point(595, 343);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(29, 13);
            this.lblRojo.TabIndex = 1;
            this.lblRojo.Text = "Hola";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.BackColor = System.Drawing.Color.Green;
            this.lblVerde.ForeColor = System.Drawing.Color.Green;
            this.lblVerde.Location = new System.Drawing.Point(595, 320);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(29, 13);
            this.lblVerde.TabIndex = 2;
            this.lblVerde.Text = "Hola";
            // 
            // lblLeyenda1
            // 
            this.lblLeyenda1.AutoSize = true;
            this.lblLeyenda1.Location = new System.Drawing.Point(631, 320);
            this.lblLeyenda1.Name = "lblLeyenda1";
            this.lblLeyenda1.Size = new System.Drawing.Size(114, 13);
            this.lblLeyenda1.TabIndex = 3;
            this.lblLeyenda1.Text = "Tickets No Ganadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tickets Ganadores";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLeyenda1);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.lbPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPayments;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblLeyenda1;
        private System.Windows.Forms.Label label1;
    }
}