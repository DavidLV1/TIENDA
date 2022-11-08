using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIENDA.PRESENTACION
{
    public partial class FormBienvenida : Form
    {
        Form form;
        string Usuario;
        public FormBienvenida(object f, string usuario)
        {
            InitializeComponent();

            form = f as Form;
            Usuario = usuario;
        }
        //EVENTO LOAD PARA EL FORMULARIO BIENVENIDA
        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = Usuario;
            //OPACIDAD EN 0
            this.Opacity = 0.0;
            //INICIA EL TIMER 1
            timer1.Start();
        }
        //TIMER PARA SUBIR LA OPACIDAD DEL FORMULARIO DESPUES DE ABRIR EL FORMULARIO
        private void timer1_Tick(object sender, EventArgs e)
        {
            //EVALUA SI LA OPACIDAD ES MRNO DE 1
            if(this.Opacity < 1)
            {
                //SUBE LA OPACIDAD
                this.Opacity += 0.05;
            }
            //LLENA LA BARRA DE CARGA
            progressBar1.Value += 1;
            //VERIFICA SI LA BARRA DE PROGRESO LLEGO A 100
            if (progressBar1.Value == 100)
            {
                //DETIENE EL TIMER 1
                timer1.Stop();
                //INICIA EL TIMER 1
                timer2.Start();
            }
        }
        //TIMER PARA BAJAR LA OPACIDAD ANTES DE CERRAR EL FORMULARIO
        private void timer2_Tick(object sender, EventArgs e)
        {
            //BAJA LA OPACIDAD
            this.Opacity -= 0.05;
            //VERIFICA SI LA OPACIDAD ES IGUAL A 0
            if(this.Opacity == 0)
            {
                //DETIENE EL TIMER 2
                timer2.Stop();
                //CIERRA EL FORMULARIO BIENVENIDA
                this.Close();
                //ABRE EL FORMULARIO PRINCIPAL
                form.Show();
            }
        }
    }
}
