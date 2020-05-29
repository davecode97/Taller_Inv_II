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
    public partial class Referencia1_1Form : Form
    {
        public Referencia1_1Form()
        {
            InitializeComponent();
        }

        CN_SECCIONES objNegocio = new CN_SECCIONES();
        CE_Seccion_I Seccion_I = new CE_Seccion_I();

        private void rbtnReferenciaI1Si1_CheckedChanged(object sender, EventArgs e)
        {
            btnSiguiente.Visible = true;
            btnCancelar.Visible = true;

            btnTerminar.Visible = false;

        }

        private void rbtnReferenciaI1No1_CheckedChanged(object sender, EventArgs e)
        {
            btnTerminar.Visible = true;

            btnSiguiente.Visible = false;
            btnCancelar.Visible = false;

        }

        private void Referencia1_1Form_Load(object sender, EventArgs e)
        {
          
        }

        private void validarOpcion()
        {
            if (rbtnReferenciaI1Si1.Checked)
            {
                Seccion_I.CUESTONARIO_I_I = rbtnReferenciaI1Si1.Text.Trim();
                objNegocio.SP_SECCION_I(Seccion_I);
            }


        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            validarOpcion();
        }
    }
}
