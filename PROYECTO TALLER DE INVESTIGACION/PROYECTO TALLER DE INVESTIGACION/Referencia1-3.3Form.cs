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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        CN_SECCIONES objNegocio = new CN_SECCIONES();
        CE_Seccion_III Seccion_III = new CE_Seccion_III();


        private void validarOpcion()
        {
            if (rbtnReferenciaI3Si7.Checked)
            {
                Seccion_III.CUESTIONARIO_III_VII = rbtnReferenciaI3Si7.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
            //--------------------------------------------------------------------//
            if (rbtnReferenciaI3No7.Checked)
            {
                Seccion_III.CUESTIONARIO_III_VII = rbtnReferenciaI3No7.Text.Trim();
                objNegocio.SP_SECCION_III(Seccion_III);
            }
        }

        private void btnReferenciaI3_3Sig_Click(object sender, EventArgs e)
        {
            validarOpcion();
        }
    }
}
