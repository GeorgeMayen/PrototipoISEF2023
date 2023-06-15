using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
//Comentado por George Mayén 25/02/2023
namespace Vista_Seguridad
{
    public partial class Menup : Form
    {
        Controlador cn = new Controlador();

        //Método que guarda en un arreglo de tipo botón los botones que se tienen en el formulario. Se les da permiso a los diferentes botones de acuerdo a la función que realice este
        public Menup()
        {
            InitializeComponent();

            Button[] apps = { btnseguridad, btnCxP};
            cn.deshabilitarApps(apps);
            cn.getAccesoApp(1000, apps[0]);//la 0
            cn.getAccesoApp(5000, apps[1]);//la 1




        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        public void btnlogout_Click(object sender, EventArgs e)
        {
            MenuSeguridad b = new MenuSeguridad();
            b.Show();
            cn.setBtitacora("1000", "Ingreso Seguridad");
            //this.Close();
        }

        public void btnVentas_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
              b.Show();
            cn.setBtitacora("2000", "Ingreso Ventas");*/
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login b = new Login();
            cn.setBtitacora("999", "Cerro Sesion");
            b.Show();
            this.Close();
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btncompras_Click(object sender, EventArgs e)
        {
            /*ComprasVista.central_Compra b = new ComprasVista.central_Compra();
            b.Show();*/
            cn.setBtitacora("3000", "Ingreso Compras");
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnProduccion_Click(object sender, EventArgs e)
        {
            /*CPC_Vista.CPC_MDI menuCPC = new CPC_Vista.CPC_MDI();
            menuCPC.Show();
            cn.setBtitacora("4000", "Ingreso CxC");*/
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo
        private void btnnominas_Click(object sender, EventArgs e)
        {
           CxPVista.MDICuentasPorPagar b = new CxPVista.MDICuentasPorPagar();
            b.Show();
            cn.setBtitacora("5000", "Ingreso ExamenFinal");
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            /*CxPVista.MDICuentasPorPagar b = new CxPVista.MDICuentasPorPagar();
            b.Show();
            cn.setBtitacora("6000", "Ingreso Inventario");*/
        }
        //Método que ingresa un valor a la bitacora de acuerdo el módulo

    }
}
