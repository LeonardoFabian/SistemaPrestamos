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
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ");
            con.Open();
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;            
            /*DateTime fechanacimiento = DateTime.ParseExact(txtFechaNacimiento.Text, "d", null);*/
            DateTime fechanacimiento = DateTime.ParseExact(txtFechaNacimiento.Text, "dd/MM/yyyy", null);
            DateTime fecharegistro = DateTime.Now;
            string genero = txtGenero.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;


            string cadena = "INSERT INTO BANCO.Clientes (cedula, nombre, apellido, genero, fechanacimiento, fecharegistro, direccion, telefono, correo) VALUES('" + cedula + "','" + nombre + "','" + apellido + "','" + genero + "','" + fechanacimiento + "','" + fecharegistro + "','" + direccion + "','" + telefono + "','" + correo + "')";
            SqlCommand comando = new SqlCommand(cadena, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("El cliente fue registrado correctamente");

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNacimiento.Text = "";          
            txtGenero.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";

            con.Close();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
