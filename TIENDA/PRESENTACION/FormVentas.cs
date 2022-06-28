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

namespace TIENDA.PRESENTACION
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }
        //CONEXION SQL
        SqlConnection Conect = new SqlConnection(ConfigurationManager.ConnectionStrings["TIENDA.Properties.Settings.conexion"].ConnectionString);
        //EVENTO LOAD PARA EL FORMULARIO COMPRAS
        private void FormVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Compras'.
            this.ventasTableAdapter.Fill(this.pRODUCTOSDataSet.Ventas);

        }
        //EVENTO BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //ABRE CONEXION SQL
            Conect.Open();
            try
            {
                //CREA UN OBJETO
                PRODUCTO p = new PRODUCTO();
                //ALMACENA LOS DATOS DENTRO DEL OBJETO
                p.Codigo = int.Parse(txtCodigoProducto.Text);
                p.Nombre = txtNombreProducto.Text;
                p.Marca = txtMarca.Text;
                p.PrecioCompra = decimal.Parse(txtPrecio.Text);
                p.Cantidad = int.Parse(txtCantidad.Text);
                //AGREGA LOS DATOS A LA TABLA COMPRAS
                ventasTableAdapter.InsertarVentas(p.Codigo, p.Nombre, p.Cantidad, p.Marca, p.Precio);
                //COMANDO SQL PARA ACTUALIZAR LAS EXISTENCIAS DE LA TABLA PRODUCTOS
                SqlCommand RestarCantidad = new SqlCommand("UPDATE Productos SET Cantidad = Cantidad -" + p.Cantidad + "WHERE [Codigo de Producto] =" + p.Codigo, Conect);
                //EJECUTA EL COMANDO PARA AZTUALIZAR LA TABLA PRODUCTOS
                RestarCantidad.ExecuteNonQuery();
                //CARGA LOS DATOS EN LA TABLA COMPRAS
                this.ventasTableAdapter.Fill(this.pRODUCTOSDataSet.Ventas);
            }

            catch (Exception ex)
            {
                //MENSAJE DE ERROR
                MessageBox.Show(ex.Message);
            }
            //CIERRA CONEXION SQL
            Conect.Close();
        }
        //EVENTO PARA TXTCODIGO AGREGA AUTOMATICAMENTE LOS DATOS DEL PRODUCTO SI YA ESTA REGISTRADO
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //VERIFICA SI TXTCODIGO NO ESTA VACIO
            if (txtCodigoProducto.Text != string.Empty)
            {
                //ABRE CONEXION SQL
                Conect.Open();
                //COMANDO BUSCAR
                SqlCommand Buscar = new SqlCommand("SELECT [Nombre del Producto], Marca FROM Productos WHERE [Codigo de Producto] =" + int.Parse(txtCodigoProducto.Text), Conect);
                //LECTOR SQL
                SqlDataReader lector = Buscar.ExecuteReader();
                //VERIFICA SI EL LECTOR CONTIENE FILAS
                if (lector.Read())
                {
                    //LLENAN LOS TEXTBOX CORRESPONDIENTES A CADA DATO
                    txtNombreProducto.Text = lector["Nombre del Producto"].ToString();
                    txtMarca.Text = lector["Marca"].ToString();
                }
                //SI NO CONTIENE FILAS
                else
                {
                    //MENSAJE DE ERROR
                    MessageBox.Show("Codigo de producto no existe");
                    //BORRA EL CONTENIDO DE TXTCODIGO
                    txtCodigoProducto.Text = string.Empty;
                }
            }
            //CIERRA CONEXION SQL
            Conect.Close();
        }
    }
}
