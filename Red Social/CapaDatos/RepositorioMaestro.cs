﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Social.CapaDatos
{
    public abstract class RepositorioMaestro : Repositorio
    {
        protected List<SqlParameter> parametros;
        protected void ExecuteNonQuery(string transactSql) //Ejecutar sentencias de texto insert, update, delete con parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }

        
        protected DataTable ExecuteReader(string transactSql) //Devolver tablas ejecutando consultas de texto con parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    SqlDataReader lector = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }

       
    }
}
