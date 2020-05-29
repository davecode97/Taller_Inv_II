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
    public partial class Referencia1_2Form : Form
    {
        public Referencia1_2Form()
        {
            InitializeComponent();
        }

        CN_SECCIONES objNegocio = new CN_SECCIONES();
        CE_Seccion_II Seccion_II = new CE_Seccion_II();

        private void validarOpcion()
        {
            if (rbtnReferenciaI2Si1.Checked)
            {
                Seccion_II.CUESTIONARIO_II_I = rbtnReferenciaI2Si1.Text.Trim();
                objNegocio.SP_SECCION_II(Seccion_II);
            }
            if (rbtnReferenciaI2Si2.Checked)
            {
                Seccion_II.CUESTIONARIO_II_II = rbtnReferenciaI2Si2.Text.Trim();
                objNegocio.SP_SECCION_II(Seccion_II);
            }
            if (rbtnReferenciaI2Si2.Checked)
            {
                Seccion_II.CUESTIONARIO_II_II = rbtnReferenciaI2Si2.Text.Trim();
                objNegocio.SP_SECCION_II(Seccion_II);
            }
            //-----------------------------------------------------------------//
            if (rbtnReferenciaI2No1.Checked)
            {
                Seccion_II.CUESTIONARIO_II_I = rbtnReferenciaI2No1.Text.Trim();
                objNegocio.SP_SECCION_II(Seccion_II);
            }
            if (rbtnReferenciaI2No2.Checked)
            {
                Seccion_II.CUESTIONARIO_II_II = rbtnReferenciaI2No2.Text.Trim();
                objNegocio.SP_SECCION_II(Seccion_II);
            }

        }

        private void btnReferenciaI2Sig_Click(object sender, EventArgs e)
        {
            validarOpcion();
        }
    }
}
