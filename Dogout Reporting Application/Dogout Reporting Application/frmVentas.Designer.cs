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
            this.SuspendLayout();
            // 
            // lbPayments
            // 
            this.lbPayments.FormattingEnabled = true;
            this.lbPayments.Location = new System.Drawing.Point(12, 82);
            this.lbPayments.Name = "lbPayments";
            this.lbPayments.Size = new System.Drawing.Size(696, 251);
            this.lbPayments.TabIndex = 0;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 350);
            this.Controls.Add(this.lbPayments);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPayments;
    }
}