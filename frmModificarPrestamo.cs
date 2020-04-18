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
    public partial class frmModificarPrestamo : Form
    {

        SqlConnection con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ; MultipleActiveResultSets = true ");

        public frmModificarPrestamo()
        {
            InitializeComponent();
        }

        private void btnConsultarPrestamo_Click(object sender, EventArgs e)
        {
            con.Open();
            string idCuenta = txtNumeroCuenta.Text;
            string cadena = "SELECT * FROM BANCO.VW_BALANCE_TOTAL_PRESTAMOS WHERE idcuenta='" + idCuenta + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                txtNumeroCuenta.Enabled = false;
                labelNP.Visible = true;
                lblNumeroPrestamo.Visible = true;

                btnGuardarCambios.Enabled = true;
                btnConsultarPrestamo.Enabled = false;
                btnLimpiarCampos.Enabled = true;               

                dgvDetalleTransacciones.Visible = true;
                

                lblNumeroPrestamo.Text = registro["idcuenta"].ToString();
                lblBalanceInicial.Text = registro["balanceinicial"].ToString();
                lblBalanceActual.Text = registro["balanceactual"].ToString();
                lblCuotaMensual.Text = registro["cuotamensual"].ToString();
                lblCuotasPendientes.Text = registro["cuotaspendientes"].ToString();

                con.Close();
            }
            else
            {
                MessageBox.Show("No existe un prestamo con ese número de cuenta");
                con.Close();
                txtNumeroCuenta.Text = "";
            }

            DetallesTransacciones();
        }

        private void DetallesTransacciones()
        {

            SqlConnection con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ; MultipleActiveResultSets = true");
            con.Open();
            string idcuenta = txtNumeroCuenta.Text;
            string query2 = "SELECT numerotransaccion AS 'No. Transacción', fecha AS 'Fecha', tipo AS 'Tipo de Transacción', monto AS 'Monto' FROM [BANCO].VW_HISTORICO_PRESTAMOS WHERE idcuenta='" + idcuenta + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);

            /*TODO: Corregir Error al Consultar Cliente sin prestamos*/

            dgvDetalleTransacciones.DataSource = dt;
            con.Close();

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            con.Open();
            
            string sMonto = txtMonto.Text;
            string sTipoTransaccion = txtTipoTransaccion.Text;           

            

            string line = "";
            switch (sTipoTransaccion)
            {
                case "Credito":
                    line = "1";
                    break;
                case "credito":
                    line = "1";
                    break;
                case "CREDITO":
                    line = "1";
                    break;

                case "Debito":
                    line = "2";
                    break;
                case "debito":
                    line = "2";
                    break;
                case "DEBITO":
                    line = "2";
                    break;               

                default:
                    line = "1";
                    break;
            }

            int tipoTransaccion = int.Parse(line);//INSERT

            string sCuentaId = lblNumeroPrestamo.Text;
            int cuentaId = int.Parse(sCuentaId);//INSERT

            double monto = double.Parse(sMonto);//INSERT

            DateTime fecha = DateTime.Now;//INSERT         
            
                        
            string cadena = "INSERT INTO BANCO.Transacciones (idcuenta, idtipotransaccion, monto, fecha) VALUES('" + cuentaId + "','" + tipoTransaccion + "','" + monto + "','" + fecha + "')";

            SqlCommand comando = new SqlCommand(cadena, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("La transacción se realizó correctamente");           

            
            ActualizarCuotas();

            ActualizarPagina();

            con.Close();
            txtMonto.Text = "";
            txtTipoTransaccion.Text = "";
        }

        private void ActualizarCuotas()
        {
            
            string sCuentaId = txtNumeroCuenta.Text;
            int idCuenta = int.Parse(sCuentaId);
            int abonarCuota = 1;

            string cadena = "UPDATE BANCO.Prestamos SET cuotaspagadas = (cuotaspagadas + "+ abonarCuota+ ") WHERE idcuenta='" + idCuenta + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();


            if (registro.Read())
            {                
                MessageBox.Show("Cuotas actualizadas!");               

                           
                

            }
        }

        private void ActualizarPagina()
        {
            
            string idCuenta = txtNumeroCuenta.Text;
            string cadena = "SELECT * FROM BANCO.VW_BALANCE_TOTAL_PRESTAMOS WHERE idcuenta='" + idCuenta + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                labelNP.Visible = true;
                lblNumeroPrestamo.Visible = true;

                dgvDetalleTransacciones.Visible = true;

                lblNumeroPrestamo.Text = registro["idcuenta"].ToString();
                lblBalanceInicial.Text = registro["balanceinicial"].ToString();
                lblBalanceActual.Text = registro["balanceactual"].ToString();
                lblCuotaMensual.Text = registro["cuotamensual"].ToString();
                lblCuotasPendientes.Text = registro["cuotaspendientes"].ToString();

                

            }
            else
            {
                MessageBox.Show("No existe un prestamo con ese número de cuenta");
                con.Close();
                txtNumeroCuenta.Text = "";
            }

            DetallesTransacciones();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNumeroCuenta.Enabled = true;

            lblNumeroPrestamo.Text = "";
            lblBalanceInicial.Text = "";
            lblBalanceActual.Text = "";
            lblCuotaMensual.Text = "";
            lblCuotasPendientes.Text = "";
            txtNumeroCuenta.Text = "";
            txtMonto.Text = "";
            txtTipoTransaccion.Text = "";

            dgvDetalleTransacciones.Visible = false;

            btnConsultarPrestamo.Enabled = true;
            btnLimpiarCampos.Enabled = false;

            btnGuardarCambios.Enabled = false;
          
        }
    }
}
