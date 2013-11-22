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
            this.ucReportes = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.ucOpcionesMenu1 = new Dogout_Reporting_Application.Comun.ucOpcionesMenu();
            this.SuspendLayout();
            // 
            // ucReportes
            // 
            this.ucReportes.BackColor = System.Drawing.Color.Transparent;
            this.ucReportes.controlDescription = "Se muestran los reportes relacionados a la banca Dogout";
            this.ucReportes.controlImage = global::Dogout_Reporting_Application.Properties.Resources.reports;
            this.ucReportes.controlTitle = "Reportes";
            this.ucReportes.formToOpen = null;
            this.ucReportes.Location = new System.Drawing.Point(12, 54);
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
            this.ucOpcionesMenu1.Location = new System.Drawing.Point(12, 91);
            this.ucOpcionesMenu1.Name = "ucOpcionesMenu1";
            this.ucOpcionesMenu1.Size = new System.Drawing.Size(269, 91);
            this.ucOpcionesMenu1.TabIndex = 0;
            // 
            // opReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 536);
            this.Controls.Add(this.ucReportes);
            this.Controls.Add(this.ucOpcionesMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "opReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Comun.ucOpcionesMenu ucOpcionesMenu1;
        private Comun.ucOpcionesMenu ucReportes;




    }
}