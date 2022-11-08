using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIENDA.PRESENTACION
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }
        //CONEXION A LA BASE DE DATOS
        SqlConnection Conect = new SqlConnection(ConfigurationManager.ConnectionStrings["TIENDA.Properties.Settings.conexion"].ConnectionString);
        //EVENTO LOAD DEL FORMULARIO
        private void FormLogin_Load(object sender, EventArgs e)
        {
            //MENSAJE DE ERROR QUE INICIALIZA OCULTO
            lblMensajeError.Visible = false;
        }
        //EVENTO PARA LA PICTUREBOX COMO BOTON DE CERRAR Y MINIMIZAR
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //FIN EVENTO BOTON
        //EVENTOS PARA CAMBIAR DE COLOR DE LOS BOTONES CERRAR Y MINIMIZAR CUANDO EL MOUSE PASA SOBRE EL
        private void pbCerrar_MouseEnter(object sender, EventArgs e)
        {
            pbCerrar.BackColor = SystemColors.Highlight;
        }

        private void pbCerrar_MouseLeave(object sender, EventArgs e)
        {
            pbCerrar.BackColor = Color.FromArgb(20, 5, 50);
        }
        private void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            pbMinimizar.BackColor = SystemColors.Highlight;
        }

        private void pbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            pbMinimizar.BackColor = Color.FromArgb(20, 5, 50);
        }
        //FIN EVENTO CAMBIO DE COLOR
        //EVENTO PARA EL BOTON ACCEDER
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //CREAR OBJETO DEL FORMULARIO PRINCIPAL
            Form1 form = new Form1();
            string Usuario;
            //VALIDACION DE ESPACIOS VACIOS
            if (txtUsuario.Text != string.Empty && txtContraseña.Text != string.Empty)
            {
                //VALIDACION DE ESPACIO VACIO USUARIO
                if (txtUsuario.Text != string.Empty)
                {
                    //VALIDACION DE ESPACIO VACIO CONTRASEÑA
                    if (txtContraseña.Text != string.Empty)
                    {
                        //ABRE LA CONEXION A LA BASE DE DATOS
                        Conect.Open();
                        //CONSULTA PARA EL INICIO DE SESION
                        SqlCommand comando = new SqlCommand("SELECT Usuario, Contraseña FROM Usuarios WHERE Usuario = @vusuario AND Contraseña = @vcontraseña", Conect);
                        //ENVIA PARAMETROS A LA CONSULTA
                        comando.Parameters.AddWithValue("@vusuario", txtUsuario.Text);
                        comando.Parameters.AddWithValue("@vcontraseña", txtContraseña.Text);
                        //LECTOR PARA COMPARAR DATOS CON CADA FILA DE LA BASE DE DATOS
                        SqlDataReader lector = comando.ExecuteReader();
                        //VALIDACION SI LOS DATOS PARA EL LOGIN COINSIDEN
                        if (lector.Read())
                        {
                            Usuario = txtUsuario.Text;
                            //CREA OBJETO DEL FORMULARIO BIENVENIDA
                            FormBienvenida Bienvenida = new FormBienvenida(form, Usuario);
                            //CIERRA LA CONEXION A LA BASE DE DATOS
                            Conect.Close();
                            //OCULTA EL FORMULARIO LOGIN
                            this.Hide();
                            //ABRE EL FORMULARIO BIENVENIDA
                            Bienvenida.Show();
                            //LLAMADO A METODO LOGOUT CUANDO EL FORMULARIO PRINCIPAL SE CIERRE
                            form.FormClosed += Logout;
                        }
                        //MENSAJE DE ERROR SI NO COINCIDEN
                        else
                        {
                            msjError("Usuario o Contraseña incorrectos");
                            //LIMPIA LOS TEXTBOX
                            txtUsuario.Clear();
                            txtContraseña.Clear();
                            //CIERRA LA CONEXION A LA BASE DE DATOS
                            Conect.Close();
                        }
                    }
                    //MENSAJE DE ERROR SI NO INGRESA LA CONTRASEÑA
                    else
                    {
                        msjError("Por favor ingrese la contraseña");
                    }
                }
                //MENSAJE DE ERROR SI NO INGRESA NOMBRE DE USUARIO
                else
                {
                    msjError("Por favor ingrese nombre de usuario");
                }
            }
            //MENSAJE DE ERROR SI AMBOS CAMPOS ESTAN VACIOS
            else
            {
                msjError("Por favor ingrese nombre de usuario y contraseña");
            }
        }
        //METODO EL MENSAJES DE ERROR
        private void msjError(string msj)
        {
            lblMensajeError.Text = "   " + msj;
            lblMensajeError.Visible = true;
        }
        //METODO PARA EVENTO LOGOUT DEL FORMULARIO PRINCIPAL
        public void Logout(object sender, FormClosedEventArgs e)
        {
            //LIMPIA LOS CUADROS DE TEXTOS
            txtUsuario.Clear();
            txtContraseña.Clear();
            //OCULTA EL MENSAJE DE ERROR
            lblMensajeError.Visible = false;
            //MUESTRA EL FOMULARIO LOGIN
            this.Show();
        }
        //SINTAXIS PARA EL MOVIMIENTO LIBRE DEL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //FIN
        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnAcceder_Click(sender, e);
            }
        }
    }
}
