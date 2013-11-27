namespace Dogout_Reporting_Application
{
    partial class frmLineasPorMatch
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.dtpFechaMatch = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(157, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Seleccione la Fecha del Partido";
            // 
            // dgvMatches
            // 
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Location = new System.Drawing.Point(12, 29);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(843, 344);
            this.dgvMatches.TabIndex = 4;
            this.dgvMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatches_CellClick);
            // 
            // dtpFechaMatch
            // 
            this.dtpFechaMatch.Location = new System.Drawing.Point(169, 5);
            this.dtpFechaMatch.Name = "dtpFechaMatch";
            this.dtpFechaMatch.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaMatch.TabIndex = 3;
            this.dtpFechaMatch.ValueChanged += new System.EventHandler(this.dtpFechaMatch_ValueChanged);
            // 
            // frmLineasPorMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 383);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.dtpFechaMatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLineasPorMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Líneas por Partido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.DateTimePicker dtpFechaMatch;
    }
}