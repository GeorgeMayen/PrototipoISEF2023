using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxPControlador;

namespace CxPVista
{
    public partial class ReservacionesAsientos : Form
    {
        GControlador cn = new GControlador();
        public ReservacionesAsientos()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //ruta de la ayuda
            string rutaAyuda = "../../../../../../../Ayuda/Modulos/CxP/MovimientosCxP/AyudaCxP.chm";
            Help.ShowHelp(ParentForm, rutaAyuda, "CuentasPorPagar.html");
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo1 = { txtIdAsiento, txtIdSala, txtFila, txtColumna };
            TextBox[] Grupo2 = { txtIdReservación, txtAsiento, txtSubtotal, txtIdFactura };
            //Función para insertar
            cn.OperacionesFinal(Grupo1, Grupo2, "asientos", "reservaciones");
            limpiar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
                
        }
        public void limpiar()
        {
            //limpiando textbox
            txtIdAsiento.Text = "";
            txtIdSala.Text = "";
            txtFila.Text = "";
            txtColumna.Text = "";
            txtIdReservación.Text = "";
            txtAsiento.Text = "";
            txtSubtotal.Text = "";
            txtIdFactura.Text = "";
        }
    }
}
