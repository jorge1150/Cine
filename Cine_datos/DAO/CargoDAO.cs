using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_datos.DAO
{
    public class CargoDAO
    {
        private ConexionDB conexionDB = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void CrearCargo(Cargo cargo) {
            ejecutarSql.Connection = conexionDB.AbriConexion();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
