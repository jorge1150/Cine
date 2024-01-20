using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_datos
{
    public class ConexionDB
    {
        private SqlConnection connection = new SqlConnection("Server=DESKTOP-PB9FMAO; Database=Laboratorio; Integrated Security=true");

        public SqlConnection AbriConexion() {
            if (connection.State == ConnectionState.Closed) { 
                connection.Open();
            }
            return connection;
        }

        public SqlConnection CerrarConexion()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
