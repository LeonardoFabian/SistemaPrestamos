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
    public partial class frmModificarCliente : Form
    {

        SqlConnection con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ");

        public frmModificarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string cedula = txtCedula.Text;
            string cadena = "SELECT cedula, nombre, apellido, genero, (SELECT FORMAT(fechanacimiento, 'dd/MM/yyyy ')) AS fnacimiento, fecharegistro, direccion, telefono, correo, ultimaactualizacion FROM BANCO.Clientes WHERE cedula='" + cedula + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                txtCedula.Enabled = false;

                btnGuardarCambios.Enabled = true;
                btnLimpiarCampos.Enabled = true;
                btnBuscarCliente.Enabled = false;

                txtNombre.Text = registro["nombre"].ToString();
                txtApellido.Text = registro["apellido"].ToString();
                txtCedula.Text = registro["cedula"].ToString();
                
                txtFechaNacimiento.Text = registro["fnacimiento"].ToString();             

                txtGenero.Text = registro["genero"].ToString();
                txtTelefono.Text = registro["telefono"].ToString();
                txtCorreo.Text = registro["correo"].ToString();
                txtDireccion.Text = registro["direccion"].ToString();
                lblUltimaActualizacion.Text = registro["ultimaactualizacion"].ToString();

                con.Close();
                
            }
            else
            {
                MessageBox.Show("No se ha encontrado un cliente con ese número de cédula");
                con.Close();
                txtCedula.Text = "";
            }
            

                        
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            con.Open();
          
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
                       

            //DateTime fechanacimiento = DateTime.ParseExact(txtFechaNacimiento.Text, "dd/MM/yyyy", null);

            DateTime fechamodificacion = DateTime.Now;
            //string genero = txtGenero.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;

            string cadena = "UPDATE [BANCO].[Clientes] SET nombre='" + nombre + "', apellido='" + apellido + "', telefono='" + telefono + "', correo='" + correo + "', direccion='" + direccion + "', ultimaactualizacion='" + fechamodificacion + "' WHERE cedula='" + cedula + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            int cant;
            cant = comando.ExecuteNonQuery();

            if(cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del cliente correctamente");

                

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCedula.Text = "";
                txtFechaNacimiento.Text = "";
                txtGenero.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                lblUltimaActualizacion.Text = "";
                con.Close();

                txtCedula.Enabled = true;
                btnBuscarCliente.Enabled = true;
                btnGuardarCambios.Enabled = false;
                btnLimpiarCampos.Enabled = false;
                

            }
            else
            {
                MessageBox.Show("Error al modificar el cliente");
                con.Close();
                btnGuardarCambios.Enabled = false;
                btnLimpiarCampos.Enabled = false;
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = true;

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtFechaNacimiento.Text = "";
            txtGenero.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            lblUltimaActualizacion.Text = "";           
            btnGuardarCambios.Enabled = false;
            btnLimpiarCampos.Enabled = false;
        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
