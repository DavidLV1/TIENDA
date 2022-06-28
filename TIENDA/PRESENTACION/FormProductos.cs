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
using TIENDA.DATOS;
using TIENDA.LOGICA;

namespace TIENDA
{
    public partial class FormProductos : Form
    {
        //SE CREA UN NUEVO OBJETO LISTA FUERA DE LOS EVENTOS PARA QUE SOLO SE CREE UNA VEZ
        LISTAS l = new LISTAS();
        public FormProductos()
        {
            InitializeComponent();
        }
        //CONEXION SQL
        SqlConnection Conect = new SqlConnection(ConfigurationManager.ConnectionStrings["TIENDA.Properties.Settings.conexion"].ConnectionString);
        private void FormProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Productos'
            this.productosTableAdapter.Fill(this.pRODUCTOSDataSet.Productos);
        }
        //EVENTO BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //CREA NUEVO OBJETO
                PRODUCTO p = new PRODUCTO(); //de la Interfaz a la Memoria
                //SE ALMACENAN LOS DATOS
                p.Codigo = int.Parse(txtCodigoProducto.Text);
                p.Nombre = txtNombreProducto.Text;
                p.Marca = txtMarca.Text;
                p.Precio = decimal.Parse(txtPrecio.Text);
                p.Cantidad = int.Parse(txtCantidad.Text);
                p.Categoria = txtCategoria.Text;
                //p.Caducidad = dTPCaducidad.Value.ToString();
                //SE PASA A LA LISTA (NO SE USA)
                l.setProducto(p);
                //INSERTA UN PRODUCTO A LA TABLA DE LA BASE DE DATOS 
                productosTableAdapter.Insertar(p.Codigo, p.Nombre, p.Marca, p.Precio, p.Cantidad, p.Categoria);
                //MENSAJE
                MessageBox.Show("Se agrego un nuevo Producto", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Productos' 
                this.productosTableAdapter.Fill(this.pRODUCTOSDataSet.Productos);
            }

            catch (Exception ex)
            {
                //MENSAJE DE ERROR
                MessageBox.Show(ex.Message);
            }
        }
        //EVENTO BOTON ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //CREA NUEVO OBJETO
                PRODUCTO p = new PRODUCTO();
                //ALMACENA LOS DATOS
                p.Codigo = int.Parse(txtCodigoProducto.Text);
                p.Nombre = txtNombreProducto.Text;
                p.Marca = txtMarca.Text;
                p.Precio = decimal.Parse(txtPrecio.Text);
                p.Cantidad = int.Parse(txtCantidad.Text);
                p.Categoria = txtCategoria.Text;
                //ACTUALIZA UN PRODUCTO DE LA BASE DE DATOS
                productosTableAdapter.Actualizar(p.Codigo, p.Nombre, p.Marca, p.Precio, p.Cantidad, p.Categoria, int.Parse(lblCodigoProducto3.Text));
                MessageBox.Show("Se actualizado un Producto", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.pRODUCTOSDataSet.Productos);
            }

            catch (Exception ex)
            {
                //MENSAJE DE ERROR
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //ELIMINA UN PRODUCTO
                productosTableAdapter.Eliminar(int.Parse(lblCodigoProducto3.Text));
                // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.pRODUCTOSDataSet.Productos);
            }

            catch (Exception ex)
            {
                //MENSAJE DE ERROR
                MessageBox.Show(ex.Message);
            }
        }
        //EVENTO BOTON NUEVO
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //BORRA EL CONTENIDO DE LOS TEXTBOX
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtCategoria.Clear();
            //BORRA CONTENIDO DEL LABEL
            lblCodigoProducto3.Text = string.Empty;
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //VERIFICA SI TXTCODIGO NO ESTA VACIO
            if (txtCodigoProducto.Text != string.Empty)
            {
                try
                {
                    //ABRE CONEXION SQL
                    Conect.Open();
                    //COMANDO BUSCAR
                    SqlCommand Buscar = new SqlCommand("SELECT [Codigo de Producto], [Nombre del Producto], Marca, Precio, Cantidad, Categoria FROM Productos WHERE [Codigo de Producto] =" + int.Parse(txtCodigoProducto.Text), Conect);
                    //LECTOR SQL
                    SqlDataReader lector = Buscar.ExecuteReader();
                    //VERIFICA SI EL LECTOR CONTIENE FILAS
                    if (lector.Read())
                    {
                        //LLENAN LOS TEXTBOX CORRESPONDIENTES A CADA DATO
                        txtNombreProducto.Text = lector["Nombre del Producto"].ToString();
                        txtMarca.Text = lector["Marca"].ToString();
                        txtPrecio.Text = lector["Precio"].ToString();
                        txtCantidad.Text = lector["Cantidad"].ToString();
                        txtCategoria.Text = lector["Categoria"].ToString();
                        lblCodigoProducto3.Text = lector["Codigo de Producto"].ToString();
                    }
                }

                catch(Exception ex)
                {
                    //MENSAJE DE ERROR
                    MessageBox.Show(ex.Message);
                }
            }
            //CIERRA CONEXION SQL
            Conect.Close();
        }
    }
}
