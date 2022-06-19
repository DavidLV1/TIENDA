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
        public FormBienvenida(object f)
        {
            InitializeComponent();

            form = f as Form;
        }

        //public Form1 form = new Form1();

        //int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            //count += 1;
            progressBar1.Value += 1;

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                form.Show();
            }
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = "David";
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
