using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=Acer; DataBase=NOM_035; Integrated Security=true");

        #region ABRIR CONEXION
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
                 return Conexion;
        }
        #endregion

        #region CERRAR CONEXION
        public SqlConnection CerrarConexion()
        {
            if(Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
        #endregion
    }
}
