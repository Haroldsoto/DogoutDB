namespace Dogout_Reporting_Application
{
    partial class frmGenerarTicket
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
            this.dtpFechaMatch = new System.Windows.Forms.DateTimePicker();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaMatch
            // 
            this.dtpFechaMatch.Location = new System.Drawing.Point(12, 12);
            this.dtpFechaMatch.Name = "dtpFechaMatch";
            this.dtpFechaMatch.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMatch.TabIndex = 0;
            this.dtpFechaMatch.ValueChanged += new System.EventHandler(this.dtpFechaMatch_ValueChanged);
            // 
            // dgvMatches
            // 
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Location = new System.Drawing.Point(12, 38);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(642, 286);
            this.dgvMatches.TabIndex = 1;
            this.dgvMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatches_CellClick);
            this.dgvMatches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatches_CellContentClick);
            // 
            // frmGenerarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 336);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.dtpFechaMatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGenerarTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaMatch;
        private System.Windows.Forms.DataGridView dgvMatches;
    }
}