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
    public partial class frmEliminarCliente : Form
    {

        SqlConnection con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ");

        public frmEliminarCliente()
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
                btnEliminarCliente.Enabled = true;
                btnLimpiarCampos.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se ha encontrado un cliente con ese número de cédula");
                con.Close();
                txtCedula.Text = "";
            }
            

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtFechaNacimiento.Text = "";
            txtGenero.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            lblUltimaActualizacion.Text = "";
            btnEliminarCliente.Enabled = false;
            btnLimpiarCampos.Enabled = false;
        }

        public bool ConsultarPrestamos()
        {
            con.Open();
            string cedula = txtCedula.Text;
            bool balancePendiente = true;
            string cadena = "SELECT balanceactual FROM BANCO.VW_BALANCE_TOTAL_PRESTAMOS WHERE cedula='" + cedula + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();


            if (registro.Read())
            {
                double balanceactual = Double.Parse(registro["balanceactual"].ToString());

                if(balanceactual < 0)
                {
                     balancePendiente = false;
                }
                else
                {
                    balancePendiente = true;
                }
            }
            return balancePendiente;
            
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            bool tieneBalancePendiente = ConsultarPrestamos();

            if(tieneBalancePendiente == false)
            {
                con.Open();
                string cedula = txtCedula.Text;
                string cadena = "DELETE FROM [BANCO].[Clientes] WHERE cedula=" + cedula;
                SqlCommand comando = new SqlCommand(cadena, con);

                int cant;
                cant = comando.ExecuteNonQuery();

                if(cant == 1)
                {
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtCedula.Text = "";
                    txtFechaNacimiento.Text = "";
                    txtGenero.Text = "";
                    txtTelefono.Text = "";
                    txtCorreo.Text = "";
                    txtDireccion.Text = "";
                    lblUltimaActualizacion.Text = "";
                    btnEliminarCliente.Enabled = false;
                    btnLimpiarCampos.Enabled = false;
                    

                    MessageBox.Show("Se ha eliminado el cliente");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar un cliente con balance pendiente");
                con.Close();
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCedula.Text = "";
                txtFechaNacimiento.Text = "";
                txtGenero.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                lblUltimaActualizacion.Text = "";
                btnEliminarCliente.Enabled = false;
                btnLimpiarCampos.Enabled = false;
            }
        }
    }
}
