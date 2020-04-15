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
    public partial class Servicio : Form
    {
        public Servicio()
        {
            InitializeComponent();
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            Form formularioRegistrarPrestamo = new frmRegistrarPrestamo();
            formularioRegistrarPrestamo.Show();
            this.Close();
        }

        private void btnConsultarPrestamo_Click(object sender, EventArgs e)
        {
            Form formularioConsultarPrestamo = new frmConsultarPrestamo();
            formularioConsultarPrestamo.Show();
            this.Close();
        }

        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            Form formularioModificarPrestamo = new frmModificarPrestamo();
            formularioModificarPrestamo.Show();
            this.Close();
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            Form formularioEliminarPrestamo = new frmEliminarPrestamo();
            formularioEliminarPrestamo.Show();
            this.Close();
        }
    }
}
