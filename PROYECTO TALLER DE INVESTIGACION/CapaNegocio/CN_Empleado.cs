using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    
    public class CN_Empleado
    {
        CD_Empleado objDatos = new CD_Empleado();

        #region SP_CREAR_EMPLEADO
        public void SP_CREAR_EMPLEADO(CE_Empleado _Empleado)
        {
            objDatos.SP_CREAR_EMPLEADO(_Empleado);
        }
        #endregion
    }
}
