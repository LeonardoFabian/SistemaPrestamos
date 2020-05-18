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
using System.Globalization;

namespace Sistema_Prestamista
{      

    public partial class frmRegistrarPrestamo : Form
    {

        SqlConnection con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ; MultipleActiveResultSets = true");

        NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol;
        CultureInfo provider = new CultureInfo("es-DO");

        public frmRegistrarPrestamo()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            con.Open();
            string cedula = txtCedula.Text;

            string cadena = "SELECT id, cedula, CONCAT(nombre , ' ' , apellido) AS 'nombrecompleto' FROM BANCO.Clientes WHERE cedula='" + cedula + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                lblNombre.Text = registro["nombrecompleto"].ToString();                
                lblClienteid.Text = "Cliente ID: "+registro["id"].ToString();
                lblEstatusCliente.Text = "El cliente está registrado";

                lblNombre.Visible = true;
                lblClienteid.Visible = true;
                lblEstatusCliente.Visible = true;

                con.Close();

                btnBuscarCliente.Enabled = false;
                btnLimpiarCampos.Enabled = true;
                txtCuentaNumero.Enabled = true;
                btnConsultarNumeroCuenta.Enabled = true;
                txtMonto.Enabled = true;
                txtTipoPrestamo.Enabled = true;
                txtPlazo.Enabled = true;
                btnValidar.Enabled = true;


                lblMensaje1.Enabled = false;
                lblMensaje2.Enabled = false;
            }
            else
            {
                lblNombre.Text = "Cliente no existe!";
                lblClienteid.Text = "Favor proceder con su registro";
                lblEstatusCliente.Text = "El cliente no está registrado";

                lblNombre.Visible = true;
                lblClienteid.Visible = true;
                lblEstatusCliente.Visible = true;

                btnBuscarCliente.Enabled = false;
                btnLimpiarCampos.Enabled = true;

                //Desabilitar todos los inputs y buttons
                txtCuentaNumero.Enabled = false;
                btnConsultarNumeroCuenta.Enabled = false;
                btnRegistrarPrestamo.Enabled = false;

                con.Close();
            }
            con.Close();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "";
            lblClienteid.Text = "";
            lblEstatusCliente.Text = "";
            txtCedula.Text = "";

            btnBuscarCliente.Enabled = true;
            btnLimpiarCampos.Enabled = false;

            txtCuentaNumero.Enabled = false;
            btnConsultarNumeroCuenta.Enabled = false;
            txtMonto.Enabled = false;
            txtTipoPrestamo.Enabled = false;
            txtPlazo.Enabled = false;
            btnValidar.Enabled = false;

            lblMensaje1.Enabled = true;
            lblMensaje2.Enabled = true;

        }

        private void btnConsultarNumeroCuenta_Click(object sender, EventArgs e)
        {
            con.Open();
            string numeroCuenta = txtCuentaNumero.Text;

            string cadena = "SELECT cu.id AS 'idcuenta', CONCAT(cli.nombre , ' ' , cli.apellido) AS 'nombrecompleto' FROM BANCO.Cuentas cu JOIN BANCO.Clientes cli ON cu.idcliente = cli.id WHERE cu.id=" + numeroCuenta;
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                lblNombre.Text = registro["nombrecompleto"].ToString();
                lblClienteid.Text = "Número de cuenta: " + registro["idcuenta"].ToString();
                lblEstatusCliente.Text = "Esta cuenta ya existe";

                lblNombre.Visible = true;
                lblClienteid.Visible = true;
                lblEstatusCliente.Visible = true;


                txtCuentaNumero.Text = "";

                con.Close();              

            }

            else
            {
                lblNombre.Text = "Número de cuenta disponible";
                lblClienteid.Text = "";
                lblEstatusCliente.Text = "";
                lblNombre.Visible = true;

                con.Close();
            }

            con.Open();

            int ultimoIdCuenta = ConsultarUltimoNumeroDeCuenta();

            lblCuentaRecomendada.Text = "Ultimo número de cuenta registrado: " + ultimoIdCuenta;
            lblCuentaRecomendada.Visible = true;
            con.Close();
        }


        public int ConsultarUltimoNumeroDeCuenta()
        {
                      
            int ultimoNumeroCuenta = 0;
            string cadena = "SELECT TOP 1 id FROM BANCO.Cuentas ORDER BY id DESC";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro2 = comando.ExecuteReader();


            if (registro2.Read())
            {
                int valor = int.Parse(registro2["id"].ToString());

                if (valor != 0)
                {
                    ultimoNumeroCuenta = valor;
                    con.Close();
                }
                else
                {
                    
                }
            }
            return ultimoNumeroCuenta;

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            lblNombre.Visible = false;
            lblCuentaRecomendada.Visible = false;

            labelCuota.Visible = true;
            lblCuotaMensual.Visible = true;
            labelTasa.Visible = true;
            lblTasa.Visible = true;

            btnValidar.Enabled = false;
            btnRegistrarPrestamo.Enabled = true;


            string tipoPrestamo = txtTipoPrestamo.Text;

            string monto = txtMonto.Text;
            decimal decimalMonto = decimal.Parse(monto, style, provider);

            string plazo = txtPlazo.Text;
            int intPlazo = int.Parse(plazo);

            // Calcular cuota
            decimal calcularCuota = (decimalMonto / intPlazo);
            decimal roundCalcularCuota = decimal.Round(calcularCuota, 2);            

            string cuota = roundCalcularCuota.ToString();
            lblCuotaMensual.Text = cuota;

            string cuentaId = txtCuentaNumero.Text;

                                                               
            lblTasa.Text = "15.0";          


        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            con.Open();

            string sTipoPrestamo = txtTipoPrestamo.Text;

            string line = "";
            switch (sTipoPrestamo)
            {
                case "Personal":
                    line = "1";                    
                    break;
                case "personal":
                    line = "1";
                    break;
                case "PERSONAL":
                    line = "1";
                    break;

                case "Hipotecario":
                    line = "2";
                    break;
                case "hipotecario":
                    line = "2";
                    break;
                case "HIPOTECARIO":
                    line = "2";
                    break;

                case "Vehiculo":
                    line = "3";
                    break;
                case "vehiculo":
                    line = "3";
                    break;
                case "VEHICULO":
                    line = "3";
                    break;

                default:
                    line = "1";
                    break;
            }
           
            int tipoPrestamo = int.Parse(line);//INSERT



            string sCuentaId = txtCuentaNumero.Text;
            int cuentaId = int.Parse(sCuentaId);//INSERT

            string sMonto = txtMonto.Text;
            decimal decimalMonto = decimal.Parse(sMonto, style, provider);
            decimal roundedMonto = decimal.Round(decimalMonto, 2);
            decimal monto = roundedMonto;//INSERT

            string sPlazo = txtPlazo.Text;
            int plazo = int.Parse(sPlazo);//INSERT
            
            string sCuota = lblCuotaMensual.Text;
            decimal decimalCuota = decimal.Parse(sCuota, style, provider);
            decimal roundedCuota = decimal.Round(decimalCuota, 2);
            decimal cuota = roundedCuota;//INSERT

            DateTime fechaDesembolso = DateTime.Now;//INSERT

            string sTasa = lblTasa.Text;           
            double tasa = double.Parse(sTasa);//INSERT

            int cuotasPagadas = 0;//INSERT

            string estado = "1";//INSERT

         

           string cadena = "INSERT INTO BANCO.Prestamos (idtipoprestamo, idcuenta, valorinicial, plazo, montocuota, fechadesembolso, tasa, cuotaspagadas, estado) VALUES('" + tipoPrestamo + "','" + cuentaId + "','" + monto + "','" + plazo + "','" + cuota + "','" + fechaDesembolso + "','" + tasa + "','" + cuotasPagadas + "','" + estado + "')";

           SqlCommand comando = new SqlCommand(cadena, con);
           comando.ExecuteNonQuery();
           MessageBox.Show("El prestamo fue generado correctamente");

            

            labelCuota.Text = "";
            lblCuotaMensual.Text = "";
            labelTasa.Text = "";
            lblTasa.Text = "";

            btnValidar.Enabled = false;
            btnRegistrarPrestamo.Enabled = true;



            labelCuota.Visible = false;
            lblCuotaMensual.Visible = false;
            labelTasa.Visible = false;
            lblTasa.Visible = false;

            btnValidar.Enabled = false;
            btnRegistrarPrestamo.Enabled = false;

            
            
            txtTipoPrestamo.Text = "";
            txtPlazo.Text = "";

            con.Close();
            
            CrearCuenta();

            

        }

        private void CrearCuenta()
        {
            con.Open();
            string cedula = txtCedula.Text;
            string sCuenta = txtCuentaNumero.Text;
            string sMonto = txtMonto.Text;

            string cadena = "SELECT id FROM BANCO.Clientes WHERE cedula='" + cedula + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();
            

            if (registro.Read())
            {
                
                string sIdCliente = registro["id"].ToString();

                int idCliente = int.Parse(sIdCliente);
                int cuenta = int.Parse(sCuenta);
                int idTipoTransaccion = 3;

                decimal decimalMonto = decimal.Parse(sMonto, style, provider);
                decimal roundedMonto = decimal.Round(decimalMonto, 2);
                decimal monto = roundedMonto;
                DateTime fechaTransaccion = DateTime.Now;


                //Crear cuenta
                string query = "INSERT INTO BANCO.Cuentas(id, idcliente) VALUES(" + cuenta + "," + idCliente + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Número de cuenta crado!");

                // Registrar Transaccion
                string query2 = "INSERT INTO BANCO.Transacciones (idcuenta, idtipotransaccion, monto, fecha) VALUES(" + cuenta + "," + idTipoTransaccion + "," +  monto + ",'" + fechaTransaccion + "')";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Transaccion procesada!");


                txtCedula.Text = "";
                txtCuentaNumero.Text = "";
                txtMonto.Text = "";
                con.Close();
              

               

            }
        }

        
    }
}
