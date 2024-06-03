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
            //CadenaConexion = "workstation id=RedSocial.mssql.somee.com;packet size=4096;user id=JEINER_SQLLogin_1;pwd=ossejix6nm;data source=RedSocial.mssql.somee.com;persist security info=False;initial catalog=RedSocial";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
