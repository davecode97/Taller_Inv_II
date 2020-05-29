using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class CE_Seccion_II
    {
        private int _ID_SECCION_II;
        private string _CUESTIONARIO_II_I;
        private string _CUESTIONARIO_II_II;

        public string CUESTIONARIO_II_I { get => _CUESTIONARIO_II_I; set => _CUESTIONARIO_II_I = value; }
        public string CUESTIONARIO_II_II { get => _CUESTIONARIO_II_II; set => _CUESTIONARIO_II_II = value; }
        public int ID_SECCION_II { get => _ID_SECCION_II; set => _ID_SECCION_II = value; }
    }
}
