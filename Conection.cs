using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Sistema_Prestamista
{
    public partial class Conection
    {
        SqlConnection con;

       
        public void Conectar()
        {
            con = new SqlConnection("server=(localdb)\\myLocalDB ; database=prestamos-app ; integrated security = true ");
            con.Open();
            //MessageBox.Show("Conexion establecida!");           
            
        }

        public void Desconectar()
        {
            con.Close();
        }
    }
}
