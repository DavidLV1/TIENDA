using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TIENDA.PRESENTACION;

namespace TIENDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //EVENTO LOAD DEL FORMULARIO PRINCIPAL
        private void Form1_Load(object sender, EventArgs e)
        {
            pbRestaurar.Visible = false;
        }
        //EVENTO LOAD PARA ALOJAR LOS FOMULARIOS EN EL PANEL PRINCIPAL, RECIBE COMO PARAMETRO UN FORMULARIO
        public void loadForm(object form)
        {
            //EVALUA SI EL PANEL PRINCIPAL CONTIENE UN FORMULARIO ACTIVO
            if (this.pPrincipal.Controls.Count > 0)
            {
                //REMUEVE EL FORMULARIO DEL PANEL PRINCIPAL
                this.pPrincipal.Controls.RemoveAt(0);
            }
            //INICIALIZA EL NUEVO FORMULARIO
            Form f = form as Form;
            //ESTABLECE COMO FORMULARIO INTERIOR
            f.TopLevel = false;
            //LLENA EL PANEL CON EL FORMULARIO
            f.Dock = DockStyle.Fill;
            //AGREGA LOS CONTROLES DEL FORMULARIO AL PANEL
            this.pPrincipal.Controls.Add(f);
            //OBTIENE LOS DATOS SOBRE LOS CONTROLES DEL FORMULARIO
            this.pPrincipal.Tag = f;
            //MUESTRA EL FORMULARIO
            f.Show();
        }
        //
        //EVENTOS PARA LAS PICTUREBOX COMO BOTON DE LA BARRA DE TITULO
        //EVENTO CERRAR
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //EVENTO MAXIMIZAR
        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }
        //EVENTO RESTAURAR
        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }
        //EVENTO MINIMIZAR
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //FIN EVENTO BOTON DE BARRA DE TITULO
        //
        //EVENTOS CAMBIO DE COLOR DE LOS BOTONES CERRAR, MAXIMIZAR, RESTAURAR Y MINIMIZAR
        //CERRAR
        private void pbCerrar_MouseEnter(object sender, EventArgs e)
        {
            pbCerrar.BackColor = SystemColors.Highlight;
        }
        private void pbCerrar_MouseLeave(object sender, EventArgs e)
        {
            pbCerrar.BackColor = Color.FromArgb(20, 5, 50);
        }
        //RESTAURAR
        private void pbRestaurar_MouseEnter(object sender, EventArgs e)
        {
            pbRestaurar.BackColor = SystemColors.Highlight;
        }
        private void pbRestaurar_MouseLeave(object sender, EventArgs e)
        {
            pbRestaurar.BackColor = Color.FromArgb(20, 5, 50);
        }
        //MINIMIZAR
        private void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            pbMinimizar.BackColor = SystemColors.Highlight;
        }
        private void pbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            pbMinimizar.BackColor = Color.FromArgb(20, 5, 50);
        }
        //MAXIMIZAR
        private void pbMaximizar_MouseEnter(object sender, EventArgs e)
        {
            pbMaximizar.BackColor = SystemColors.Highlight;
        }
        private void pbMaximizar_MouseLeave(object sender, EventArgs e)
        {
            pbMaximizar.BackColor = Color.FromArgb(20, 5, 50);
        }
        //FIN EVENTO CAMBIO DE COLOR DE BOTON
        //
        //MOVIMIENTO DE VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void pBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
        //EVENTO BOTON PARA MOSTRAR LOS FORMULARIOS EN EL PANEL PRINCIAPAL
        //BOTON PRODUCTOS
        private void btnProductos_Click(object sender, EventArgs e)
        {
            loadForm(new FormProductos());
            btnProductos.BackColor = Color.Navy;
            btnVentas.BackColor = Color.Transparent;
            btnComprar.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
        }
        //BOTON VENTAS
        private void btnVentas_Click(object sender, EventArgs e)
        {
            loadForm(new FormVentas());
            btnVentas.BackColor = Color.Navy;
            btnProductos.BackColor = Color.Transparent;
            btnComprar.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
        }
        //BOTON COMPRAS
        private void btnComprar_Click(object sender, EventArgs e)
        {
            loadForm(new FormCompras());
            btnComprar.BackColor = Color.Navy;
            btnProductos.BackColor = Color.Transparent;
            btnVentas.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
        }
        //BOTON CARTERA DE CLIENTE
        private void btnCarteraCliente_Click(object sender, EventArgs e)
        {
            loadForm(new FormCarteraCliente());
            btnClientes.BackColor = Color.Navy;
            btnComprar.BackColor = Color.Transparent;
            btnProductos.BackColor = Color.Transparent;
            btnVentas.BackColor = Color.Transparent;
        }
        //FIN EVENTOS MOSTRAR FORMULARIOS
        //EVENTO BOTON LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
