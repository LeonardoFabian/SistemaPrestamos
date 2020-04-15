using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Prestamista
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form formularioCliente = new Cliente();
            formularioCliente.Show();            
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Form formularioServicio = new Servicio();
            formularioServicio.Show();
        }
    }
}
