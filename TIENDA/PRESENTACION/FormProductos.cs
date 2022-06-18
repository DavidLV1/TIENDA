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

namespace TIENDA
{
    public partial class FormProductos : Form
    {
        //SE CREA UN NUEVO OBJETO LISTA FUERA DE LOS EVENTOS PARA QUE SOLO SE CREE UNA VEZ
        FABRICA F = new FABRICA();
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.pRODUCTOSDataSet.Productos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                PRODUCTO p = new PRODUCTO(); //de la Interfaz a la Memoria

                p.Codigo = int.Parse(txtCodigo.Text);
                p.Nombre = txtNombre.Text;
                p.Marca = txtMarca.Text;
                p.Precio = decimal.Parse(txtPrecio.Text);
                p.Cantidad = int.Parse(txtCantidad.Text);
                p.Categoria = txtCategoria.Text;
                //p.Caducidad = dTPCaducidad.Value.ToString();

                F.setProducto(p);



                productosTableAdapter.Insertar(p.Codigo, p.Nombre, p.Marca, p.Precio, p.Cantidad, p.Categoria);
                MessageBox.Show("Se agrego un nuevo Producto", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.pRODUCTOSDataSet.Productos);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                PRODUCTO p = new PRODUCTO(); //de la Interfaz a la Memoria

                p.Codigo = int.Parse(txtCodigo.Text);
                p.Nombre = txtNombre.Text;
                p.Marca = txtMarca.Text;
                p.Precio = decimal.Parse(txtPrecio.Text);
                p.Cantidad = int.Parse(txtCantidad.Text);
                p.Categoria = txtCategoria.Text;

                productosTableAdapter.Actualizar(p.Codigo, p.Nombre, p.Marca, p.Precio, p.Cantidad, p.Categoria, int.Parse(lblCodigo3.Text));
                MessageBox.Show("Se actualizado un Producto", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.pRODUCTOSDataSet.Productos);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                productosTableAdapter.Eliminar(int.Parse(lblCodigo3.Text));
                // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.pRODUCTOSDataSet.Productos);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtCategoria.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //F.ActualizarProductos();
            // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.pRODUCTOSDataSet.Productos);
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRODUCTOSDataSet);

        }
    }
}
