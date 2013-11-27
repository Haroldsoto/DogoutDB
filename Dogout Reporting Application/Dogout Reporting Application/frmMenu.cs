using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading.Tasks;

namespace Dogout_Reporting_Application
{
    public partial class opReportes : Form
    {
        public static System.Timers.Timer aTimer;
        public opReportes()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
             ucOpcionesMenu2.formToOpen = new frmReportesApp();
             ucOpcionesMenu1.formToOpen = new frmGenerarTicket();
             ucOpcionesMenu3.formToOpen = new frmPagos();
             ucOpcionesMenu4.formToOpen = new frmVentas();
             ucOpcionesMenu5.formToOpen = new Ganador();
             //    Create a timer with a ten second interval.
             aTimer = new System.Timers.Timer(10000);

             // Hook up the Elapsed event for the timer.
             aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
             aTimer.Interval = rnd(15000,30000);
             aTimer.Enabled = true;
             
             
        }

public static int rnd(int desde, int hasta)
{
             Random rl = new Random();
             return rl.Next(desde, (hasta + 1));
}

        private void ucReportes_Load(object sender, EventArgs e)
        {

        }

        private void ucReportes_Click(object sender, EventArgs e)
        {
            
        }

        private void ucOpcionesMenu5_Load(object sender, EventArgs e)
        {

        }

        private void ucOpcionesMenu4_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
                
        public void NotificationDesktop(string Mensaje)
        {
            System.Media.SystemSounds.Exclamation.Play();
            notifyIcon.Visible = true;
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.BalloonTipText = Mensaje;
            notifyIcon.ShowBalloonTip(10000);
        }
       
       

       private void OnTimedEvent(object source, ElapsedEventArgs e)
       {
           int line = rnd(1, 30);

           NotificationDesktop("test");
       }

    }
}
