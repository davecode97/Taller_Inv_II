using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Empleado
    {

        CD_Conexion objConexion = new CD_Conexion();
        SqlCommand Comando = new SqlCommand();

        #region SP_CREAR_EMPLEADO
        public void SP_CREAR_EMPLEADO(CE_Empleado _Empleado)
        {
            Comando.Connection = objConexion.AbrirConexion();
            Comando.CommandText = "SP_CREAR_EMPLEADO";
            Comando.CommandType = CommandType.StoredProcedure;
            
            Comando.Parameters.AddWithValue("@nombre_empleado", _Empleado.Nombre_Empleado);
            Comando.Parameters.AddWithValue("@edad", _Empleado.Edad);
            Comando.Parameters.AddWithValue("@puesto", _Empleado.Puesto);
            Comando.Parameters.AddWithValue("@turno", _Empleado.Turno);

            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            objConexion.CerrarConexion();
        }
        #endregion
    }
}
