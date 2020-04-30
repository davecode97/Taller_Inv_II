using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_TALLER_DE_INVESTIGACION
{

    public partial class Form1 : Form
    {
        private InicioForm inicio;
        private Referencia1_1Form referenciai1;
        private Referencia1_2Form referenciai2;
        private Referencia1_3Form referenciai3;
        private Referencia1_4Form referenciai4;
        private TerminarForm terminar;
        private Referencia1ResultadosForm resultados1;
        private ResultadosFinalesForm resultadosFinales;
        public Form1()
        {
            InitializeComponent();
            inicio = new InicioForm();
            inicio.MdiParent = this;
            inicio.Show();
            inicio.btnEmpezar.Click += EmpezarReferencia1;
            inicio.btnResultados1.Click += MostrarResultados1;
            inicio.btnResultadosFinales.Click += MostrarResultadosFinales;
        }

        private void MostrarResultados1(object sender, EventArgs e)
        {
            resultados1 = new Referencia1ResultadosForm();
            resultados1.MdiParent = this;
            inicio.Hide();
            resultados1.Show();
            resultados1.btnResultados1Volver.Click += VolverResultados1;
        }

        private void VolverResultados1(object sender, EventArgs e)
        {
            resultados1.Hide();
            inicio.Show();
        }

        private void MostrarResultadosFinales(object sender, EventArgs e)
        {
            resultadosFinales = new ResultadosFinalesForm();
            resultadosFinales.MdiParent = this;
            inicio.Hide();
            resultadosFinales.Show();
            resultadosFinales.btnResultadosFinalesVolver.Click += VolverResultadosFinales;
        }

        private void VolverResultadosFinales(object sender, EventArgs e)
        {
            resultadosFinales.Hide();
            inicio.Show();
        }
        //796, 445
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void EmpezarReferencia1(object sender, EventArgs e)
        {
            referenciai1 = new Referencia1_1Form();
            referenciai1.MdiParent = this; 
            inicio.Hide();
            if(referenciai2 != null) referenciai2.Hide();
            referenciai1.Show();
            referenciai1.btnReferenciaI1Sig.Click += MostrarReferenciaI2;
            referenciai1.btnCancelar.Click += CancelarReferenciaI1;
        }

        private void CancelarReferenciaI1(object sender, EventArgs e)
        {
            referenciai1.Hide();
            inicio.Show();
        }

        private void MostrarReferenciaI2(object sender, EventArgs e)
        {
            referenciai2 = new Referencia1_2Form();
            referenciai2.MdiParent = this;
            referenciai1.Hide();
            if (referenciai3 != null) referenciai3.Hide();
            referenciai2.Show();
            referenciai2.btnReferenciaI2Atras.Click += EmpezarReferencia1;
            referenciai2.btnReferenciaI2Sig.Click += MostrarReferenciaI3;
            referenciai2.btnCancelar.Click += CancelarReferenciaI2;
        }

        private void CancelarReferenciaI2(object sender, EventArgs e)
        {
            referenciai2.Hide();
            inicio.Show();
        }

        private void MostrarReferenciaI3(object sender, EventArgs e)
        {
            referenciai3 = new Referencia1_3Form();
            referenciai3.MdiParent = this;
            referenciai2.Hide();
            if (referenciai4 != null) referenciai4.Hide();
            referenciai3.Show();
            referenciai3.btnReferenciaI3Atras.Click += MostrarReferenciaI2;
            referenciai3.btnReferenciaI3Sig.Click += MostrarReferenciaI4;
            referenciai3.btnCancelar.Click += CancelarReferenciaI3;
        }

        private void CancelarReferenciaI3(object sender, EventArgs e)
        {
            referenciai3.Hide();
            inicio.Show();
        }

        private void MostrarReferenciaI4(object sender, EventArgs e)
        {
            referenciai4 = new Referencia1_4Form();
            referenciai4.MdiParent = this;
            referenciai3.Hide();
            referenciai4.Show();
            referenciai4.btnReferenciaI4Atras.Click += MostrarReferenciaI3;
            referenciai4.btnReferenciaI4Terminar.Click += TerminarCuestionario;
            referenciai4.btnCancelar.Click += CancelarReferenciaI4;
        }

        private void CancelarReferenciaI4(object sender, EventArgs e)
        {
            referenciai4.Hide();
            inicio.Show();
        }

        private void TerminarCuestionario(object sender, EventArgs e)
        {
            terminar = new TerminarForm();
            terminar.MdiParent = this;
            referenciai4.Hide();
            terminar.Show();
            terminar.btnTerminar.Click += MenuPrincipal;
        }

        private void MenuPrincipal(object sender, EventArgs e)
        {
            terminar.Hide();
            inicio.Show();
        }
    }
}
