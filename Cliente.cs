using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Sistema_Prestamista
{
    public partial class Cliente : Form
    {
        Conection con = new Conection();
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form formularioRegistrarCliente = new frmRegistrarCliente();
            formularioRegistrarCliente.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formularioConsultarCliente = new frmConsultarCliente();
            formularioConsultarCliente.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formularioModificarCliente = new frmModificarCliente();
            formularioModificarCliente.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formularioEliminarCliente = new frmEliminarCliente();
            formularioEliminarCliente.Show();
            this.Close();
        }
    }
}
