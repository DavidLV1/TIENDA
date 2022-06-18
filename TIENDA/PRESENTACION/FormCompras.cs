using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIENDA.DATOS;
using TIENDA.LOGICA;

namespace TIENDA.PRESENTACION
{
    public partial class FormCompras : Form
    {
        FABRICA F = new FABRICA();
        public FormCompras()
        {
            InitializeComponent();
        }

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRODUCTOSDataSet);

        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.pRODUCTOSDataSet.Compras);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                PRODUCTO p = new PRODUCTO(); //de la Interfaz a la Memoria

                p.Codigo = int.Parse(txtCodigo.Text);
                p.Nombre = txtNombre.Text;
                p.Marca = txtMarca.Text;
                p.PrecioCompra = decimal.Parse(txtPreciodeCompra.Text);
                p.Cantidad = int.Parse(txtCantidad.Text);

                comprasTableAdapter.InsertarCompras(p.Codigo, p.Nombre, p.Marca, p.PrecioCompra, p.Cantidad);
                // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Compras' Puede moverla o quitarla según sea necesario.
                this.comprasTableAdapter.Fill(this.pRODUCTOSDataSet.Compras);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

