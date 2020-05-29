using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Acceso
    {
        CD_Conexion Conexion = new CD_Conexion();

        SqlCommand Comando = new SqlCommand();

        #region SP_ACCESO
        public bool Acceso(CE_Acceso _Acceso)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SP_ACCESO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@username", _Acceso.Username);
            Comando.Parameters.AddWithValue("@pass", _Acceso.Password);

            SqlDataReader reader = Comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
