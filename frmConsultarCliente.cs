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
    public partial class frmConsultarCliente : Form
    {       

        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ; MultipleActiveResultSets = true ");
            con.Open();            
            string cedula = txtCedula.Text;
            string cadena = "SELECT * FROM BANCO.VW_BALANCE_TOTAL_PRESTAMOS WHERE cedula='" + cedula + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                lblNombre.Visible = true;
                lblCedula.Visible = true;

                lblNombre.Text = registro["nombre"].ToString();
                lblCedula.Text = registro["cedula"].ToString();
                lblBalanceInicial.Text = registro["balanceinicial"].ToString();
                lblBalanceActual.Text = registro["balanceactual"].ToString();
                lblCuotaMensual.Text = registro["cuotamensual"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un registro con ese número de cédula");
                con.Close();
                txtCedula.Text = "";
            }

            DetallesPrestamos();         
            
        }

        private void DetallesPrestamos()
        {
            SqlConnection con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ; MultipleActiveResultSets = true");
            con.Open();
            string cedula = txtCedula.Text;
            string query2 = "SELECT producto AS 'Producto', deudaactual AS 'Deuda Actual', fechaproximopago AS 'Fecha Proximo Pago', montocuotas AS 'Monto Cuotas', cuotaspendientes AS 'Cuotas Pendientes', estado As 'Estado', tasa AS 'Tasa' FROM BANCO.VW_DETALLE_PRESTAMOS WHERE cedula='" + cedula + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);       
            DataTable dt = new DataTable();
            da.Fill(dt);

            /*TODO: Corregir Error al Consultar Cliente sin prestamos*/

            dgvDetallesPrestamos.DataSource = dt;
            con.Close();
        }
    }
}
