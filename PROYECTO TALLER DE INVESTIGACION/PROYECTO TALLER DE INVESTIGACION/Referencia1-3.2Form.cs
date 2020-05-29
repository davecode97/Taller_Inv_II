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
    public partial class Referencia1_3 : Form
    {
        public Referencia1_3()
        {
            InitializeComponent();
        }


        CN_SECCIONES objNegocio = new CN_SECCIONES();
        CE_Seccion_III Seccion_III = new CE_Seccion_III();


        private void validarOpcion()
        {
            if (rbtnReferenciaI3Si4.Checked)
            {
                Seccion_III.CUESTIONARIO_III_IV = rbtnReferenciaI3Si4.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            if (rbtnReferenciaI3Si5.Checked)
            {
                Seccion_III.CUESTIONARIO_III_V = rbtnReferenciaI3Si5.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            if (rbtnReferenciaI3Si6.Checked)
            {
                Seccion_III.CUESTIONARIO_III_VI = rbtnReferenciaI3Si6.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            //------------------------------------------------------------------------//
            if (rbtnReferenciaI3No4.Checked)
            {
                Seccion_III.CUESTIONARIO_III_IV = rbtnReferenciaI3No4.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            if (rbtnReferenciaI3No5.Checked)
            {
                Seccion_III.CUESTIONARIO_III_V = rbtnReferenciaI3No5.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            if (rbtnReferenciaI3No4.Checked)
            {
                Seccion_III.CUESTIONARIO_III_VI = rbtnReferenciaI3No4.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
        }

        private void btnReferenciaI3_2Sig_Click(object sender, EventArgs e)
        {
            validarOpcion();
        }
    }
}
