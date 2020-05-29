using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_Acceso
    {
        CD_Acceso objDatos = new CD_Acceso();
        
        public bool SP_ACCESO(CE_Acceso _Acceso)
        {
            return objDatos.Acceso(_Acceso);
        }
    }
}
