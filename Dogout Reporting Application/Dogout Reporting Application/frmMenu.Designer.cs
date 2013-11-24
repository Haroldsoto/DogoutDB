namespace Dogout_Reporting_Application
{
    partial class opReportes
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucTickets = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.ucOpcionesMenu2 = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.ucReportes = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.ucOpcionesMenu1 = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbLogo.Image = global::Dogout_Reporting_Application.Properties.Resources.dogout_logo;
            this.pbLogo.Location = new System.Drawing.Point(90, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(416, 178);
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 178);
            this.panel1.TabIndex = 6;
            // 
            // ucTickets
            // 
            this.ucTickets.BackColor = System.Drawing.Color.Transparent;
            this.ucTickets.controlDescription = "Módulo que permite crear tickets.";
            this.ucTickets.controlImage = global::Dogout_Reporting_Application.Properties.Resources._1385288252_invoice;
            this.ucTickets.controlTitle = "Tickets";
            this.ucTickets.formToOpen = null;
            this.ucTickets.Location = new System.Drawing.Point(12, 390);
            this.ucTickets.Name = "ucTickets";
            this.ucTickets.Size = new System.Drawing.Size(301, 92);
            this.ucTickets.TabIndex = 4;
            // 
            // ucOpcionesMenu2
            // 
            this.ucOpcionesMenu2.BackColor = System.Drawing.Color.Transparent;
            this.ucOpcionesMenu2.controlDescription = null;
            this.ucOpcionesMenu2.controlImage = global::Dogout_Reporting_Application.Properties.Resources._1385118673_qr_code;
            this.ucOpcionesMenu2.controlTitle = "Generador QR";
            this.ucOpcionesMenu2.formToOpen = null;
            this.ucOpcionesMenu2.Location = new System.Drawing.Point(12, 293);
            this.ucOpcionesMenu2.Name = "ucOpcionesMenu2";
            this.ucOpcionesMenu2.Size = new System.Drawing.Size(269, 91);
            this.ucOpcionesMenu2.TabIndex = 2;
            this.ucOpcionesMenu2.Load += new System.EventHandler(this.ucOpcionesMenu2_Load);
            // 
            // ucReportes
            // 
            this.ucReportes.BackColor = System.Drawing.Color.Transparent;
            this.ucReportes.controlDescription = "Se muestran los reportes relacionados a la banca Dogout";
            this.ucReportes.controlImage = global::Dogout_Reporting_Application.Properties.Resources.reports;
            this.ucReportes.controlTitle = "Reportes";
            this.ucReportes.formToOpen = null;
            this.ucReportes.Location = new System.Drawing.Point(12, 196);
            this.ucReportes.Name = "ucReportes";
            this.ucReportes.Size = new System.Drawing.Size(269, 91);
            this.ucReportes.TabIndex = 1;
            this.ucReportes.Load += new System.EventHandler(this.ucReportes_Load);
            this.ucReportes.Click += new System.EventHandler(this.ucReportes_Click);
            // 
            // ucOpcionesMenu1
            // 
            this.ucOpcionesMenu1.BackColor = System.Drawing.Color.Transparent;
            this.ucOpcionesMenu1.controlDescription = null;
            this.ucOpcionesMenu1.controlImage = null;
            this.ucOpcionesMenu1.controlTitle = null;
            this.ucOpcionesMenu1.formToOpen = null;
            this.ucOpcionesMenu1.Location = new System.Drawing.Point(12, 293);
            this.ucOpcionesMenu1.Name = "ucOpcionesMenu1";
            this.ucOpcionesMenu1.Size = new System.Drawing.Size(269, 91);
            this.ucOpcionesMenu1.TabIndex = 0;
            // 
            // opReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(612, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucTickets);
            this.Controls.Add(this.ucOpcionesMenu2);
            this.Controls.Add(this.ucReportes);
            this.Controls.Add(this.ucOpcionesMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "opReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Comun.ucOpcionesMenu ucOpcionesMenu1;
        private Comun.ucOpcionesMenu ucReportes;
        private Comun.ucOpcionesMenu ucOpcionesMenu2;
        private Comun.ucOpcionesMenu ucTickets;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;




    }
}