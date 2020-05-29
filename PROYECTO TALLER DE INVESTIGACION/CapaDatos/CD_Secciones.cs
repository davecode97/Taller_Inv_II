using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Secciones
    {
        CD_Conexion Conexion = new CD_Conexion();
        SqlCommand Comando = new SqlCommand();

        #region SP_SECCION_I
        public void SP_SECCION_I(CE_Seccion_I seccion_I)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SP_SECCION_I";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@cuestionario_i_i", seccion_I.CUESTONARIO_I_I);

            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();
        }
        #endregion

        #region SP_SECCION_II
        public void SP_SECCION_II(CE_Seccion_II seccion_II)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SP_SECCION_II";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@cuestionario_ii_i", seccion_II.CUESTIONARIO_II_I);
            Comando.Parameters.AddWithValue("@cuestionario_ii_ii", seccion_II.CUESTIONARIO_II_II);

            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();
        }
        #endregion

        #region SP_SECCION_III
        public void SP_SECCION_III(CE_Seccion_III seccion_III)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SP_SECCION_III";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@cuestionario_iii_i", seccion_III.CUESTIONARIO_III_I);
            Comando.Parameters.AddWithValue("@cuestionario_iii_ii", seccion_III.CUESTIONARIO_III_II);
            Comando.Parameters.AddWithValue("@cuestionario_iii_iii", seccion_III.CUESTIONARIO_III_III);
            Comando.Parameters.AddWithValue("@cuestionario_iii_iv", seccion_III.CUESTIONARIO_III_IV);
            Comando.Parameters.AddWithValue("@cuestionario_iii_v", seccion_III.CUESTIONARIO_III_V);
            Comando.Parameters.AddWithValue("@cuestionario_iii_vi", seccion_III.CUESTIONARIO_III_VI);
            Comando.Parameters.AddWithValue("@cuestionario_iii_vii", seccion_III.CUESTIONARIO_III_VII);

            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();
        }

        #endregion

        #region SP_SECCION_IV
        public void SP_SECCION_IV(CE_Seccion_IV seccion_IV)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SP_SECCION_IV";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@cuestionario_iv_i", seccion_IV.CUESTIONARIO_IV_I);
            Comando.Parameters.AddWithValue("@cuestionario_iv_ii", seccion_IV.CUESTIONARIO_IV_II);
            Comando.Parameters.AddWithValue("@cuestionario_iv_iii", seccion_IV.CUESTIONARIO_IV_III);
            Comando.Parameters.AddWithValue("@cuestionario_iv_iv", seccion_IV.CUESTIONARIO_IV_IV);
            Comando.Parameters.AddWithValue("@cuestionario_iv_v", seccion_IV.CUESTIONARIO_IV_V);

            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();
        }
        #endregion
    }
}
