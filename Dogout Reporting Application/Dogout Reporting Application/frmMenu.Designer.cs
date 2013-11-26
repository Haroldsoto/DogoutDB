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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opReportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucOpcionesMenu4 = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.ucOpcionesMenu3 = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.ucOpcionesMenu2 = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.ucOpcionesMenu1 = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.opTickets = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.ucReportes = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.ucOpcionesMenu5 = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 178);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dogout_Reporting_Application.Properties.Resources.dogout_logo;
            this.pictureBox1.Location = new System.Drawing.Point(88, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucOpcionesMenu4
            // 
            this.ucOpcionesMenu4.BackColor = System.Drawing.Color.Transparent;
            this.ucOpcionesMenu4.controlDescription = "Módulo que permite la consulta de las ventas y el cuadre.";
            this.ucOpcionesMenu4.controlImage = global::Dogout_Reporting_Application.Properties.Resources.sales;
            this.ucOpcionesMenu4.controlTitle = "Ventas";
            this.ucOpcionesMenu4.formToOpen = null;
            this.ucOpcionesMenu4.Location = new System.Drawing.Point(319, 306);
            this.ucOpcionesMenu4.Name = "ucOpcionesMenu4";
            this.ucOpcionesMenu4.Size = new System.Drawing.Size(301, 92);
            this.ucOpcionesMenu4.TabIndex = 10;
            // 
            // ucOpcionesMenu3
            // 
            this.ucOpcionesMenu3.BackColor = System.Drawing.Color.Transparent;
            this.ucOpcionesMenu3.controlDescription = "Módulo que permite el pago de los Tickets ganadores.";
            this.ucOpcionesMenu3.controlImage = global::Dogout_Reporting_Application.Properties.Resources._1385413842_23;
            this.ucOpcionesMenu3.controlTitle = "Pagos";
            this.ucOpcionesMenu3.formToOpen = null;
            this.ucOpcionesMenu3.Location = new System.Drawing.Point(319, 208);
            this.ucOpcionesMenu3.Name = "ucOpcionesMenu3";
            this.ucOpcionesMenu3.Size = new System.Drawing.Size(301, 92);
            this.ucOpcionesMenu3.TabIndex = 9;
            // 
            // ucOpcionesMenu2
            // 
            this.ucOpcionesMenu2.BackColor = System.Drawing.Color.Transparent;
            this.ucOpcionesMenu2.controlDescription = "Módulo que permite la visualización de los reportes del Sistema.";
            this.ucOpcionesMenu2.controlImage = ((System.Drawing.Image)(resources.GetObject("ucOpcionesMenu2.controlImage")));
            this.ucOpcionesMenu2.controlTitle = "Reportes";
            this.ucOpcionesMenu2.formToOpen = null;
            this.ucOpcionesMenu2.Location = new System.Drawing.Point(12, 306);
            this.ucOpcionesMenu2.Name = "ucOpcionesMenu2";
            this.ucOpcionesMenu2.Size = new System.Drawing.Size(301, 92);
            this.ucOpcionesMenu2.TabIndex = 8;
            // 
            // ucOpcionesMenu1
            // 
            this.ucOpcionesMenu1.BackColor = System.Drawing.Color.Transparent;
            this.ucOpcionesMenu1.controlDescription = "Módulo que permite la creación de Ticktes.";
            this.ucOpcionesMenu1.controlImage = global::Dogout_Reporting_Application.Properties.Resources._1385288252_invoice;
            this.ucOpcionesMenu1.controlTitle = "Tickets";
            this.ucOpcionesMenu1.formToOpen = null;
            this.ucOpcionesMenu1.Location = new System.Drawing.Point(12, 208);
            this.ucOpcionesMenu1.Name = "ucOpcionesMenu1";
            this.ucOpcionesMenu1.Size = new System.Drawing.Size(301, 92);
            this.ucOpcionesMenu1.TabIndex = 7;
            // 
            // opTickets
            // 
            this.opTickets.BackColor = System.Drawing.Color.Transparent;
            this.opTickets.controlDescription = "Módulo que permite crear Tickets.";
            this.opTickets.controlImage = global::Dogout_Reporting_Application.Properties.Resources._1385288252_invoice;
            this.opTickets.controlTitle = "Tickets";
            this.opTickets.formToOpen = null;
            this.opTickets.Location = new System.Drawing.Point(12, 196);
            this.opTickets.Name = "opTickets";
            this.opTickets.Size = new System.Drawing.Size(301, 92);
            this.opTickets.TabIndex = 7;
            // 
            // ucReportes
            // 
            this.ucReportes.BackColor = System.Drawing.Color.Transparent;
            this.ucReportes.controlDescription = null;
            this.ucReportes.controlImage = ((System.Drawing.Image)(resources.GetObject("ucReportes.controlImage")));
            this.ucReportes.controlTitle = null;
            this.ucReportes.formToOpen = null;
            this.ucReportes.Location = new System.Drawing.Point(12, 319);
            this.ucReportes.Name = "ucReportes";
            this.ucReportes.Size = new System.Drawing.Size(301, 92);
            this.ucReportes.TabIndex = 8;
            // 
            // ucOpcionesMenu5
            // 
            this.ucOpcionesMenu5.BackColor = System.Drawing.Color.Transparent;
            this.ucOpcionesMenu5.controlDescription = null;
            this.ucOpcionesMenu5.controlImage = null;
            this.ucOpcionesMenu5.controlTitle = null;
            this.ucOpcionesMenu5.formToOpen = null;
            this.ucOpcionesMenu5.Location = new System.Drawing.Point(12, 395);
            this.ucOpcionesMenu5.Name = "ucOpcionesMenu5";
            this.ucOpcionesMenu5.Size = new System.Drawing.Size(258, 78);
            this.ucOpcionesMenu5.TabIndex = 11;
            this.ucOpcionesMenu5.Load += new System.EventHandler(this.ucOpcionesMenu5_Load);
            // 
            // opReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(631, 485);
            this.Controls.Add(this.ucOpcionesMenu5);
            this.Controls.Add(this.ucOpcionesMenu4);
            this.Controls.Add(this.ucOpcionesMenu3);
            this.Controls.Add(this.ucOpcionesMenu2);
            this.Controls.Add(this.ucOpcionesMenu1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "opReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Comun.ucOpcionesMenu opTickets;
        private Comun.ucOpcionesMenu ucReportes;
        private Comun.ucOpcionesMenu ucOpcionesMenu1;
        private Comun.ucOpcionesMenu ucOpcionesMenu2;
        private Comun.ucOpcionesMenu ucOpcionesMenu3;
        private Comun.ucOpcionesMenu ucOpcionesMenu4;
        private Comun.ucOpcionesMenu ucOpcionesMenu5;




    }
}