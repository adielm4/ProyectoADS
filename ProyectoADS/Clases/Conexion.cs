using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    class Conexion
    {
        public static SqlConnection conn = null;

        public void conectar()
        {
           
            conn = new SqlConnection("Data Source=localhost;Initial Catalog=Gestor_Proyectos; integrated security=true");
           
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void desconectar()
        {
            conn.Close();
        }
    }
}
