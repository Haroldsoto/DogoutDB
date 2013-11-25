namespace Dogout_Reporting_Application
{
    partial class frmCreateTicket
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
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cbJugadas = new System.Windows.Forms.ComboBox();
            this.lblJugada = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.lblEnfrentamiento = new System.Windows.Forms.Label();
            this.btnCrearTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(191, 68);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(100, 20);
            this.tbMonto.TabIndex = 0;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(188, 51);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(85, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto a Apostar";
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // cbJugadas
            // 
            this.cbJugadas.DisplayMember = "Descripcion";
            this.cbJugadas.FormattingEnabled = true;
            this.cbJugadas.Location = new System.Drawing.Point(77, 67);
            this.cbJugadas.Name = "cbJugadas";
            this.cbJugadas.Size = new System.Drawing.Size(74, 21);
            this.cbJugadas.TabIndex = 2;
            this.cbJugadas.SelectedValueChanged += new System.EventHandler(this.cbJugadas_SelectedValueChanged);
            // 
            // lblJugada
            // 
            this.lblJugada.AutoSize = true;
            this.lblJugada.Location = new System.Drawing.Point(74, 51);
            this.lblJugada.Name = "lblJugada";
            this.lblJugada.Size = new System.Drawing.Size(42, 13);
            this.lblJugada.TabIndex = 3;
            this.lblJugada.Text = "Jugada";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(74, 119);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 13);
            this.lblEquipo.TabIndex = 5;
            this.lblEquipo.Text = "Equipo";
            // 
            // cbEquipo
            // 
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(77, 135);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(95, 21);
            this.cbEquipo.TabIndex = 4;
            this.cbEquipo.SelectedIndexChanged += new System.EventHandler(this.cbEquipo_SelectedIndexChanged);
            // 
            // lblEnfrentamiento
            // 
            this.lblEnfrentamiento.AutoSize = true;
            this.lblEnfrentamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfrentamiento.Location = new System.Drawing.Point(12, 9);
            this.lblEnfrentamiento.Name = "lblEnfrentamiento";
            this.lblEnfrentamiento.Size = new System.Drawing.Size(0, 18);
            this.lblEnfrentamiento.TabIndex = 6;
            this.lblEnfrentamiento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCrearTicket
            // 
            this.btnCrearTicket.Location = new System.Drawing.Point(216, 133);
            this.btnCrearTicket.Name = "btnCrearTicket";
            this.btnCrearTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCrearTicket.TabIndex = 7;
            this.btnCrearTicket.Text = "Crear Ticket";
            this.btnCrearTicket.UseVisualStyleBackColor = true;
            this.btnCrearTicket.Click += new System.EventHandler(this.btnCrearTicket_Click);
            // 
            // frmCreateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 161);
            this.Controls.Add(this.btnCrearTicket);
            this.Controls.Add(this.lblEnfrentamiento);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.cbEquipo);
            this.Controls.Add(this.lblJugada);
            this.Controls.Add(this.cbJugadas);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.tbMonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCreateTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Tickets";
            this.Load += new System.EventHandler(this.frmCreateTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox cbJugadas;
        private System.Windows.Forms.Label lblJugada;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.Label lblEnfrentamiento;
        private System.Windows.Forms.Button btnCrearTicket;
    }
}