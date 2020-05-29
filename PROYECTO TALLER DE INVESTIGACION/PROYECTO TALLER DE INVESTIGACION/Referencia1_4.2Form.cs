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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        CN_SECCIONES objNegocio = new CN_SECCIONES();
        CE_Seccion_IV Seccion_IV = new CE_Seccion_IV();


     

        private void validarOpcion()
        {
            if (rbtnReferenciaI4Si4.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_IV = rbtnReferenciaI4Si4.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }
            if (rbtnReferenciaI4Si5.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_V = rbtnReferenciaI4Si5.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }
            //-------------------------------------------------------------------
            if (rbtnReferenciaI4No4.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_IV = rbtnReferenciaI4No4.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }
            if (rbtnReferenciaI4No5.Checked)
            {
                Seccion_IV.CUESTIONARIO_IV_V = rbtnReferenciaI4No5.Text.Trim();
                objNegocio.SP_SECCION_IV(Seccion_IV);
            }

        }
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
