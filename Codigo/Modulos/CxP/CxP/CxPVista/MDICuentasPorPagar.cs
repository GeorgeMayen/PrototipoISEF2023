using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxPControlador;

namespace CxPVista
{
    public partial class MDICuentasPorPagar : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        TControlador controlador = new TControlador();
        public MDICuentasPorPagar()
        {
            InitializeComponent();
            customizeDesing();
            Button[] apps = { btnConcepto,btnMoviminetos};
            cnseg.deshabilitarApps(apps);
            //Dandoles acceso
            cnseg.getAccesoApp(5004, apps[0]);// la 0
            cnseg.getAccesoApp(5101, apps[1]);// la 1
 
        }

        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelcatalogo.Visible = false;
            panelProcesos.Visible = false;
            panelReportes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelcatalogo.Visible == true)
                panelcatalogo.Visible = false;
            if (panelProcesos.Visible == true)
                panelProcesos.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelcatalogo);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProcesos);
        }

        private void btnMoviminetos_Click(object sender, EventArgs e)
        {
            //Codigo
            ReservacionesAsientos RA = new ReservacionesAsientos();
            RA.MdiParent = this;
            RA.Show();
            //Ocultar submenu
            hideSubMenu();
        }


        private void btnConcepto_Click(object sender, EventArgs e)
        {
            //Codigo
            RegistroPunto Rpuntos = new RegistroPunto();
            Rpuntos.MdiParent = this;
            Rpuntos.Show();
            //Ocultar submenu
            hideSubMenu();
        }

 

        private void btnBalance_Click(object sender, EventArgs e)
        {
            //Codigo
            Balance balance = new Balance();
            balance.MdiParent = this;
            balance.Show();
            //Ocultar submenu
            hideSubMenu();

        }

    }
}
