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
    public partial class Referencia1_4Form : Form
    {
        public Referencia1_4Form()
        {
            InitializeComponent();
        }

        CN_SECCIONES objNegocio = new CN_SECCIONES();
        CE_Seccion_IV Seccion_IV = new CE_Seccion_IV();


        private void validarOpcion()
        {
            if (rbtnReferenciaI4Si1.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_I = rbtnReferenciaI4Si1.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }
            if (rbtnReferenciaI4Si2.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_II = rbtnReferenciaI4Si1.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }
            if (rbtnReferenciaI4Si3.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_III = rbtnReferenciaI4Si3.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }

            //-------------------------------------------------------------------------//
            if (rbtnReferenciaI4No1.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_I = rbtnReferenciaI4No1.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }
            if (rbtnReferenciaI4No2.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_II = rbtnReferenciaI4No2.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }
            if (rbtnReferenciaI4No3.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_III = rbtnReferenciaI4No3.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            validarOpcion();
        }
    }
}
