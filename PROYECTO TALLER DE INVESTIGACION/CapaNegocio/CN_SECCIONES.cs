using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_SECCIONES
    {
        CD_Secciones objSecciones = new CD_Secciones();

        #region SP_SECCION_I
        public void SP_SECCION_I(CE_Seccion_I seccion_I)
        {
            objSecciones.SP_SECCION_I(seccion_I);
        }
        #endregion

        #region SP_SECCION_II
        public void SP_SECCION_II(CE_Seccion_II seccion_II)
        {
            objSecciones.SP_SECCION_II(seccion_II);
        }
        #endregion

        #region SP_SECCION_III
        public void SP_SECCION_III(CE_Seccion_III seccion_III)
        {
            objSecciones.SP_SECCION_III(seccion_III);
        }
        #endregion

        #region SP_SECCION_IV
        public void SP_SECCION_IV(CE_Seccion_IV seccion_IV)
        {
            objSecciones.SP_SECCION_IV(seccion_IV);
        }
        #endregion
    }
}
