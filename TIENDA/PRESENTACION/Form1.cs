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

        public void loadForm(object form)
        {

            if (this.pPrincipal.Controls.Count > 0)
            {
                this.pPrincipal.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pPrincipal.Controls.Add(f);
            this.pPrincipal.Tag = f;
            f.Show();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbRestaurar.Visible=false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbCerrar_MouseEnter(object sender, EventArgs e)
        {
            pbCerrar.BackColor = SystemColors.Highlight;
        }

        private void pbCerrar_MouseLeave(object sender, EventArgs e)
        {
            pbCerrar.BackColor = Color.FromArgb(20, 5, 50);
        }

        private void pbRestaurar_MouseEnter(object sender, EventArgs e)
        {
            pbRestaurar.BackColor = SystemColors.Highlight;
        }

        private void pbRestaurar_MouseLeave(object sender, EventArgs e)
        {
            pbRestaurar.BackColor = Color.FromArgb(20, 5, 50);
        }

        private void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            pbMinimizar.BackColor = SystemColors.Highlight;
        }

        private void pbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            pbMinimizar.BackColor = Color.FromArgb(20, 5, 50);
        }

        private void pbMaximizar_MouseEnter(object sender, EventArgs e)
        {
            pbMaximizar.BackColor = SystemColors.Highlight;
        }

        private void pbMaximizar_MouseLeave(object sender, EventArgs e)
        {
            pbMaximizar.BackColor = Color.FromArgb(20, 5, 50);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            loadForm(new FormProductos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            loadForm(new FormVentas());
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            loadForm(new FormCompras());
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            loadForm(new FormEstadisticas());
        }

        private void btnCarteraCliente_Click(object sender, EventArgs e)
        {
            loadForm(new FormCarteraCliente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
