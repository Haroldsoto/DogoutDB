namespace Dogout_Reporting_Application.Comun
{
    partial class ucOpcionesMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbControlImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbControlImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbControlImage
            // 
            this.pbControlImage.Location = new System.Drawing.Point(3, 0);
            this.pbControlImage.Name = "pbControlImage";
            this.pbControlImage.Size = new System.Drawing.Size(73, 86);
            this.pbControlImage.TabIndex = 0;
            this.pbControlImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(79, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "{Control Title}";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(82, 31);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(217, 55);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "(Descripcion)";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // ucOpcionesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbControlImage);
            this.Name = "ucOpcionesMenu";
            this.Size = new System.Drawing.Size(301, 92);
            this.Load += new System.EventHandler(this.ucOpcionesMenu_Load_1);
            this.Click += new System.EventHandler(this.ucOpcionesMenu_Click);
            this.MouseLeave += new System.EventHandler(this.ucOpcionesMenu_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ucOpcionesMenu_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pbControlImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbControlImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
    }
}
