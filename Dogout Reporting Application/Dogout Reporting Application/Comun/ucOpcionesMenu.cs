using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogout_Reporting_Application.Comun
{
    public partial class ucOpcionesMenu : UserControl
    {
        public Image _controlImage;
        public string _controlTitle;
        public string _controlDescription;
        public Form _formToOpen;

        /// <summary>
        /// Establece o retorna la imagen que se usara en el control
        /// </summary>
        public Image controlImage
        {
            get { return _controlImage; }
            set { _controlImage = value; }
        }

        /// <summary>
        /// Establece o retorna el titulo del control
        /// </summary>
        public string controlTitle
        {
            get { return _controlTitle; }
            set { _controlTitle = value; }
        }

        /// <summary>
        /// Establece o retorna la descripcion del control
        /// </summary>
        public string controlDescription
        {
            get { return _controlDescription; }
            set { _controlDescription = value; }
        }

        /// <summary>
        /// Establece o retorna el nombre del formulario que abrira el control
        /// </summary>
        public Form formToOpen
        {
            get { return _formToOpen; }
            set { _formToOpen = value; }
        }
        
        public ucOpcionesMenu()
        {
            InitializeComponent();
        }


        public void ucOpcionesMenu_Load_1(object sender, EventArgs e)
        {
            this.pbControlImage.Image = _controlImage;
            this.lblTitle.Text = _controlTitle;
            this.lblDescription.Text = _controlDescription;
        }

        public void ucOpcionesMenu_Click(object sender, EventArgs e)
        {
            if (_formToOpen != null)
                _formToOpen.ShowDialog();
            else
                MessageBox.Show("ACCESO DENEGADO.", "DOGOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ucOpcionesMenu_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }

        public void ucOpcionesMenu_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Dogout_Reporting_Application.Properties.Resources.opControlBG;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            if (_formToOpen != null)
                _formToOpen.ShowDialog();
            else
                MessageBox.Show("ACCESO DENEGADO.", "DOGOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            if (_formToOpen != null)
                _formToOpen.ShowDialog();
            else
                MessageBox.Show("ACCESO DENEGADO.", "DOGOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
