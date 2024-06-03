using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Social.CapaDatos
{
    public abstract class Repositorio
    {
        private readonly string CadenaConexion;
        public Repositorio()
        {
            CadenaConexion = "server =.; database=RedSocial; integrated security=true";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
