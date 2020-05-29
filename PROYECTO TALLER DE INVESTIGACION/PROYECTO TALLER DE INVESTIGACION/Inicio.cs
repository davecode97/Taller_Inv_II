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

    public partial class First : Form
    {
        #region AMBITOS GLOBALES
        private InicioForm inicio;
        private InstruccionesForm instruccionesForm;
        private Datos_Empleado datos_empleado;

        private Referencia1_1Form referencia_1;
        private Referencia1_2Form referencia_2;

        private Referencia1_3Form referencia_3_1;
        private Referencia1_3 referencia_3_2;
        private Form2 referencia_3_3;

        private Referencia1_4Form referencia_4_1;
        private Form3 referencia_4_2;


        private TerminarForm terminar;
        private Referencia1ResultadosForm resultados1;
        private ResultadosFinalesForm resultadosFinales;
        

        #endregion

        #region PANTALLA INCIO
        public First()
        {
            InitializeComponent();
            inicio = new InicioForm();

            inicio.MdiParent = this;
            inicio.Show();

            inicio.btnEmpezar.Click += Pedir_Datos_Empleado;
            inicio.btnResultados1.Click += MostrarResultados1;
            inicio.btnResultadosFinales.Click += MostrarResultadosFinales;
        }
        #endregion

        #region RESULTADOS
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
        #endregion

        #region DATOS DEL EMPLEADO
        private void Pedir_Datos_Empleado(object sender, EventArgs e)
        {
            datos_empleado = new Datos_Empleado();

            datos_empleado.MdiParent = this;
            datos_empleado.Show();

            datos_empleado.btnSiguiente.Click += EmpezarInstrucciones;
            datos_empleado.btnCancelar.Click += CancelarDatos;
        }

        private void CancelarDatos(object sender, EventArgs e)
        {
            datos_empleado.Hide();
            inicio.Show();
        }
        #endregion

        #region INSTRUCCIONES
        private void EmpezarInstrucciones(object sender, EventArgs e) {
            instruccionesForm = new InstruccionesForm();
            instruccionesForm.MdiParent = this;
            inicio.Hide();
            instruccionesForm.Show();

            //instruccionesForm.btnAtras.Click += Pedir_Datos_Empleado;
            instruccionesForm.btnInstruccionesSiguiente.Click += EmpezarReferencia_1;
            instruccionesForm.btnCancelar.Click += CancelarInstrucciones;
        }

        private void CancelarInstrucciones(object sender, EventArgs e)
        {
            instruccionesForm.Hide();
            inicio.Show();

        }
        #endregion

        #region REFERENCIA I
        private void EmpezarReferencia_1(object sender, EventArgs e)
        {
            referencia_1 = new Referencia1_1Form();

            referencia_1.MdiParent = this; 
            instruccionesForm.Hide();
            if(referencia_2 != null) referencia_2.Hide();
            referencia_1.Show();

            referencia_1.btnSiguiente.Click += MostrarReferencia_2;
            referencia_1.btnCancelar.Click += CancelarReferencia_1;

            referencia_1.btnTerminar.Click += TerminarCuestionario;
        }

        private void CancelarReferencia_1(object sender, EventArgs e)
        {
            referencia_1.Hide();
            inicio.Show();
        }
        #endregion

        #region REFERENCIA II
        private void MostrarReferencia_2(object sender, EventArgs e)
        {
            referencia_2 = new Referencia1_2Form();

            referencia_2.MdiParent = this;
            referencia_1.Hide();
            if (referencia_3_1 != null) referencia_3_1.Hide();
            referencia_2.Show();

            referencia_2.btnReferenciaI2Atras.Click += EmpezarReferencia_1;
            referencia_2.btnReferenciaI2Sig.Click += MostrarReferencia_3_1;
            referencia_2.btnCancelar.Click += CancelarReferencia_2;
        }

        private void CancelarReferencia_2(object sender, EventArgs e)
        {
            referencia_2.Hide();
            inicio.Show();
        }
        #endregion 

        #region MOSTRAR REFERENCIA III
        private void MostrarReferencia_3_1(object sender, EventArgs e)
        {
            referencia_3_1 = new Referencia1_3Form();
            
            referencia_3_1.MdiParent = this;
            referencia_2.Hide();
            if (referencia_4_1 != null) referencia_4_1.Hide();
            referencia_3_1.Show();
            
            referencia_3_1.btnReferenciaI3Atras.Click += MostrarReferencia_2;
            referencia_3_1.btnReferenciaI3Sig.Click += MostrarReferencia_3_2;
            referencia_3_1.btnCancelar.Click += CancelarReferencia_3_1;
        }

        private void MostrarReferencia_3_2(object sender, EventArgs e)
        {
            referencia_3_2 = new Referencia1_3();

            referencia_3_2.MdiParent = this;
            referencia_2.Hide();
            if (referencia_3_3 != null) referencia_3_3.Hide(); // Para que no se duplique?
            referencia_3_2.Show();

            referencia_3_2.btnReferenciaI3_2Atras.Click += MostrarReferencia_3_1;
            referencia_3_2.btnReferenciaI3_2Sig.Click += MostrarReferencia_3_3;
            referencia_3_2.btnCancelar.Click += CancelarReferencia_3_2;
        }

        private void MostrarReferencia_3_3(object sender, EventArgs e)
        {
            referencia_3_3 = new Form2();

            referencia_3_3.MdiParent = this;
            referencia_3_2.Hide();
            if (referencia_4_1 != null) referencia_4_1.Hide();
            referencia_3_3.Show();

            referencia_3_3.btnReferenciaI3_3Atras.Click += MostrarReferencia_3_2;
            referencia_3_3.btnReferenciaI3_3Sig.Click += MostrarReferencia_4_1;
            referencia_3_3.btnCancelar.Click += CancelarReferencia_3_3;

        }
        #endregion

        #region CANCELAR REFERENICIA III
        private void CancelarReferencia_3_1(object sender, EventArgs e)
        {
            referencia_3_1.Hide();
            inicio.Show();
        }

        private void CancelarReferencia_3_2(object sender, EventArgs e)
        {
            referencia_3_2.Hide();
            inicio.Show();
        }

        private void CancelarReferencia_3_3(object sender, EventArgs e)
        {
            referencia_3_3.Hide();
            inicio.Show();
        }
        #endregion

        #region MOSTRAR REFERENCIA IV
        private void MostrarReferencia_4_1(object sender, EventArgs e)
        {
            referencia_4_1 = new Referencia1_4Form();

            referencia_4_1.MdiParent = this;
            referencia_3_3.Hide();
            if (referencia_4_2 != null) referencia_4_2.Hide();
            referencia_4_1.Show();

            //Prestar atencion si se duplica form en contenedor.
            referencia_4_1.btnAtras.Click += MostrarReferencia_3_3;
            referencia_4_1.btnSiguiente.Click += MostrarReferencia_4_2;
            referencia_4_1.btnCancelar.Click += CancelarReferencia_4_1;
        }

        private void MostrarReferencia_4_2(object sender, EventArgs e)
        {
            referencia_4_2 = new Form3();

            referencia_4_2.MdiParent = this;
            referencia_4_1.Hide();
            if (terminar != null) terminar.Hide();
            referencia_4_2.Show();

            referencia_4_2.btnReferenciaI2Atras.Click += MostrarReferencia_4_1;
            referencia_4_2.btnTerminar.Click += TerminarCuestionario;
            referencia_4_2.btnCancelar.Click += CancelarReferencia4_2;
        }
        #endregion

        #region CANCELAR REFERECIA IV
        private void CancelarReferencia_4_1(object sender, EventArgs e)
        {
            referencia_4_1.Hide();
            inicio.Show();
        }

        private void CancelarReferencia4_2(object sender, EventArgs e)
        {
            referencia_4_2.Hide();
            inicio.Show();
        }
        #endregion

        #region TERMINAR / MENU PRINCIPAL
        private void TerminarCuestionario(object sender, EventArgs e)
        {
            terminar = new TerminarForm();

            terminar.MdiParent = this;
            if (referencia_1 != null) referencia_1.Hide();
            terminar.Show();

            terminar.btnTerminar.Click += MenuPrincipal;
        }

        private void MenuPrincipal(object sender, EventArgs e)
        {
            terminar.Hide();
            inicio.Show();
        }
        #endregion

        private void IncioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
