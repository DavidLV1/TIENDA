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
    public partial class FormCarteraCliente : Form
    {
        public FormCarteraCliente()
        {
            InitializeComponent();
        }

        private void FormCarteraCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.pRODUCTOSDataSet.Clientes);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clientesTableAdapter.InsertarCliente(int.Parse(txtCodigoCliente.Text), txtNombreCliente.Text);
                this.clientesTableAdapter.Fill(this.pRODUCTOSDataSet.Clientes);
            }

            catch
            {
                MessageBox.Show("Codigo de cliente ya existe");
            }
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
