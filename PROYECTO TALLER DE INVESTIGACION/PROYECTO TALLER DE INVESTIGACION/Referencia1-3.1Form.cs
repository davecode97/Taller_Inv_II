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
    public partial class Referencia1_3Form : Form
    {
        public Referencia1_3Form()
        {
            InitializeComponent();
        }


        CN_SECCIONES objNegocio = new CN_SECCIONES();
        CE_Seccion_III Seccion_III = new CE_Seccion_III();


        private void validarOpcion()
        {
            if (rbtnReferenciaI3Si1.Checked)
            {
                Seccion_III.CUESTIONARIO_III_I = rbtnReferenciaI3Si1.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            if (rbtnReferenciaI3Si2.Checked)
            {
                Seccion_III.CUESTIONARIO_III_II = rbtnReferenciaI3Si2.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            if (rbtnReferenciaI3Si3.Checked)
            {
                Seccion_III.CUESTIONARIO_III_III = rbtnReferenciaI3Si3.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            //--------------------------------------------------------------------//
            if (rbtnReferenciaI3Si1.Checked)
            {
                Seccion_III.CUESTIONARIO_III_I = rbtnReferenciaI3Si1.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            if (rbtnReferenciaI3Si2.Checked)
            {
                Seccion_III.CUESTIONARIO_III_II = rbtnReferenciaI3Si2.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            if (rbtnReferenciaI3Si3.Checked)
            {
                Seccion_III.CUESTIONARIO_III_III = rbtnReferenciaI3Si3.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }

        }

        private void btnReferenciaI3Sig_Click(object sender, EventArgs e)
        {
            validarOpcion();
        }
    }
}
