using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class CE_Empleado
    {
        private int _Id_Empleado;
        private string _Nombre_Empleado;
        private int _Edad;
        private string _Puesto;
        private string _Turno;

        public int Id_Empleado { get => _Id_Empleado; set => _Id_Empleado = value; }
        public string Nombre_Empleado { get => _Nombre_Empleado; set => _Nombre_Empleado = value; }
        public int Edad { get => _Edad; set => _Edad = value; }
        public string Puesto { get => _Puesto; set => _Puesto = value; }
        public string Turno { get => _Turno; set => _Turno = value; }
    }
}
