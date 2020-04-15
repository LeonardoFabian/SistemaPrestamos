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
    public partial class frmEliminarPrestamo : Form
    {

        SqlConnection con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ; MultipleActiveResultSets = true ");

        public frmEliminarPrestamo()
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
                labelNP.Visible = true;
                lblNumeroPrestamo.Visible = true;

                btnEliminarPrestamo.Enabled = true;
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






        public bool ConsultarPrestamos()
        {
            con.Open();
            string sCuentaId = txtNumeroCuenta.Text;
            bool balancePendiente = true;

            string cadena = "SELECT balanceactual FROM BANCO.VW_BALANCE_TOTAL_PRESTAMOS WHERE cedula='" + sCuentaId + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();


            if (registro.Read())
            {
                double balanceactual = double.Parse(registro["balanceactual"].ToString());

                if (balanceactual < 0)
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
       

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            bool tieneBalancePendiente = ConsultarPrestamos();

            if (tieneBalancePendiente == false)
            {
                con.Open();
                string sCuentaId = txtNumeroCuenta.Text;
                string cadena = "DELETE FROM [BANCO].[Prestamos] WHERE idcuenta=" + sCuentaId;
                SqlCommand comando = new SqlCommand(cadena, con);

                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant == 1)
                {
                    lblBalanceActual.Text = "";
                    lblBalanceInicial.Text = "";
                    lblCuotaMensual.Text = "";
                    lblCuotasPendientes.Text = "";
                    lblNumeroPrestamo.Text = "";
                    lblUltimaActualizacion.Text = "";

                    btnEliminarPrestamo.Enabled = false;
                    btnLimpiarCampos.Enabled = false;


                    MessageBox.Show("Se ha eliminado el cliente");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar un prestamo con balance pendiente");
                con.Close();
                lblBalanceActual.Text = "";
                lblBalanceInicial.Text = "";
                lblCuotaMensual.Text = "";
                lblCuotasPendientes.Text = "";
                lblNumeroPrestamo.Text = "";
                lblUltimaActualizacion.Text = "";

                btnEliminarPrestamo.Enabled = false;
                btnLimpiarCampos.Enabled = false;
            }
        }
    }
}
