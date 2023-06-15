using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CxPVista
{
    public partial class RegistroPunto : Form
    {
        public RegistroPunto()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            //Navegador
            NavegadorVista.Navegador.idApp = "5004";
            TextBox[] Grupotextbox = { txtId, txtPuntosA, txtCliente, txtPuntosU };
            TextBox[] Idtextbox = { txtId, txtPuntosA };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "sig");
        }
    }
}
