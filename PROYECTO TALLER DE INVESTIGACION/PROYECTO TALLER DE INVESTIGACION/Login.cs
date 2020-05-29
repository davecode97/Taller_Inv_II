using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;
using System.Runtime.InteropServices;

namespace PROYECTO_TALLER_DE_INVESTIGACION
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        CE_Acceso objEntidad = new CE_Acceso();
        CN_Acceso objNegocio = new CN_Acceso();

       
        private void button1_Click(object sender, EventArgs e)
        {
            objEntidad.Username = txtUser.Text;
            objEntidad.Password = txtUser.Text;

            var validarAcceso = objNegocio.SP_ACCESO(objEntidad);
            if (validarAcceso == true)
            {
                First VentanaInicio = new First();
                MessageBox.Show("Bienvenido!");
                VentanaInicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de usuario o contraseña!");
           }
        }

        private void validar()
        {
            
        }

    }
}
