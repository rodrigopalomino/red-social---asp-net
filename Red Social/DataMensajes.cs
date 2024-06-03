using Red_Social.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Social
{
   public class DataMensajes : RepositorioMaestro
    {
        private string usuario;
        private int id_usuario;
        private byte[] perfil;
        private int id_usrEmisor;
        private int id_usrReceptor;
        private string mensaje;
        private DateTime fechaHora;

        public string Usuario { get => usuario; set => usuario = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public byte[] Perfil { get => perfil; set => perfil = value; }
        public int Id_usrEmisor { get => id_usrEmisor; set => id_usrEmisor = value; }
        public int Id_usrReceptor { get => id_usrReceptor; set => id_usrReceptor = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }

        public List<DataMensajes>UsrMje()
        {
            string comando = @"with cte as(
select u.usuario,u.perfil, m.mensaje, m.id_usrEmisor,m.fechaHora, row_number() over (partition by u.usuario order by m.fechaHora desc) as row
from Mensajes as m, usuarios as u where (id_usrEmisor=@idLogin and id_usrReceptor = u.id_usuario)
or (id_usrEmisor = u.id_usuario and id_usrReceptor=@idLogin)) 
select c.usuario as [Usuario], c.perfil as[Perfil],
c.mensaje as [Mensaje], c.id_usrEmisor as[Emisor]
from cte c where row = 1 order by c.fechaHora desc;";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idLogin", Cache.id_usuario));
            var tabla = ExecuteReader(comando);
            var ListaUsrMje = new List<DataMensajes>();
            foreach(DataRow item in tabla.Rows)
            {
                ListaUsrMje.Add(new DataMensajes { usuario = item[0].ToString(), perfil = (byte[])item[1], mensaje = item[2].ToString(), id_usrEmisor = Convert.ToInt32(item[3]) });
            }
            return ListaUsrMje;
        }

        public List<DataMensajes> MensajeUser(string Usr)
        {
            string comando = @"select * from Mensajes where  (id_usrEmisor = @LoginUser and id_usrReceptor = (select id_usuario from Usuarios where usuario=@usuario))
or (id_usrReceptor = @LoginUser and id_usrEmisor = (select id_usuario from Usuarios where usuario =  @usuario))";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@LoginUser", Cache.id_usuario));
            parametros.Add(new SqlParameter("@usuario", Usr));
            var tabla = ExecuteReader(comando);
            var MensajeConUser = new List<DataMensajes>();
            foreach (DataRow item in tabla.Rows)
            {
                MensajeConUser.Add(new DataMensajes { Id_usrEmisor =Convert.ToInt32(item[0]),mensaje = item[2].ToString()});
            }
            return MensajeConUser;
        }

        public void NuevoMensaje(string UsuarioR)
        {
            string comando = @"insert into Mensajes values (@id_emisor,(select id_usuario from Usuarios where usuario =@usr_receptor),@mensaje, @fechaHora)";
            parametros = new List<SqlParameter>();
            parametros.Add (new SqlParameter("@id_emisor", Cache .id_usuario)); 
            parametros.Add(new SqlParameter("@usr_receptor", UsuarioR));
            parametros.Add (new SqlParameter ("@mensaje", mensaje)); 
            parametros.Add (new SqlParameter("@fechaHora" , DateTime.Now)); 
            ExecuteNonQuery(comando);
}
    }
}
