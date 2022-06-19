using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        FormBienvenida Bienvenida = new FormBienvenida();

        SqlConnection Conect = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblMensajeError.Visible = false;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != string.Empty)
            {
                if(txtContraseña.Text != string.Empty)
                {
                    try
                    {
                        Conect.Open();
                        SqlCommand comando = new SqlCommand("SELECT Usuario, Contraseña FROM Usuarios WHERE Usuario = @vusuario AND Contraseña = @vcontraseña", Conect);
                        comando.Parameters.AddWithValue("@vusuario", txtUsuario.Text);
                        comando.Parameters.AddWithValue("@vcontraseña", txtContraseña.Text);

                        SqlDataReader lector = comando.ExecuteReader();

                        if (lector.Read())
                        {
                            Conect.Close();
                            this.Hide();
                            Bienvenida.Show();
                        }
                    }

                    catch
                    {
                        msjError("Usuario o Contraseña incorrectos");

                        txtUsuario.Clear();
                        txtContraseña.Clear();
                        Conect.Close();
                    }
                }

                else
                {
                    msjError("Por favor ingrese la contraseña");
                }
            }

            else
            {
                msjError("Por favor ingrese nombre de usuario");
            }
        }

        private void msjError(string msj)
        {
            lblMensajeError.Text = "   " + msj;
            lblMensajeError.Visible = true;
        }
    }
}
