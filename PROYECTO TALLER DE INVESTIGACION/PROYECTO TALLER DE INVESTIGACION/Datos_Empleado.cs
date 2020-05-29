using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace PROYECTO_TALLER_DE_INVESTIGACION
{
    public partial class Datos_Empleado : Form
    {
        public Datos_Empleado()
        {
            InitializeComponent();
        }

        CE_Empleado objEntidades = new CE_Empleado();
        CN_Empleado objNegocio = new CN_Empleado();


        #region BTN SIGUIENTE
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            agregar_Emplado();
            objNegocio.SP_CREAR_EMPLEADO(objEntidades);
        }
        #endregion

        #region VOID AGREGAR DATOS_EMPLEADO
        private void agregar_Emplado()
        {
            objEntidades.Nombre_Empleado = txt_Nombre.Text.Trim();
            objEntidades.Edad = Convert.ToInt32(txt_Edad.Text.Trim());
            objEntidades.Puesto = txt_Puesto.Text.Trim();
            objEntidades.Turno = cbx_Turno.Text.Trim();
        }
        #endregion

    }
}
